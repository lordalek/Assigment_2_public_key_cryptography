using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assigment2.Interfaces;

namespace Assigment2.Models
{
    public class ReallyBigNumber : IReallyBigNumber
    {
        public List<long> Numbers = new List<long>();
        public long DividentSummation { get; set; }

        public bool IsPrime(ReallyBigNumber bigNumber)
        {
            var isPrime = bigNumber.Numbers[bigNumber.Numbers.Count - 1]%2 != 0;
            if (!isPrime)
                return false;
            var idx = new ReallyBigNumber("3");
            var firstRun = true;
            while (IsSmallerOrEqualThanHalf(idx))
            {
                var operatingNumber = bigNumber;
                if (firstRun)
                {
                    var firstRunTemp = 3L;
                    while (firstRunTemp.ToString().Length < operatingNumber.Numbers.Count - 1)
                    {
                        firstRunTemp = firstRunTemp*3;
                    }
                    operatingNumber.Remainder(firstRunTemp);
                }
                operatingNumber.Remainder(idx);
                if (operatingNumber.Numbers[operatingNumber.Numbers.Count - 1] == 0)
                    isPrime = false;
                idx.Addition(2);
            }

            return isPrime;
        }

        public ReallyBigNumber GenerateReallyBigNumber()
        {
            throw new NotImplementedException();
        }

        public ReallyBigNumber(string bigNumberAsString)
        {
            if (string.IsNullOrEmpty(bigNumberAsString))
                throw new ArgumentNullException("bigNumberAsString");

            foreach (var number in bigNumberAsString)
            {
                Numbers.Add(long.Parse(number.ToString()));
            }
        }

        public ReallyBigNumber Multiply(ReallyBigNumber b)
        {
            var multipledBigNumber = new ReallyBigNumber("0");
            if (b.Numbers.Count != Numbers.Count)
                b.Numbers = AppendPaddingToList(b.Numbers);
            for (var i = b.Numbers.Count - 1; i >= 0; i--)
            {
                var padder = b.Numbers.Count - i;
                var component = (b.Numbers[i]*(long.Parse("1".PadRight(padder, '0'))));
                if (component == 0) continue;
//                for (var j = 0; j < Numbers.Count; j++)
//                {
                var tempNumbers = new ReallyBigNumber(this.ToString()); // new List<long>(); 
                tempNumbers.Multiply(component);
//                    tempNumbers[j] = tempNumbers[j] * component;
                multipledBigNumber.Addition(tempNumbers.Numbers);
//                    Numbers[j] += overflow;
//                    overflow = 0;
//                    if(Numbers[j] <= 9) continue;
//                    while (Numbers[j] > 9)
//                    {
//                        overflow++;
//                        Numbers[j] -= 10;
////                    }
////                    if (i == 0 && overflow > 0)
////                    {
////                        Numbers.Insert(0, overflow);
////                        overflow = 0;
////                    }
//                    }
//                }
            }

            return multipledBigNumber;
        }

        public ReallyBigNumber Multiply(long b)
        {
            if (b == 0)
            {
                return this;
            }
            var overflow = 0;
            for (var i = Numbers.Count - 1; i > 0 - 1; i--)
            {
                Numbers[i] = Numbers[i]*b;
                Numbers[i] = Numbers[i] + overflow;
                overflow = 0;
                //no overflow
                if (Numbers[i] <= 9) continue;
                //the leftmost longeger is bigger than 10 causing overflow.
                while (Numbers[i] > 9)
                {
                    overflow++;
                    Numbers[i] = Numbers[i] - 10;
                }

                if (i == 0 && overflow > 0)
                {
                    Numbers.Insert(0, overflow);
                    overflow = 0;
                }
            }
            while (Numbers[0] > 9)
            {
                overflow++;
                Numbers[0] = Numbers[0] - 10;
            }
            if (overflow > 0)
            {
                OverChargeOverFlow(overflow, 0);
            }
            return this;
        }

        public void OverChargeOverFlow(long overflow, int idx)
        {
            if (overflow > 0)
            {
                if (idx <= 0)
                {
                    Numbers.Insert(0, overflow);
                    overflow = 0;
                    while (Numbers[0] > 9)
                    {
                        overflow++;
                        Numbers[0] = Numbers[0] - 10;
                    }
                    OverChargeOverFlow(overflow, idx);
                }
                else
                {
                    Numbers[idx - 1] += overflow;
                    overflow = 0;
                    while (Numbers[idx - 1] > 9)
                    {
                        overflow++;
                        Numbers[idx - 1] = Numbers[idx - 1] - 10;
                    }
                    OverChargeOverFlow(overflow, --idx);
                }
            }
        }

