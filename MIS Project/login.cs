using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MIS_Project
{
    public partial class login : Form
    {
        public static string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\5th Semester\MIS\Assignment 2\MIS Project\MIS Project\MIS.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection sqlConn = new SqlConnection(conn);
        public void connOpen()
        {
            sqlConn.Open();
        }
        public void connClose()
        {
            sqlConn.Close();
        }
        public login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup s1 = new Signup();
            s1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connOpen();
            if (radioButton1.Checked == true)
            {
                string queryLog = "SELECT 1 FROM signup WHERE email = '" + textBox1.Text + "'and password = '" + textBox2.Text + "'and job = '" + radioButton1.Text + "' ;";
                SqlCommand cmd = new SqlCommand(queryLog, sqlConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    label3.Text = "Login Successfully";
                    Main_SP sp = new Main_SP();
                    this.Close();
                    sp.Show();

                    //                MessageBox.Show("Login Error");
                    //label3.Text = "Wrong username ,password or job title!";
                }
                else {   //                MessageBox.Show("Login Error");
                    label3.Text = "Wrong username,password or job!";
                }
            }
            else if (radioButton2.Checked == true)
            {
                string queryLog = "SELECT 1 FROM signup WHERE email = '" + textBox1.Text + "'and password = '" + textBox2.Text + "'and job = '" + radioButton2.Text + "' ;";
                SqlCommand cmd = new SqlCommand(queryLog, sqlConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    label3.Text = "Login Successfully";
                   SM_Menu sm = new SM_Menu();
                    this.Close();
                    sm.Show();
                }
                else {   //                MessageBox.Show("Login Error");
                    label3.Text = "Wrong username,password or job!";
                }
            }
            /*else
            {
                label3.Text = "Wrong username or password!,job";
            }*/
            connClose();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
