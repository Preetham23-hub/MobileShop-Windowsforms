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
    public partial class product : Form
    {
        public product()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\mobileshop.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void product_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            con.Open();
            string query = "INSERT INTO cart1(model,price,year_of_release)values('Apple_iphone_XR','49990','2019')";
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
            string query = "INSERT INTO cart1(model,price,year_of_release)values('Oneplus_7pro','48990','2019')";
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
            string query = "INSERT INTO cart1(model,price,year_of_release)values('Samsung_Galaxy_M30','12499','2019')";
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

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO cart1(model,price,year_of_release)values('Nokia_7.2','19599','2019')";
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

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO cart1(model,price,year_of_release)values('Honor_8C','7999','2019')";
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
            string query = "INSERT INTO cart1(model,price,year_of_release)values('Realme_X4','18800','2019')";
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
            string query = "INSERT INTO cart1(model,price,year_of_release)values('Nokia_71','12490','2019')";
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

        private void button14_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO cart1(model,price,year_of_release)values('Realme_3pro','19200','2019')";
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

        private void button11_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO cart1(model,price,year_of_release)values('Samsung_Galaxy_A50','18940','2019')";
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

        private void button12_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO cart1(model,price,year_of_release)values('Motorola_moto1','10499','2019')";
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

        private void button13_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO cart1(model,price,year_of_release)values('Oppo_R17','19990','2019')";
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

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO cart1(model,price,year_of_release)values('LG_W30','8999','2019')";
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

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO cart1(model,price,year_of_release)values('Oppo_K3','16990','2019')";
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

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO cart1(model,price,year_of_release)values('Oppo_A9','15490','2019')";
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

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
