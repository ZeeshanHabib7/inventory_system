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

namespace MIS_Project
{
    public partial class Main_SP : Form
    {
        public Main_SP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inventoryData i1 = new inventoryData();
            //this.Hide();
            i1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Salesinfo s1 = new Salesinfo();
            s1.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Inventory i2 = new Inventory();
            i2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SalesReport sr = new SalesReport();
            sr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            login log = new login();
            log.Show();
         }
    }
}
