using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Assigment2.Models;

namespace Assigment2.Interfaces
{
    public interface IRSAAlgorithm
    {
        ReallyBigNumber CalculateN(ReallyBigNumber q, ReallyBigNumber p);
        ReallyBigNumber CaluculatePhi(ReallyBigNumber p, ReallyBigNumber q);
        ReallyBigNumber SelectERelativeToPhiAndSmallerThanPhi(ReallyBigNumber phi, ReallyBigNumber n);
        ReallyBigNumber DetermineDAs1AndSMallerThanPhi(ReallyBigNumber phi);
        string Encrpypt(ReallyBigNumber p,ReallyBigNumber q, string plaintText, ReallyBigNumber e);
        string Decrpyt(ReallyBigNumber n, string cipherText, ReallyBigNumber d);
    }
}
