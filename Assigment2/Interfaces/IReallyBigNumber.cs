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
        ReallyBigNumber Multiply(ReallyBigNumber a, ReallyBigNumber b);
        ReallyBigNumber Subtraction(ReallyBigNumber a, ReallyBigNumber b);
        ReallyBigNumber Subtraction(ReallyBigNumber a, long b);
        ReallyBigNumber Modulo(ReallyBigNumber a, ReallyBigNumber b);
        ReallyBigNumber Modulo(ReallyBigNumber a, long b);
    }
}
