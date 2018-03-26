using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;

namespace MIS_Project
{
    public partial class Salesinfo : Form
    {
        public Salesinfo()
        {
            InitializeComponent();
            //loadgrid();
        }
        public static string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\5th Semester\MIS\Assignment 2\MIS Project\MIS Project\MIS.mdf;Integrated Security=True";
        SqlConnection con = new SqlConnection(connStr);
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Salesinfo_Load(object sender, EventArgs e)
        {
            

        }

        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void but_insert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
        //   string queryLog = "SELECT 1 FROM signup WHERE email = '" + textBox_id.Text + "'and Name = '" + textBox_name.Text + "' ;";
            string qurey = "Insert into Sales_Pers(SP_qty,SP_Date,SP_area,SP_Name) values ('" + textBox_qty.Text + "','" + dateTimePicker1.Text+ "','" + textBox_area.Text+ "','" + textBox_name.Text + "') ";
            cmd.CommandText = qurey;
            cmd.Connection = con;
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("DataInserted");
            }
            //Inventory id = new Inventory();
            //id.Show();
            con.Close();
            this.Close();
            SalesReport sr = new SalesReport();
                sr.Show();
            this.Close();
        }
    }
}
