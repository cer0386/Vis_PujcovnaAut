using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Rezervace
    {
        public int id_rezervace { get; set; }
        public DateTime zacatekRezervace { get; set; }
        public DateTime konecRezervace { get; set; }
        public List<Auto> auta { get; set; }



        private void vystavFakturu()
        {

        }

    }
}
