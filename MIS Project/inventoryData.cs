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
    public partial class inventoryData : Form
    {
        public inventoryData()
        {
            InitializeComponent();
        }
        public static string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\5th Semester\MIS\Assignment 2\MIS Project\MIS Project\MIS.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con = new SqlConnection(connStr);

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void but_insert_Click(object sender, EventArgs e)
        {
            //string conStr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = H:\Assignment 2\MIS Project\MIS Project\MIS.mdf; Integrated Security = True";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            string qurey = "Insert into inventory (Product_Id, Product_name,InventoryQTY,Unit_Price,Date_In,Date_out) values ('"+textBox_id.Text+"','"+textBox_Name.Text+"','"+textBox_Qty.Text+"','"+textBox_Price.Text+"','"+dateTimePicker_in.Text+"','"+dateTimePicker_out.Text+"')";
            cmd.CommandText = qurey;
            cmd.Connection = con;
            if (cmd.ExecuteNonQuery() >0)
            {
                MessageBox.Show("DataInserted");
            }
            //Inventory id = new Inventory();
            //id.Show();
            con.Close();
            this.Close();
            //Inventory id = new Inventory();
            //id.Show();
        }

        private void inventoryData_Load(object sender, EventArgs e)
        {

        }
    }
}
