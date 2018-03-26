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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
         //   loadgrid();
        }
        public static string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\5th Semester\MIS\Assignment 2\MIS Project\MIS Project\MIS.mdf;Integrated Security = True; Connect Timeout = 30";
        SqlConnection con = new SqlConnection(connStr);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        private void Inventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mISDataSet.inventory' table. You can move, or remove it, as needed.
         //   this.inventoryTableAdapter.Fill(this.mISDataSet.inventory);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.inventoryTableAdapter.Fill(this.mISDataSet.inventory);

        }

        private void butn_Inserted_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = "select * from inventory";
            cmd = new SqlCommand(q, con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


        }

        private void but_update_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cmdbuilder = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Updated...");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
