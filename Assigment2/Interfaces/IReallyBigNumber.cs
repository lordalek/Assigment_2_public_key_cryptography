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
        ReallyBigNumber Multiply(int b);
        ReallyBigNumber Subtraction(List<int> b);
        ReallyBigNumber Subtraction(long b);
        ReallyBigNumber Remainder(long b);
        ReallyBigNumber Remainder(ReallyBigNumber b);
        ReallyBigNumber Addition(long b);
        ReallyBigNumber Addition(List<int> b);
        bool Equals(ReallyBigNumber a);
        bool IsBiggerOrEqualThan(List<int> a);
        bool IsSmallerOrEqualThanHalf(ReallyBigNumber b);
    }
}
