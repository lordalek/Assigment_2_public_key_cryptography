using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment2.Logic
{
    public class RSA64Bit
    {
        public long PrimeProductRoof { get; set; }
        public long Totient { get; set; }
        public long PrimeA { get; set; }
        public long PrimeB { get; set; }
        public long PublicKeyFactor { get; set; }
        public long PrivateKeyFactor { get; set; }
        private const int LetterBuffer = 23;

        public static bool isPrime(long maybePrimeNumber)
        {
            if (maybePrimeNumber <= 2)
                return false;
            var counter = 2;
            while (counter <= maybePrimeNumber/2)
            {
                if (maybePrimeNumber%counter == 0)
                    return false;
                counter+=2;
            }
            return true;
        }

        public void SetPrimeProductRood(long primeA, long primeB)
        {
            if (!isPrime(primeA) || !isPrime(primeB))
                throw new Exception("Invalid primes");
            try
            {
                PrimeProductRoof = primeA*primeB;
            }
            catch (Exception)
            {
                throw new Exception("Prime numbers are too large. Prime product is bigger than 2^64");
            }
        }

        public void SetTotient(long primeA, long primeB)
        {
            if (!isPrime(primeA) || !isPrime(primeB))
                throw new Exception("Invalid primes");
            try
            {
                Totient = (primeB - 1)*(primeA - 1);
            }
            catch (Exception)
            {
                throw new Exception("Prime numbers are too large. Totient is bigger than 2^64");
            }
        }

        public void SetPublicKeyFactor(long totient)
        {
            var e = 3;
            var gcd = 0L;
            while (gcd != 1 && e < totient && e < totient)
            {
                e += 2;
                gcd = CalculateCommonDenominator(totient, e);
            }
            PublicKeyFactor = e;
        }

        public static long CalculateCommonDenominator(long number1, long number2)
        {
            while (number2 != 0)
            {
                var temp = number1%number2;
                number1 = number2;
                number2 = temp;
            }
            return number1;
        }

        public void SetPrivateKeyFactor(long publicKeyFactor, long totient)
        {
            var privateKeyFactor = 3L;
            var one = 0L;
            while (one != 1)
            {
                privateKeyFactor++;
                var product = publicKeyFactor*privateKeyFactor;
                one = product%totient;
            }
            PrivateKeyFactor = privateKeyFactor;
        }

        public string Encrypt(string plaintText, long publiKeyFactor, long primeProduct)
        {
            if (plaintText == null || plaintText.Length <= 0) throw new ArgumentNullException("plaintText");
            if (!isPrime(publiKeyFactor)) throw new ArgumentNullException("publiKeyFactor");
            var sb = new StringBuilder();
            foreach (var letter in plaintText)
            {
                var byteValue = Encoding.UTF8.GetBytes(letter.ToString());
                byteValue = byteValue.Reverse().ToArray();
                var temp = long.Parse(byteValue[0].ToString());
                temp -= LetterBuffer;
                temp = ModPower(temp, publiKeyFactor, primeProduct);
                sb.Append(Convert.ToString(temp, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }

        public string Decrypt(string cipherText, long privateKeyFactor, long primeProduct)
        {
            if (cipherText == null || cipherText.Length <= 0) throw new ArgumentNullException("cipherText");
            if (!isPrime(privateKeyFactor)) throw new ArgumentNullException("privateKeyFactor");
            var sb = new StringBuilder();
            while (cipherText.Length%8 != 0)
            {
                cipherText = cipherText.Insert(0, "0");
            }
            for (int i = 0; i < cipherText.Length - 1; i += 8)
            {
                var binaryString = cipherText.Substring(i, 8);
                var numbers = Convert.ToInt64(binaryString, 2);
                numbers = ModPower(numbers, privateKeyFactor, primeProduct);
                numbers += LetterBuffer;
                var letter = Encoding.UTF8.GetString(new[] {byte.Parse(numbers.ToString())});
                sb.Append(letter);
            }
            return sb.ToString();
        }

        public static long ModPower(long number, long power, long mod)
        {
            var tempNumber = number;
            for (int i = 0; i < power - 1; i++)
            {
                number = number*tempNumber;
                number = number%mod;
            }
            return number;
        }

        public static long GetRandomPrimeNumber(int seed, int numberOfNumbers)
        {
            if (seed <= 0)
                return -1;
            var prime = 0L;
            prime += (16807*seed)%2147483647;
            var prev = prime;
            while (!isPrime(Math.Abs(prime)))
            {
                if (prime.ToString().Length < numberOfNumbers.ToString().Length)
                    prime = prime += (16807*(seed + 13))%2147483647;
                var flow = (16807*prev)%2147483647;
                prime += flow;
                prev = prime;
            }
            return Math.Abs(prime);
        }
    }
}