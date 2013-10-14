using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assigment2.Interfaces;

namespace Assigment2.Logic
{
    class RSA : IRSAAlgorithm
    {
        public Models.ReallyBigNumber CalculateN(Models.ReallyBigNumber q, Models.ReallyBigNumber p)
        {
            //q.Multiply(p.Numbers);

            return q;
        }

        public Models.ReallyBigNumber CaluculatePhi(Models.ReallyBigNumber n)
        {
            throw new NotImplementedException();
        }

        public Models.ReallyBigNumber SelectERelativeToPhiAndSmallerThanPhi(Models.ReallyBigNumber phi)
        {
            throw new NotImplementedException();
        }

        public Models.ReallyBigNumber DetermineDAs1AndSMallerThanPhi(Models.ReallyBigNumber phi)
        {
            throw new NotImplementedException();
        }

        public string Encrpypt(Models.ReallyBigNumber n, string plaintText, Models.ReallyBigNumber e)
        {
            throw new NotImplementedException();
        }

        public string Decrpyt(Models.ReallyBigNumber n, string cipherText, Models.ReallyBigNumber d)
        {
            throw new NotImplementedException();
        }
    }
}
