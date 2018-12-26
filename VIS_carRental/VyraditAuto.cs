using DataLayer;
using DomainLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VIS_carRental
{
    public partial class VyraditAuto : Form
    {
        private DataMapper mapper;
        private bool stk;
        private string spz;
        private Auto autoKVyrazeni;
        string dnes;
        public VyraditAuto()
        {
            InitializeComponent();
            mapper = new DataMapper();
            dnes = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        //klik vyhledat
        private void button7_Click(object sender, EventArgs e)
        {
            stk = stkJN.Checked;
            spz = spzText.Text;
            List<Auto> auta = new List<Auto>();
            
            seznamAut.Items.Clear();
            if (spz != null && spz != "")
            {
                Auto a = new Auto();
                a = mapper.FindAuto(spz);
                seznamAut.Items.Add(a.znacka + " " + a.typ + " " + a.SPZ + " | " + a.cenaZaDen);
            }
            else if (stk)
            {
                DateTime time = DateTime.Now;
                auta = mapper.FindAuta(time);
                foreach(Auto a in auta)
                {
                    seznamAut.Items.Add(a.znacka + " " + a.typ + " " + a.SPZ + " | " + a.cenaZaDen);
                }

            }
            else
            {
                vypisVsechnyAuta();
            }
        }

        private void VyraditAuto_Load(object sender, EventArgs e)
        {
            vypisVsechnyAuta();
        }

        private void vypisVsechnyAuta()
        {
            List<Auto> auta = mapper.FindAuta();
            seznamAut.Items.Clear();

            foreach (Auto auto in auta)
            {
                seznamAut.Items.Add(auto.znacka + " " + auto.typ + " " + auto.SPZ + " | " + auto.cenaZaDen);
            }
        }

        private void seznamAut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Přidat aby to filtrovalo jen ty auta, co jsou nebo budou na rezervaci
        private void vyberAuta()
        {
            string item = seznamAut.GetItemText(seznamAut.SelectedItem);
            string[] podItem = item.Split(' ');
            string spz = podItem[2];
            autoKVyrazeni = mapper.FindAuto(spz);
        }
            
        //najít náhradní auta
        private void button1_Click(object sender, EventArgs e)
        {
            seznamNahrAut.Items.Clear();
            



            List<Auto> autaNahrazena = new List<Auto>();


            if (seznamAut.SelectedIndex == -1)
                MessageBox.Show("Nebylo vybráno žádné auto!");
            else
            {
                vyberAuta();
                //mám auto co chci vyřadit
                //zjistit jestli je nebo bude na rezerevaci
                //když ne, tak vyřadit

                //když jo, tak vyhodit hlášku
                string dnes1 = DateTime.Now.AddYears(1).ToString("yyyy-MM-dd");
                autaNahrazena = mapper.FindDostupneAuta(dnes, dnes1, autoKVyrazeni.cenaZaDen);

                foreach (Auto a in autaNahrazena)
                {
                    seznamNahrAut.Items.Add(a.znacka + " " + a.typ + " " + a.SPZ +" | "+a.cenaZaDen);
                }
            }


        }
        //vyřadit
        private void button1_Click_1(object sender, EventArgs e)
        {
            vyberAuta();
            if (autoKVyrazeni == null)
            {
                MessageBox.Show("Vyber Auto!");
            }
            else if (mapper.FindPocetAktualniRez(autoKVyrazeni.SPZ, dnes)>0)
            {
                MessageBox.Show("Auto je na rezervaci");
            }
            else
            {
                //možme vyřadit
                int status = mapper.UpdateAutoVyrad(autoKVyrazeni);
                if(status == -1 || status == 0)
                {
                    MessageBox.Show("Došlo k chybě");
                }
                else
                {
                    MessageBox.Show("Úspěšně vyřazeno");
                    vypisVsechnyAuta();
                }
                
                
            }

        }

        private void nahradit_Click(object sender, EventArgs e)
        {
            //nahradit auto na rezervaci

        }
    }
}
