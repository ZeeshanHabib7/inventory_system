﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace MIS_Project
{
    public partial class Main_SM : Form
    {
        public Main_SM()
        {
            InitializeComponent();
            //loadgrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         //   SalesReport sr = new SalesReport();
           // sr.Show();
           
    }

        private void Main_SM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MISDataSet3.transaction' table. You can move, or remove it, as needed.
            this.transactionTableAdapter.Fill(this.MISDataSet3.transaction);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            login l1 = new login();
            l1.Show();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
