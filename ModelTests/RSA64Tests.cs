using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assigment2.Logic;
using NUnit.Framework;

namespace ModelTests
{
    [TestFixture]
    public class RSA64Tests
    {
        [Test]
        public void CheckIf5IsPrime()
        {
            Assert.IsTrue(RSA64Bit.isPrime(5));
        }

        [Test]
        public void CheckIf23IsPrime()
        {
            Assert.IsTrue(RSA64Bit.isPrime(23));
        }

        [Test]
        public void CheckIf41IsPrime()
        {
            Assert.IsTrue(RSA64Bit.isPrime(41));
        }

        [Test]
        public void SetE()
        {
            var rsa = new RSA64Bit();
            rsa.SetTotient(17, 11);
            rsa.SetPublicKeyFactor(rsa.Totient);
            var e = rsa.PublicKeyFactor;
            Assert.IsTrue(e < rsa.Totient && e > 1);
        }

        [Test]
        public void SetD()
        {
            var rsa = new RSA64Bit();
            rsa.SetTotient(17, 11);
            rsa.SetPublicKeyFactor(rsa.Totient);
            rsa.SetPrivateKeyFactor(rsa.PublicKeyFactor, rsa.Totient);
            Assert.IsTrue(rsa.PrivateKeyFactor == 23);
        }

        [Test]
        public void TestEncryption()
        {
            var rsa = new RSA64Bit();
            rsa.SetTotient(17, 11);
            rsa.SetPrimeProductRood(17, 11);
            rsa.SetPublicKeyFactor(rsa.Totient);
            rsa.SetPrivateKeyFactor(rsa.PublicKeyFactor, rsa.Totient);
            Assert.IsTrue("00001011".Equals(rsa.Encrypt("o", rsa.PublicKeyFactor, rsa.PrimeProductRoof)));
        }

        [Test]
        public void TestDecryption()
        {
            var rsa = new RSA64Bit();
            rsa.SetTotient(17, 11);
            rsa.SetPrimeProductRood(17, 11);
            rsa.SetPublicKeyFactor(rsa.Totient);
            rsa.SetPrivateKeyFactor(rsa.PublicKeyFactor, rsa.Totient);
            Assert.IsTrue("o".Equals(rsa.Decrypt("00001011", rsa.PrivateKeyFactor, rsa.PrimeProductRoof)));
        }

        [Test]
        public void TestForRandomNumbers()
        {
            for (int i = 10; i < 16; i++)
            {
                Assert.IsTrue(RSA64Bit.isPrime(RSA64Bit.GetRandomPrimeNumber(i, 13)));
            }
        }
    }
}