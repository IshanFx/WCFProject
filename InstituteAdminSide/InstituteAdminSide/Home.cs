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
            timeMenuButton.Enabled = true;
            timeMenuButton.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void timeMenuButton_Tick(object sender, EventArgs e)
        {
            if (button5.Width <= 315 && button5.Height <= 315)
            {
                button5.Height += 2;
                button5.Width += 2;
            }
            else
                timeMenuButton.Stop();
                timeMenuButton.Enabled = false;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            timeMenuButton.Enabled = true;
            timerMenuButtonMin.Start();
        }

        private void timerMenuButtonMin_Tick(object sender, EventArgs e)
        {
            if (button5.Width >= 303 && button5.Height >= 303)
            {
                button5.Height -= 2;
                button5.Width -= 2;
            }
            else
                timeMenuButton.Stop();
        }
    }
}
