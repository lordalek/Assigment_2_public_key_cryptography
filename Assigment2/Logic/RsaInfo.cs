using Assigment2.Models;

namespace Assigment2.Logic
{
    public class RsaInfo : XmlSerializable
    {
        public ReallyBigNumber VariableD { get; set; }
        public ReallyBigNumber VariableE { get; set; }
        public ReallyBigNumber Phi { get; set; }
        public ReallyBigNumber N { get; set; }
        public ReallyBigNumber Prime1 { get; set; }
        public ReallyBigNumber Prime2 { get; set; }
    }
}