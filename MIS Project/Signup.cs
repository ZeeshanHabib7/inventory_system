using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MIS_Project
{
    public partial class Signup : Form
    {
        public static string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\5th Semester\MIS\Assignment 2\MIS Project\MIS Project\MIS.mdf;Integrated Security = True; Connect Timeout = 30";
        SqlConnection sqlConn = new SqlConnection(conn);
        public void connOpen()
        {
            sqlConn.Open();
        }
        public void connClose()
        {
            sqlConn.Close();
        }
        public Signup()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string queryReg = "";
            if (radioButton1.Checked == true)
            {
                queryReg = "Insert into [signup] (name, password, email, phone, job) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "', '" + radioButton1.Text + "');";
            }
            else if(radioButton2.Checked == true)
            {
                queryReg = "Insert into [signup] (name, password, email, phone, job) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "', '" + radioButton2.Text + "');";
            }
            connOpen();
            SqlCommand cmdReg = new SqlCommand(queryReg, sqlConn);
            if (cmdReg.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Registered Successfull");
                this.Close();
                //label8.Text = "Data Inserted";
            }
            else if (textBox2.Text == textBox3.Text)
            {
                label7.Text = "Confirm password success!";
            }
            else
            {
                label7.Text = "Not Confirm!";
            }
            connClose();

        }
    }
}
