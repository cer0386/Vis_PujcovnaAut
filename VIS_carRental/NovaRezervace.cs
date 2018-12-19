using DataLayer;
using DomainLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIS_carRental
{
    public partial class NovaRezervace : Form
    {
        private DataMapper mapper;

        public NovaRezervace()
        {
            InitializeComponent();
            mapper = new DataMapper();
            List<string> typy = mapper.FindAutoTyp();
            foreach(string typ in typy)
            {
                typyAut.Items.Add(typ);
            }

            List<Zakaznik> zakazniks = new List<Zakaznik>();
            zakazniks = mapper.FindZak();
            foreach (Zakaznik zak in zakazniks)
            {
                seznamZak.Items.Add(zak.Jmeno + " " + zak.Prijmeni);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //přidání auta

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //vytvoření rezervace
            Rezervace rezervace = new Rezervace();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //přidání zakoše

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string typ = typyAut.Text;
            List<Auto> auta = mapper.FindAutaPodleTypu(typ);

            foreach(Auto auto in auta)
            {
                string text = auto.znacka + " " + auto.typ + " " +auto.SPZ;
                seznamAut.Items.Add(text);
            }
        }

        private void vyhledatZak_Click(object sender, EventArgs e)
        {
            string jmeno = jmenoText.Text;
            string prijmeni = prijmeniText.Text;
            string ridicak = ridicakText.Text;
            List<Zakaznik> zakaznici = new List<Zakaznik>();
            Zakaznik zakaznik = null;
            seznamZak.Items.Clear();

            if (ridicak == null || ridicak == "")
            {
                zakaznici = mapper.FindZak(jmeno, prijmeni);
                foreach(Zakaznik zak in zakaznici)
                {
                    seznamZak.Items.Add(zak.Jmeno + " " + zak.Prijmeni + " " + zak.cisloRidicskehoPrukazu);
                }

            }
            else
            {
                zakaznik = mapper.FindZak(ridicak);
                seznamZak.Items.Add(zakaznik.Jmeno + " " + zakaznik.Prijmeni + " " + zakaznik.cisloRidicskehoPrukazu);
            }

            if((jmeno == null || jmeno == "")&& (prijmeni == null || prijmeni == "")&& (ridicak == null || ridicak == ""))
            {
                zakaznici = mapper.FindZak();
                foreach (Zakaznik zak in zakaznici)
                {
                    seznamZak.Items.Add(zak.Jmeno + " " + zak.Prijmeni + " " + zak.cisloRidicskehoPrukazu);
                }
            }
            
            

        }

        private void pridejPocetAD_Click(object sender, EventArgs e)
        {
            string dOd = autaOd.Value.ToString("yyyy-MM-dd");
            string dDo = autaDo.Value.ToString("yyyy-MM-dd");
        }
    }
}
