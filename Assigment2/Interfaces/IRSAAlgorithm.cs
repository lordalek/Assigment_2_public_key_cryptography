﻿using System;
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
        ReallyBigNumber CaluculatePhi(ReallyBigNumber n);
        ReallyBigNumber SelectERelativeToPhiAndSmallerThanPhi(ReallyBigNumber phi);
        ReallyBigNumber DetermineDAs1AndSMallerThanPhi(ReallyBigNumber phi);
    }
}
