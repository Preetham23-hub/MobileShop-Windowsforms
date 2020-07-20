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
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }
         string cs = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\mobileshop.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

        private void button1_Click(object sender, EventArgs e)
        {
         

             if(textBox1.Text=="" || textBox2.Text=="")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from userlogin where username=@username and pass=@password",con);
                cmd.Parameters.AddWithValue("@username",textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                con.Open();
                SqlDataReader red = cmd.ExecuteReader();

                if (red.Read())
                {
                    if(red["username"].ToString() ==textBox1.Text)
                    {
                        if(red["pass"].ToString()==textBox2.Text)
                        {
                            MessageBox.Show("Login Success");
                            home ab = new home();
                            ab.Show();
                        }
                        else
                        {
                            MessageBox.Show("Password wrong ");
                        }
                    }
                    else{
                        MessageBox.Show("Wrong User Name ");
                    }
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void user_Load(object sender, EventArgs e)
        {

        }
    }
}
    