        public ReallyBigNumber Subtraction(List<long> b)
        {
            if (b.Count != Numbers.Count)
                b = AppendPaddingToList(b);
            for (var i = b.Count - 1; i >= 0; i--)
            {
                if (b[i] > Numbers[Numbers.Count - i - 1])
                {
                    var preIdex = 0;
                    if (Numbers[Numbers.Count - i - 1] <= 0)
                        while (Numbers[Numbers.Count - i - 1 + preIdex] <= 0
                               && (Numbers.Count + preIdex > 1)
                               && HasMore10sToLend(i - preIdex))
                        {
                            Borrow10(i - preIdex);
                            preIdex--;
                        }
                    else
                    {
                        if (Numbers.Count - i > 1)
                            Borrow10(i);
                    }
                }
                var idx = i; // Numbers.Count - i;
                Numbers[idx] = Numbers[idx] - b[i];
            }
            return this;
        }

        public ReallyBigNumber Subtraction(long b)
        {
            //convert b longo list
            var subtractionList = b.ToString().Select(number => long.Parse(number.ToString())).ToList();
            return Subtraction(subtractionList);
        }

        private bool HasMore10sToLend(int index)
        {
            var hasMore10sToLend = false;
            index = Math.Abs(index);
            for (var i = Numbers.Count - 2 - index; i >= 0; i--)
            {
                if (Numbers[i] > 0)
                    hasMore10sToLend = true;
            }
            return hasMore10sToLend;
        }

        private void Borrow10(int index)
        {
            index = Math.Abs(index);
            Numbers[Numbers.Count - index - 1] = Numbers[Numbers.Count - index - 1] + 10;
            Numbers[Numbers.Count - index - 2] = Numbers[Numbers.Count - index - 2] - 1;
        }

        public bool Equals(ReallyBigNumber a)
        {
            if (a == null)
                return false;

            if (a.Numbers == null || this.Numbers == null)
                return false;

            if (Numbers.Count != a.Numbers.Count)
                a.Numbers = AppendPaddingToList(a.Numbers);

            return !a.Numbers.Where((t, i) => t != this.Numbers[i]).Any();
        }

        private List<long> AppendPaddingToList(List<long> a)
        {
            if (Numbers.Count != a.Count)
            {
                //add padding to the smaller one
                if (Numbers.Count < a.Count)
                {
                    while (Numbers.Count < a.Count)
                    {
                        Numbers.Insert(0, 0);
                    }
                }
                else
                {
                    while (Numbers.Count > a.Count)
                    {
                        a.Insert(0, 0);
                    }
                }
            }

            return a;
        }

        public ReallyBigNumber Remainder(long b)
        {
            if (b == 0)
            {
                Numbers.Clear();
                Numbers.Add(-1);
                return this;
            }

            if (b == 1)
                return this;
            var tempB = new ReallyBigNumber(b.ToString());

            return Remainder(tempB);
        }

        public ReallyBigNumber Remainder(ReallyBigNumber b)
        {
            if (b.Numbers.Count <= 0)
            {
                Numbers.Clear();
                Numbers.Add(-1);
                return this;
            }
            DividentSummation = 0;
            while (this.IsBiggerOrEqualThan(b.Numbers))
            {
                DividentSummation++;
                this.Subtraction(b.Numbers);
            }

            return this;
        }


        public bool IsBiggerOrEqualThan(List<long> a)
        {
            if (Numbers.Count != a.Count)
            {
                a = AppendPaddingToList(a);
            }
            for (var i = 0; i < Numbers.Count - 1; i++)
            {
                if (Numbers[i] == 0 && a[i] == 0)
                {
                    Numbers.RemoveAt(i);
                    a.RemoveAt(i);
                }
                else break;
            }
            var isBigger = true;
            for (var i = Numbers.Count - 1; i >= 0; i--)
            {
                //                if (inputList[i] != 0 && Numbers[i] != 0)
                isBigger = a[i] <= Numbers[i];
            }
            return isBigger;
        }


