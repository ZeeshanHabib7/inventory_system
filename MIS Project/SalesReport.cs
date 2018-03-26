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
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
        }
        public static string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\5th Semester\MIS\Assignment 2\MIS Project\MIS Project\MIS.mdf;Integrated Security=True";

        SqlConnection con = new SqlConnection(connStr);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        private void updated_Click(object sender, EventArgs e)
        {

            SqlCommandBuilder cmdbuilder = new SqlCommandBuilder(da);
            da.Update(dt);

        }

        private void Load_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = "Select * from Sales_Pers";
            cmd = new SqlCommand(q, con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mISDataSet4.Sales_Pers' table. You can move, or remove it, as needed.
            this.sales_PersTableAdapter.Fill(this.mISDataSet4.Sales_Pers);

        }

        
    }
}
