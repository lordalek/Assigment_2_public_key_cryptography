using Assigment2.Models;

namespace Assigment2.Logic
{
    public class RsaInfo : XmlSerializable
    {
        public string VariableD { get; set; }
        public string VariableE { get; set; }
        public string Phi { get; set; }
        public string N { get; set; }
        public string Prime1 { get; set; }
        public string Prime2 { get; set; }
        public string PlainText{ get; set; }
        public string CipherText { get; set; }
    }
}