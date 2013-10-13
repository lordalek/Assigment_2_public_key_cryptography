using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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

        public bool IsPrime(ReallyBigNumber bigNumber)
        {
            var isPrime = true;

            if (bigNumber.Numbers[bigNumber.Numbers.Count - 1]%2 == 0)
                isPrime = false;

            for (var i = 1; i < bigNumber.Numbers.Count; i++)
            {
                
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
              b =  AppendPaddingToList(b);
            for (var i = b.Count - 1; i >= 0; i--)
            {
                if (b[i] > Numbers[Numbers.Count - i - 1])
                {
                    var preIdex = 0;
                    if (Numbers[Numbers.Count - i - 1] <= 0)
                        while (Numbers[Numbers.Count - i - 1 + preIdex] <= 0 &&
                             (Numbers.Count + preIdex > 1) &&
                               HasMore10sToLend(i - preIdex))
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
                var idx = i;// Numbers.Count - i;
                Numbers[idx] = Numbers[idx] - b[i];

            }
            return this;
        }

        public ReallyBigNumber Subtraction(long b)
        {
            //convert b into list
            var subtractionList = b.ToString().Select(number => int.Parse(number.ToString())).ToList();
            if (subtractionList.Count != Numbers.Count)
                subtractionList = AppendPaddingToList(subtractionList);
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

        public ReallyBigNumber Modulo(ReallyBigNumber b)
        {
            throw new NotImplementedException();
        }

        public ReallyBigNumber Modulo(long b)
        {
            throw new NotImplementedException();
        }


        public bool Equals(ReallyBigNumber a)
        {
            if (a == null)
                return false;

            if (a.Numbers == null || this.Numbers == null)
                return false;

            if (Numbers.Count != a.Numbers.Count)
            {
                //add padding to the smaller one
                if (Numbers.Count < a.Numbers.Count)
                {
                    while (Numbers.Count < a.Numbers.Count)
                    {
                        Numbers.Insert(0, 0);
                    }
                }
                else
                {
                    while (Numbers.Count > a.Numbers.Count)
                    {
                        a.Numbers.Insert(0, 0);
                    }
                }
            }

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
            if (b.Numbers.Count <=  0)
            {
                Numbers.Clear();
                Numbers.Add(-1);
                return this;
            }

            while (this.IsBiggerOrEqualThan(b.Numbers))
            {
                this.Subtraction(b.Numbers);
            }

            return this;
        }


        public bool IsBiggerOrEqualThan(List<int> a)
        {
          
            if (Numbers.Count != a.Count)
            {
                AppendPaddingToList(a);
            }
            for (int i = 0; i < Numbers.Count-1; i++)
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
            throw new NotImplementedException();
        }
    }
}