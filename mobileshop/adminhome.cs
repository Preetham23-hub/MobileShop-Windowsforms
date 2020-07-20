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
    public partial class adminhome : Form
    {
        public adminhome()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\mobileshop.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\mobileshop.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            con.Open();
            try
            {
                string str = " INSERT INTO Phones(phone_id,model,ram,istroge,estroge,display,rearc,frontc,finger,sim,network,price) VALUES('"+textBox3.Text+"','" + textBox1.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + comboBox5.Text + "','" + comboBox6.Text + "','" + comboBox7.Text + "','" + comboBox8.Text + "','" + comboBox9.Text + "','" + textBox2.Text + "'); ";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "select max(phone_id) from Phones;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("" + textBox1.Text + "'s Details is Inserted Successfully.. " + textBox1.Text + "'s Id is " + dr.GetInt32(0) + ".", "Important Message");
                    this.Hide();

                }
                this.Close();
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "--Select--";
            comboBox2.Text = "--Select--";
            comboBox3.Text = "--Select--";
            comboBox4.Text = "--Select--";
            comboBox5.Text = "--Select--";
            comboBox6.Text = "--Select--";
            comboBox7.Text = "--Select--";
            comboBox8.Text = "--Select--";
            comboBox9.Text = "--Select--";
        }

        private void adminhome_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            con.Open();
            string query = "delete from Phones where phone_id='" + textBox3.Text + "'";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();

            MessageBox.Show("Phone is Successfully removed!!!!!");
            con.Close();
        }
    }
}
