using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Faktura
    {
        public int id_faktury { get; set; }
        public DateTime vytvorena { get; set; }
        public DateTime potvrzena { get; set; }
        public DateTime zaplacena { get; set; }
    }
}