        public bool IsSmallerOrEqualThanHalf(ReallyBigNumber b)
        {
            var isSmaller = true;

//            if (b.Numbers.Count > Numbers.Count/2 + 1)
//                return false;
            if (b.Numbers.Count != Numbers.Count)
                b.Numbers = AppendPaddingToList(b.Numbers);

            var idx = 0;
            var prevWasSmall = false;
            while (idx < Numbers.Count)
            {
                if (idx <= Numbers.Count)
                {
                    if (Numbers.Count > 0 && idx > 0)
                    {
                        if (b.Numbers[idx] + (b.Numbers[idx - 1]*10) <= Numbers[idx] + (Numbers[idx - 1]*10))
                        {
                            idx++;
                            prevWasSmall = true;
                            continue;
                        }
                        else
                        {
                            if (prevWasSmall)
                            {
                                if (Numbers.Count%2 == 0)
                                    break;
                                else
                                {
                                    if (Numbers[idx - 1] == 0)
                                    {
                                        if (b.Numbers[idx] + (b.Numbers[idx]*10) >= Numbers[idx] + 99)
                                            break;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (b.Numbers[0] <= Numbers[0])
                        {
                            idx++;
                            continue;
                        }
                    }
                    isSmaller = false;
                    break;
                }
                else
                {
                }
                if ((b.Numbers[idx] + (b.Numbers[idx]*10) >= Numbers[idx] + (Numbers[idx]*10)))
                {
                    isSmaller = false;
                    break;
                }
                else
                {
                }
                idx++;
            }
            //if (Numbers.Count % 2 == 0)
            //{
            //    for (var i = Numbers.Count / 2; i < b.Numbers.Count; i++)
            //    {
            //        if (Numbers.Count > 1)
            //        {
            //            if (b.Numbers[i] + (b.Numbers[i - 1] * 10) >= Numbers[i] + (Numbers[i - 1] * 10)) break;
            //            isSmaller = true;
            //            break;
            //        }
            //        else
            //        {
            //            isSmaller = Numbers[0] >= b.Numbers[0];
            //        }
            //    }
            //}
            //else
            //{
            //    var bValue = 0;
            //    var NValue = 0;
            //    for (var i = Numbers.Count / 2; i < b.Numbers.Count; i++)
            //    {
            //        if (b.Numbers[i] < Numbers[i])
            //        {
            //            isSmaller = true;
            //            break;
            //        }
            //        if (b.Numbers[i] != Numbers[i]) continue;
            //        bValue += b.Numbers[i] * 10;
            //        NValue += Numbers[i] * 10;

            //        if (bValue >= NValue) continue;
            //        isSmaller = true;
            //        break;
            //    }
            //}
            return isSmaller;
        }


        public ReallyBigNumber Addition(long b)
        {
            var additionList = b.ToString().Select(number => long.Parse(number.ToString())).ToList();
            return Addition(additionList);
        }

        public ReallyBigNumber Addition(List<long> b)
        {
            if (b.Count != Numbers.Count)
                b = AppendPaddingToList(b);

            for (var i = b.Count - 1; i >= 0; i--)
            {
                Numbers[i] = Numbers[i] + b[i];
                if (Numbers[i] > 9)
                {
                    Lend10(i);
                }
            }
            return this;
        }

        public void Lend10(int idx)
        {
            idx = Math.Abs(idx);
            if (idx > 0)
            {
                Numbers[idx] = Numbers[idx] - 10;
                Numbers[idx - 1] = Numbers[idx - 1] + 1;
            }
            else
            {
                Numbers.Insert(0, 1);
                Numbers[1] = Numbers[1] - 10;
            }
        }


        public ReallyBigNumber GetRandomPrime(long seed, long numberOfDigits)
        {
            var randomNumber = new ReallyBigNumber("2");
            var a = 16807; // 7^5
            var m = new ReallyBigNumber((Math.Pow(2, 32) - 1).ToString());
            var firstXn = new ReallyBigNumber(seed.ToString());
            firstXn.Multiply(a);
            firstXn.Remainder(m);
            while (!randomNumber.IsPrime(randomNumber))
            {
                randomNumber.Numbers.Clear();
                randomNumber.Numbers.Add(firstXn.Numbers[firstXn.Numbers.Count - 1]);
                for (int i = 0; i <= numberOfDigits; i++)
                {
                    var XnPluss1 = new ReallyBigNumber(randomNumber.Numbers[i].ToString());
                    XnPluss1.Multiply(a);
                    XnPluss1.Remainder(m);
                    randomNumber.Numbers.Add(XnPluss1.Numbers[XnPluss1.Numbers.Count - 1]);
                }
                randomNumber.Addition(1);
            }
            return randomNumber;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var number in Numbers)
            {
                sb.Append(number);
            }
            return sb.ToString();
        }

        public ReallyBigNumber GetGlobalCommonDenominator(ReallyBigNumber a, ReallyBigNumber b)
        {
            return b.Equals(new ReallyBigNumber("0")) ? a : GetGlobalCommonDenominator(b, a.Remainder(b));
        }


        public ReallyBigNumber Pow(long a)
        {
            if (a <= 0)
                return this;
            var returnPow = new ReallyBigNumber("0") {Numbers = Numbers.ToList()};
            for (int i = 1; i < a; i++)
            {
                returnPow = returnPow.Multiply(this);
            }
            return returnPow;
        }

        public ReallyBigNumber Pow(ReallyBigNumber a)
        {
            if (a.Numbers.Count <= 0)
                return this;
            var counter = new ReallyBigNumber("1");
            var returnPow = new ReallyBigNumber("0") {Numbers = Numbers.ToList()};
            while (a.IsBiggerOrEqualThan(counter.Numbers))
            {
                returnPow = returnPow.Multiply(this);
                counter.Addition(1);
            }
            return returnPow;
        }


        public ReallyBigNumber ModPow(ReallyBigNumber mod, ReallyBigNumber pow)
        {
            var modPow = new ReallyBigNumber("1")
            {
                Numbers = Numbers.ToList()
            };
            var counter = new ReallyBigNumber("1");
            pow.Subtraction(1);
            while (pow.IsBiggerOrEqualThan(counter.Numbers))
            {
                modPow = modPow.Multiply(this);
                modPow = modPow.Remainder(mod);
                counter.Addition(1);
            }
            return modPow;
        }
    }
}