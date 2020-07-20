using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mobileshop
{
    public partial class available : Form
    {
        public available()
        {
            InitializeComponent();
        }

        private void available_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mobileshopDataSet9.Phones' table. You can move, or remove it, as needed.
            this.phonesTableAdapter1.Fill(this.mobileshopDataSet9.Phones);
            // TODO: This line of code loads data into the 'mobileshopDataSet1.Phones' table. You can move, or remove it, as needed.
            this.phonesTableAdapter.Fill(this.mobileshopDataSet1.Phones);

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
