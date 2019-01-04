using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class Zamestnanec
    {
        public int ID { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Pozice { get; set; }
        public string Email { get; set; }

        public Boolean isManager()
        {
            if(Pozice == "Prodejce")
            {
                return false;
            }
            else
                return true;
        }
        public void vytvorZakaznika()
        {

        }
        public void vytvorZamestnance()
        {

        }
        public void vytvorRezervaci()
        {

        }




    }
}
