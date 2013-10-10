using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Assigment2.Interfaces;

namespace Assigment2.Models
{
    public class ReallyBigNumber : IReallyBigNumber
    {
        public List<int> Numbers = new List<int>();

        public bool IsPrime(ReallyBigNumber bigNumber)
        {
            if (bigNumber.Numbers[bigNumber.Numbers.Count - 1]%2 == 0)
                return false;

            return true;
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

        public ReallyBigNumber Subtraction(ReallyBigNumber b)
        {
            throw new NotImplementedException();
        }

        public ReallyBigNumber Subtraction(long b)
        {
            throw new NotImplementedException();
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

            if (a.Numbers.Count != this.Numbers.Count)
                return false;

            return !a.Numbers.Where((t, i) => t != this.Numbers[i]).Any();
        }
    }
}