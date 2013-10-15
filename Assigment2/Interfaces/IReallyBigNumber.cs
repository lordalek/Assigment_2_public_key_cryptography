using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assigment2.Models;

namespace Assigment2.Interfaces
{
    interface IReallyBigNumber
    {
        bool IsPrime(ReallyBigNumber bigNumber);
        ReallyBigNumber GenerateReallyBigNumber();
        ReallyBigNumber Multiply(long b);
        ReallyBigNumber Multiply(ReallyBigNumber b);
        ReallyBigNumber Subtraction(List<long> b);
        ReallyBigNumber Subtraction(long b);
        ReallyBigNumber Remainder(long b);
        ReallyBigNumber Remainder(ReallyBigNumber b);
        ReallyBigNumber Addition(long b);
        ReallyBigNumber Addition(List<long> b);
        ReallyBigNumber Pow(long a);
        bool Equals(ReallyBigNumber a);
        bool IsBiggerOrEqualThan(List<long> a);
        bool IsSmallerOrEqualThanHalf(ReallyBigNumber b);
        ReallyBigNumber GetRandomPrime(long seed, long numberOfDigits);
        ReallyBigNumber GetGlobalCommonDenominator(ReallyBigNumber a, ReallyBigNumber b);
        ReallyBigNumber ModPow(ReallyBigNumber mod, ReallyBigNumber pow);
        string ToString();
    }
}
