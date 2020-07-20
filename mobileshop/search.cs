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
    public partial class search : Form
    {

        
        
        SqlDataAdapter adapt;
        DataTable dt;  
        public search()
        {
            InitializeComponent();
        }
       
        private void search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mobileshopDataSet.Phones' table. You can move, or remove it, as needed.
            this.phonesTableAdapter.Fill(this.mobileshopDataSet.Phones);
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\mobileshop.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
           
            con.Open();
            adapt = new SqlDataAdapter("select * from Phones", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();  
          
        }
      



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\mobileshop.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
           
            con.Open();
            adapt = new SqlDataAdapter("select * from Phones where model like '" + textBox1.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        }
    }

