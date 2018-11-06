using ClassLibrary1;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data_load();
        }

        private void data_load()
        {
            List<Zamestnanec> lstStaff = new List<Zamestnanec>();

            lstStaff.Add(new Zamestnanec()
            {
                ID = 1,
                Jmeno = "Jura"
            
            });
            lstStaff.Add(new Zamestnanec()
            {
                ID = 2,
                Jmeno = "Lukas"
            });
            lstStaff.Add(new Zamestnanec()
            {
                ID = 3,
                Jmeno = "Ujko"
            });

            BindingSource b = new BindingSource();
            b.DataSource = lstStaff;

            //prirazeni nabindovanych dat do datagridu
            dataGridView1.DataSource = b;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
 