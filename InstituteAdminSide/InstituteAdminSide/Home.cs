using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InstituteAdminSide
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyChart c = new MyChart();
            c.Show();
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void timeMenuButton_Tick(object sender, EventArgs e)
        {
           
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void timerMenuButtonMin_Tick(object sender, EventArgs e)
        {
         
        }
    }
}
