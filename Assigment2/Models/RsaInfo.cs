using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment2.Models
{
    class RsaInfo : XmlSerializable
    {
        public ReallyBigNumber PublicKey { get; set; }
        public ReallyBigNumber PrivateKey { get; set; }
        public ReallyBigNumber Phi { get; set; }
        public ReallyBigNumber N { get; set; }
        public ReallyBigNumber PrimeQ { get; set; }
        public ReallyBigNumber PrimeP { get; set; }
    }
}
