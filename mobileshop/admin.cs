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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
         string cs = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\mobileshop.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
              if(text1.Text=="" || text2.Text=="")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from adminlogin where username=@username and pass=@password",con);
                cmd.Parameters.AddWithValue("@username",text1.Text);
                cmd.Parameters.AddWithValue("@password", text2.Text);
                con.Open();
                SqlDataReader red = cmd.ExecuteReader();

                if (red.Read())
                {
                    if(red["username"].ToString() ==text1.Text)
                    {
                        if(red["pass"].ToString()==text2.Text)
                        {
                            MessageBox.Show("Login Success");
                           adminhome ab = new adminhome();
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
            text1.Text = "";
            text2.Text = "";
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        }
    }

