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
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congrats!!!!");
            MessageBox.Show("Your order is Successfully Placed");
            
        }

        private void order_Load(object sender, EventArgs e)
        {

        }
    }
}
