using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class Platba
    {
        public int id_platby { get; set; }
        public int cisloFaktury { get; set; }
        public String typ_platby { get; set; }
        public double castka { get; set; }
    }
}
