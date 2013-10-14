using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Assigment2.Interfaces;
using Assigment2.Models;

namespace Assigment2.Logic
{
    public class RSA : IRSAAlgorithm
    {
        public ReallyBigNumber N { get; set; }
        public ReallyBigNumber Phi { get; set; }
        public ReallyBigNumber E { get; set; }
        public Models.ReallyBigNumber CalculateN(Models.ReallyBigNumber q, Models.ReallyBigNumber p)
        {
            q.Multiply(p);
            if (q.Numbers.Count > 309)
                throw new Exception("N is larger than 2^1024 (309 decimals). Please chose smaller primes");
            N = q;
            return N;
        }

        public Models.ReallyBigNumber CaluculatePhi(ReallyBigNumber p, ReallyBigNumber q)
        {
            p.Subtraction(1);
            q.Subtraction(1);
            Phi = q.Multiply(p);
            return Phi;
        }

        public Models.ReallyBigNumber SelectERelativeToPhiAndSmallerThanPhi(Models.ReallyBigNumber phi, Models.ReallyBigNumber n)
        {
            var e = new ReallyBigNumber("3");
            while (e.IsPrime(e) && !e.GetGlobalCommonDenominator(e, phi).Equals(new ReallyBigNumber("1")) && !n.IsBiggerOrEqualThan(e.Numbers) && new ReallyBigNumber("1").IsBiggerOrEqualThan(e.Numbers))
            {
                e.Addition(2);
            }
            E = e;
            return e;
        }

        public Models.ReallyBigNumber DetermineDAs1AndSMallerThanPhi(Models.ReallyBigNumber phi)
        {
            throw new NotImplementedException();
        }

        public string Encrpypt(ReallyBigNumber p, ReallyBigNumber q, string plaintText, ReallyBigNumber e)
        {
            if (p == null) throw new ArgumentNullException("p");
            if (plaintText == null) throw new ArgumentNullException("plaintText");
            if (e == null) throw new ArgumentNullException("e");
            CalculateN(q, p);
            CaluculatePhi(p, q);
            return string.Empty;
        }

        public string Decrpyt(Models.ReallyBigNumber n, string cipherText, Models.ReallyBigNumber d)
        {
            throw new NotImplementedException();
        }
    }
}