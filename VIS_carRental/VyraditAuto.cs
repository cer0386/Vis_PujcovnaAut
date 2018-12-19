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
        public VyraditAuto()
        {
            InitializeComponent();
            mapper = new DataMapper();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void VyraditAuto_Load(object sender, EventArgs e)
        {
            List<Auto> auta = mapper.FindAuta();
        }

        private void seznamAut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
