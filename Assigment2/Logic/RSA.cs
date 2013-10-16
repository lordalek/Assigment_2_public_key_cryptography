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
        public ReallyBigNumber VariableE { get; set; }
        public ReallyBigNumber VariableD { get; set; }
        public ReallyBigNumber Prime1 { get; set; }
        public ReallyBigNumber Prime2 { get; set; }

        public Models.ReallyBigNumber CalculateN(Models.ReallyBigNumber q, Models.ReallyBigNumber p)
        {
            if (q == null) throw new ArgumentNullException("q");
            if (p == null) throw new ArgumentNullException("p");
            q = q.Multiply(p);
            if (q.Numbers.Count > 309)
                throw new Exception("N is larger than 2^1024 (309 decimals). Please chose smaller primes");
            N = q;
            return N;
        }

        public Models.ReallyBigNumber CaluculatePhi(ReallyBigNumber p, ReallyBigNumber q)
        {
            if (p == null) throw new ArgumentNullException("p");
            if (q == null) throw new ArgumentNullException("q");
            p = p.Subtraction(1);
            q = q.Subtraction(1);
            Phi = q.Multiply(p);
            return Phi;
        }

        public Models.ReallyBigNumber SelectERelativeToPhiAndSmallerThanPhi(Models.ReallyBigNumber phi,
            Models.ReallyBigNumber n)
        {
            if (phi == null) throw new ArgumentNullException("phi");
            if (n == null) throw new ArgumentNullException("n");
            var e = new ReallyBigNumber("3");
            while (!e.IsPrime(e) && !e.GetGlobalCommonDenominator(e, phi).Equals(new ReallyBigNumber("1")) &&
                   !n.IsBiggerOrEqualThan(e.Numbers) && new ReallyBigNumber("1").IsBigger(e.Numbers))
            {
                e.Addition(2);
            }
            VariableE = e;
            return e;
        }

        public Models.ReallyBigNumber DetermineDAs1AndSMallerThanPhi(Models.ReallyBigNumber phi,
            Models.ReallyBigNumber e)
        {
            if (phi == null) throw new ArgumentNullException("phi");
            if (e == null) throw new ArgumentNullException("e");
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
            if (n == null) throw new ArgumentNullException("n");
            if (plaintText == null) throw new ArgumentNullException("plaintText");
            if (e == null) throw new ArgumentNullException("e");
            if (new ReallyBigNumber(plaintText, true).IsBigger(n.Numbers))
                throw new Exception("Text value is greater than N.");
            var sb = new StringBuilder();
            for (var i = 0; i < plaintText.Length - 1; i += 2)
            {
                var encrpytedValues =
                    new ReallyBigNumber(plaintText[i].ToString() + plaintText[i + 1].ToString(), true);
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