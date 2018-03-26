using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS_Project
{
    public partial class SM_Menu : Form
    {
        public SM_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main_SM m1 = new Main_SM();
            this.Close();
            m1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
