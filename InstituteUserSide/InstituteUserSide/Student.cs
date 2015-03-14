using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InstituteUserSide
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog()==DialogResult.OK){
                string pic = open.FileName.ToString();
                pictureBox1.ImageLocation = pic;
            }
        }
    }
}
