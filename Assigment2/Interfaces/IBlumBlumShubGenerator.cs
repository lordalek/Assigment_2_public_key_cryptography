using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assigment2.Models;

namespace Assigment2.Interfaces
{
    interface IBlumBlumShubGenerator
    {
        ReallyBigNumber GeneratePseudoRandomNumber(long seed);
    }
}
