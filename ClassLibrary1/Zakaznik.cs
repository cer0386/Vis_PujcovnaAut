using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class Zakaznik
    {
        public int ID { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Mesto { get; set; }
        public string Ulice { get; set; }
        public int CisloPopisne { get; set; }
        public int PSC { get; set; }
        public string Email { get; set; }
        public string cisloRidicskehoPrukazu { get; set; }

    }
}
