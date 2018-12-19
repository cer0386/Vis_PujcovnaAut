using DataLayer;
using DomainLayer;
using DomainLayer.DomainModel;
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
        private string typ;
        private Rezervace rezervace;
        private Zakaznik zakaznik;
        private int pAut;

        
        public NovaRezervace()
        {
            InitializeComponent();
            mapper = new DataMapper();
            rezervace = new Rezervace();
            rezervace.idZakaznika = 0;
            List<string> typy = mapper.FindAutoTyp();
            foreach(string typ in typy)
            {
                typyAut.Items.Add(typ);
            }

            List<Zakaznik> zakazniks = new List<Zakaznik>();
            zakazniks = mapper.FindZak();
            foreach (Zakaznik zak in zakazniks)
            {
                seznamZak.Items.Add(zak.Jmeno + " " + zak.Prijmeni + " " + zak.cisloRidicskehoPrukazu);
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
            if (seznamAut.SelectedIndex == -1)
                MessageBox.Show("Nebylo vybráno žádné auto!");
            else
            {
                string item = seznamAut.GetItemText(seznamAut.SelectedItem);
                string[] podItem = item.Split(' ');
                string spz = podItem[2];
                Auto auto = mapper.FindAuto(spz);
                bool je = false;
                if (pAut > rezervace.auta.Count)
                {
                    foreach (Auto a in rezervace.auta)
                    {
                        if (auto.SPZ == a.SPZ)
                            je = true;
                    }
                    if (!je)
                    {
                        rezervace.auta.Add(auto);
                        rekapRez.Items.Add(auto.SPZ + " " + auto.znacka + " " + auto.typ);
                    }
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //potvrzení vytvoření rezervace
            if(rezervace.auta.Count == pAut && rezervace.idZakaznika != 0 )
            {
                mapper.SaveRez(rezervace);

                List<Rezervovano> rezervovano = new List<Rezervovano>();
                Rezervovano r = new Rezervovano();
                foreach(Auto aut in rezervace.auta)
                {
                    r.cisloRezervace = rezervace.cisloRezervace;
                    r.SPZ = aut.SPZ;
                    mapper.SaveRezervovano(r);
                }
                Faktura faktura = new Faktura();
                faktura.cisloFaktury = mapper.FindPocetFak()+1;
                faktura.cisloRezervace = rezervace.cisloRezervace;
                faktura.vytvorena = DateTime.Now;
                faktura.potvrzena = DateTime.Now;

                mapper.SaveFak(faktura);
                this.Close();
            }
            else if(rezervace.auta.Count < pAut)
            {
                MessageBox.Show("Na rezervaci není dostatečný počet Aut!");
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //přidání zakoše
            if (seznamZak.SelectedIndex == -1)
            {
                MessageBox.Show("Nebyl vybrán zákazník!");
            }
            else
            {
                string zak = seznamZak.GetItemText(seznamZak.SelectedItem);
                string[] udajeZak = zak.Split(' ');
                string ridicak = udajeZak[2];
                zakaznik = mapper.FindZak(ridicak);
                rezervace.idZakaznika = zakaznik.ID;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            typ = typyAut.Text;
            List<Auto> auta = mapper.FindAutaPodleTypu(typ);
            /*
            foreach(Auto auto in auta)
            {
                string text = auto.znacka + " " + auto.typ + " " +auto.SPZ;
                seznamAut.Items.Add(text);
            }*/
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
            rezervace.zacatekRezervace = DateTime.Parse(dOd);
            rezervace.konecRezervace = DateTime.Parse(dDo);

            List<Auto> auta = new List<Auto>();
            seznamAut.Items.Clear();
            auta = mapper.FindAuta(dOd, dDo, typ);

            foreach(Auto auto in auta)
            {
                seznamAut.Items.Add(auto.znacka + " " + auto.typ + " " + auto.SPZ);
            }

        }

        private void obnovitRekap_Click(object sender, EventArgs e)
        {
            rekapRez.Items.Clear();

            rezervace.cisloRezervace = mapper.FindPocetRez()+1;
            rekapRez.Items.Add(rezervace.cisloRezervace);
            rekapRez.Items.Add(rezervace.idZakaznika + " " +zakaznik.Jmeno +" "+zakaznik.Prijmeni);
            rekapRez.Items.Add("Začátek - "+rezervace.zacatekRezervace);
            rekapRez.Items.Add("Konec - "+rezervace.konecRezervace);

            foreach(Auto auto in rezervace.auta)
            {
                rekapRez.Items.Add(auto.SPZ + " " + auto.znacka + " "+auto.typ );
            }
            
            
            


        }

        private void buttonPocetAut_Click(object sender, EventArgs e)
        {

            if (pocetAut.Value <= 0)
                MessageBox.Show("Nelze zadat záporné číslo nebo 0!");
            if (pocetAut.Value > 20)
                MessageBox.Show("Nelze přidat více než 20 aut na rezervaci");
            else
                pAut = int.Parse( pocetAut.Text);
        }

        private void odebratItem_Click(object sender, EventArgs e)
        {
            
            if (rekapRez.SelectedIndex > 3) {
                rezervace.auta.RemoveAt((rekapRez.SelectedIndex-4));
                rekapRez.Items.Remove(rekapRez.SelectedItem);
                
            }
        }
    }
}
