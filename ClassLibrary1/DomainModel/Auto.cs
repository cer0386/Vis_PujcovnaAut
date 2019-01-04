using System;

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


        public bool platneSTK()
        {
            if (STK < DateTime.Now)
                return false;
            else
                return true;
            
        }


    }
}
