using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class Auto
    {
        public String SPZ { get; set; }
        public String znacka { get; set; }
        public String typ { get; set; }
        public DateTime datumZakoupeni { get; set; }
        public DateTime STK { get; set; }
        public int pocetNehod { get; set; }
        public double cenaZaDen { get; set; }
        public bool vyrazeno { get; set; }

        public Boolean jeRezervovano()
        {
            return true;
        }
        public void vyradAuto()
        {

        }
    }
}
