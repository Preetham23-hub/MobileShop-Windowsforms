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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\mobileshop.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");


        private void button3_Click(object sender, EventArgs e)
        {
            nwcart nw = new nwcart();
            nw.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search sc = new search();
            sc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            available ab = new available();
            ab.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            arrive ar = new arrive();
            ar.Show();

           
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO cart1(model,price,year_of_release)values('Apple_iphone_11','109900','2019')";
            SqlCommand com = new SqlCommand(query, con);
            //SqlDataAdapter sda = new SqlDataAdapter(query,con);
            //sda.SelectCommand.ExecuteNonQuery();
            int r = com.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("added to cart");
            }
            else
            {
                MessageBox.Show("Sorry try again");
            }
            con.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO cart1(model,price,year_of_release)values('Nokia 8.1','15999','2019')";
            SqlCommand com = new SqlCommand(query, con);
            //SqlDataAdapter sda = new SqlDataAdapter(query,con);
            //sda.SelectCommand.ExecuteNonQuery();
            int r = com.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("added to cart");
            }
            else
            {
                MessageBox.Show("Sorry try again");
            }
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO cart1(model,price,year_of_release)values('Samsung_Galaxy_s10','117900','2019')";
            SqlCommand com = new SqlCommand(query, con);
            //SqlDataAdapter sda = new SqlDataAdapter(query,con);
            //sda.SelectCommand.ExecuteNonQuery();
            int r = com.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("added to cart");
            }
            else
            {
                MessageBox.Show("Sorry try again");
            }
            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO cart1(model,price,year_of_release)values('Oppo_k3','16990','2018')";
            SqlCommand com = new SqlCommand(query, con);
            //SqlDataAdapter sda = new SqlDataAdapter(query,con);
            //sda.SelectCommand.ExecuteNonQuery();
            int r = com.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("added to cart");
            }
            else
            {
                MessageBox.Show("Sorry try again");
            }
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO cart1(model,price,year_of_release)values('Realme_u1','9999','2019')";
            SqlCommand com = new SqlCommand(query, con);
            //SqlDataAdapter sda = new SqlDataAdapter(query,con);
            //sda.SelectCommand.ExecuteNonQuery();
            int r = com.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("added to cart");
            }
            else
            {
                MessageBox.Show("Sorry try again");
            }
            con.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO cart1(model,price,year_of_release)values('Nokia_6.1_plus','10900','2019')";
            SqlCommand com = new SqlCommand(query, con);
            //SqlDataAdapter sda = new SqlDataAdapter(query,con);
            //sda.SelectCommand.ExecuteNonQuery();
            int r = com.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("added to cart");
            }
            else
            {
                MessageBox.Show("Sorry try again");
            }
            con.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            product p = new product();
            p.Show();
        }

      
    }
}
