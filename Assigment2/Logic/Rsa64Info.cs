using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assigment2.Models;

namespace Assigment2.Logic
{
    public class Rsa64Info : XmlSerializable
    {
        public string PrimeProduct { get; set; }
        public string PuK { get; set; }
        public string PrK { get; set; }
        public string Totient { get; set; }
        public string PrimeA { get; set; }
        public string PrimeB { get; set; }
        public string PlainText { get; set; }
        public string CipherText { get; set; }
    }
}