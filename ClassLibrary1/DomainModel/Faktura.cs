using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class Faktura
    {
        public int cisloFaktury { get; set; }
        public int cisloRezervace { get; set; }
        public DateTime vytvorena { get; set; }
        public DateTime potvrzena { get; set; }
        public DateTime zaplacena { get; set; }
    }
}
