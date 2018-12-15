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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            DataMapper mapper = new DataMapper();
            List<Zakaznik> zakazniks = new List<Zakaznik>();
            zakazniks = mapper.FindZak();
            foreach(Zakaznik zak in zakazniks)
            {
                listZaks.Items.Add(zak.Jmeno + " " + zak.Prijmeni);
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //nová rezervace
            NovaRezervace novaRezervace = new NovaRezervace();
            novaRezervace.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //vyhledat rezervace
            string j = jmeno.Text;
            string p = prijmeni.Text;
            string rid = ridicak.Text;
            string t = typ.Text;
            string z = znacka.Text;
            string s = spz.Text;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //vyřazení auta
            VyraditAuto vyraditAuto = new VyraditAuto();
            vyraditAuto.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string zak = listZaks.SelectedItem.ToString();
            string[] jp = zak.Split(' ');
            string jmeno = jp[0];
            string prijmeni = jp[1];

            DataMapper mapper = new DataMapper();
            Zakaznik zakaznik = mapper.FindZak(jmeno, prijmeni);


            List<Rezervace> rezervaces = new List<Rezervace>();
            rezervaces = mapper.FindRezZ(zakaznik.ID);

            BindingSource binding = new BindingSource();
            binding.DataSource = rezervaces;

            zakInfoR.DataSource = binding;

            /*foreach(PropertyDescriptor descriptor in TypeDescriptor.GetProperties(zakaznik))
            {
                object value = descriptor.GetValue(zakaznik);
                infoOZak.Items.Add(value);
            }*/
            infoOZak.Items.Clear();
            infoOZak.Items.Add("ID zákazníka - " + zakaznik.ID);
            infoOZak.Items.Add("Jméno a Příjmení - " + zakaznik.Jmeno + " " + zakaznik.Prijmeni);
            infoOZak.Items.Add("Adresa - " + zakaznik.Mesto + " " + zakaznik.Ulice + " " + zakaznik.CisloPopisne);
            infoOZak.Items.Add("PSČ - " + zakaznik.PSC);
            infoOZak.Items.Add("Email - " + zakaznik.Email);
            infoOZak.Items.Add("Číslo řidičského průkazu - " + zakaznik.cisloRidicskehoPrukazu);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button12_Click(object sender, EventArgs e)
        {
            //vyhledat zakoše
            string jmeno = jmenoText.Text;
            string prijmeni = prijmeniText.Text;
            string ridicak = ridicakText.Text;

            DataMapper mapper = new DataMapper();
            Zakaznik zakaznik = mapper.FindZak(jmeno, prijmeni);


            List<Rezervace> rezervaces = new List<Rezervace>();
            rezervaces = mapper.FindRezZ(zakaznik.ID);

            BindingSource binding = new BindingSource();
            binding.DataSource = rezervaces;

            zakInfoR.DataSource = binding;

            /*foreach(PropertyDescriptor descriptor in TypeDescriptor.GetProperties(zakaznik))
            {
                object value = descriptor.GetValue(zakaznik);
                infoOZak.Items.Add(value);
            }*/
            infoOZak.Items.Clear();
            infoOZak.Items.Add("ID zákazníka - "+ zakaznik.ID);
            infoOZak.Items.Add("Jméno a Příjmení - "+ zakaznik.Jmeno +" " +zakaznik.Prijmeni);
            infoOZak.Items.Add("Adresa - " + zakaznik.Mesto + " "+zakaznik.Ulice+" "+zakaznik.CisloPopisne);
            infoOZak.Items.Add("PSČ - " + zakaznik.PSC);
            infoOZak.Items.Add("Email - " + zakaznik.Email);
            infoOZak.Items.Add("Číslo řidičského průkazu - " + zakaznik.cisloRidicskehoPrukazu);

            /*zakInfoR.Rows.Add("Číslo rezervace", "Od", "Do");
            foreach( Rezervace rezervace in rezervaces)
            {
                zakInfoR.Rows.Add(rezervace.cisloRezervace, rezervace.zacatekRezervace, rezervace.konecRezervace);
            }*/

        }

        private void ZakInfoR_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.zakInfoR.Rows[e.RowIndex];
                int cisloR = Int32.Parse(row.Cells["cisloRezervace"].Value.ToString());

                DataMapper mapper = new DataMapper();
                List<Auto> auta = new List<Auto>();

                auta = mapper.FindAutaOnRez(cisloR);

                BindingSource binding = new BindingSource();
                binding.DataSource = auta;

                autaNaRez.DataSource = binding;
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
