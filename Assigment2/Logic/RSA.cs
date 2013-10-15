using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public Models.ReallyBigNumber SelectERelativeToPhiAndSmallerThanPhi(Models.ReallyBigNumber phi,
            Models.ReallyBigNumber n)
        {
            var e = new ReallyBigNumber("3");
            while (e.IsPrime(e) && !e.GetGlobalCommonDenominator(e, phi).Equals(new ReallyBigNumber("1")) &&
                   !n.IsBiggerOrEqualThan(e.Numbers) && new ReallyBigNumber("1").IsBiggerOrEqualThan(e.Numbers))
            {
                e.Addition(2);
            }
            E = e;
            return e;
        }

        public Models.ReallyBigNumber DetermineDAs1AndSMallerThanPhi(Models.ReallyBigNumber phi,
            Models.ReallyBigNumber e)
        {
            var d = new ReallyBigNumber("2");
            var isOK = false;
            while (!isOK)
            {
                var tempD = new ReallyBigNumber("1")
                {
                    Numbers = d.Numbers
                };
                tempD = tempD.Multiply(e);
                tempD = tempD.Remainder(phi);
                if (tempD.Equals(new ReallyBigNumber("1")))
                {
                    isOK = true;
                }
                else
                {
                    d.Addition(1);
                }
            }
            return d;
        }

        public string Encrpypt(ReallyBigNumber n, string plaintText, ReallyBigNumber e)
        {
            if (plaintText == null) throw new ArgumentNullException("plaintText");
            if (e == null) throw new ArgumentNullException("e");
            if (plaintText.Length >= n.Numbers.Count)
                throw new Exception("Text length is greater than N");
            var sb = new StringBuilder();
            for (int i = 0; i < plaintText.Length - 1; i += 2)
            {
                var encrpytedValues =
                    new ReallyBigNumber(Encoding.UTF8.GetBytes(plaintText[i].ToString())[0].ToString() +
                                        Encoding.UTF8.GetBytes(plaintText[i + 1].ToString())[0].ToString());
                encrpytedValues = encrpytedValues.ModPow(n, e);
                sb.Append(encrpytedValues.ToString());
            }
            return sb.ToString();
        }

        public string Decrpyt(Models.ReallyBigNumber n, string cipherText, Models.ReallyBigNumber d)
        {
            throw new NotImplementedException();
        }
    }
}