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
    }
}
