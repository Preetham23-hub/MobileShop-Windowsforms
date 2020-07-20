using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace mobileshop
{
    public partial class nwcart : Form
    {
        public nwcart()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\mobileshop.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

        private void nwcart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mobileshopDataSet9.cart1' table. You can move, or remove it, as needed.
            this.cart1TableAdapter1.Fill(this.mobileshopDataSet9.cart1);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            con.Open();
            string query = "delete from cart1 where model='" + textBox1.Text + "'";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();

            MessageBox.Show("Removed Successfully from cart");
            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            con.Open();
            string query = "Select * from cart1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            order or = new order();
            or.Show();

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
