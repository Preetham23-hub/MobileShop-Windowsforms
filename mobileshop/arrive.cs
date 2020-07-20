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
    public partial class arrive : Form
    {
        public arrive()
        {
            InitializeComponent();
        }

        private void arrive_Load(object sender, EventArgs e)
        {
           
            this.new_arrivalTableAdapter.Fill(this.mobileshopDataSet6.new_arrival);

        }
    }
}
