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
    public partial class LogVyrazenychAut : Form
    {
        public LogVyrazenychAut()
        {
            InitializeComponent();
            VyrazeneAutoJ a = new VyrazeneAutoJ();

            List<VyrazeneAutoJ> listAut = new List<VyrazeneAutoJ>();
            listAut = a.nactiAuta();

            BindingSource binding = new BindingSource();
            binding.DataSource = listAut;

            dataGridView1.DataSource = binding;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
