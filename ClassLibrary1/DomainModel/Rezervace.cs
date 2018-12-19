using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class Rezervace
    {

        public int cisloRezervace { get; set; }
        public int idZakaznika { get; set; }
        public DateTime zacatekRezervace { get; set; }
        public DateTime konecRezervace { get; set; }
        public List<Auto> auta { get; set; }


        public Rezervace()
        {
            auta = new List<Auto>();
        }

        private void vystavFakturu()
        {

        }

    }
}
