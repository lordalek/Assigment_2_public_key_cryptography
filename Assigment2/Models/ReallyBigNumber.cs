﻿using System;
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
        public List<int> Numbers = new List<int>();
        public long DividentSummation { get; set; }

        public bool IsPrime(ReallyBigNumber bigNumber)
        {
            var isPrime = bigNumber.Numbers[bigNumber.Numbers.Count - 1]%2 != 0;

            var idx = new ReallyBigNumber("3");
            while (IsSmallerOrEqualThanHalf(idx))
            {
                if (Remainder(idx).Numbers[Numbers.Count - 1] == 0)
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
                Numbers.Add(int.Parse(number.ToString()));
            }
        }


        public ReallyBigNumber Multiply(int b)
        {
            if (b == 0)
            {
                Numbers.Clear();
                Numbers.Add(0);
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
                //the leftmost integer is bigger than 10 causing overflow.

                overflow = 1;
                Numbers[i] = Numbers[i] - 10;
                if (i == 0)
                {
                    overflow = 0;
                    Numbers.Insert(0, 1);
                }
            }
            return this;
        }

        public ReallyBigNumber Subtraction(List<int> b)
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
            //convert b into list
            var subtractionList = b.ToString().Select(number => int.Parse(number.ToString())).ToList();
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

        private List<int> AppendPaddingToList(List<int> a)
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


        public bool IsBiggerOrEqualThan(List<int> a)
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
            var additionList = b.ToString().Select(number => int.Parse(number.ToString())).ToList();
            return Addition(additionList);
        }

        public ReallyBigNumber Addition(List<int> b)
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
                Numbers[Numbers.Count - idx] = Numbers[Numbers.Count - idx] - 10;
                Numbers[Numbers.Count - idx - 1] = Numbers[Numbers.Count - idx - 1] + 1;
            }
            else
            {
                Numbers.Insert(0, 1);
                Numbers[1] = Numbers[1] - 10;
            }
        }


        public ReallyBigNumber GetRandomNumber(long seed, int numberOfDigits)
        {
            var a = 16807; // 7^5
            var m = new ReallyBigNumber((Math.Pow(2, 32) - 1).ToString());
            var firstXn = new ReallyBigNumber(seed.ToString());
            firstXn.Multiply(a);
            firstXn.Remainder(m);
            var randomNumber = new ReallyBigNumber("1") {Numbers = firstXn.Numbers};
            for (int i = 0; i <= numberOfDigits; i++)
            {
                var XnPluss1 = new ReallyBigNumber(randomNumber.Numbers[i].ToString());
                XnPluss1.Multiply(a);
                XnPluss1.Remainder(m);
                randomNumber.Numbers.Add(XnPluss1.Numbers[XnPluss1.Numbers.Count - 1]);
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
    }
}