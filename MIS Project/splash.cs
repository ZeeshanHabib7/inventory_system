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
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Width += 5;
            if(pictureBox2.Width >= 266)
            {
                
                timer1.Stop();
                login l1 = new login();
                l1.Show();
                this.Hide();
            }
        }
        
    }
}
