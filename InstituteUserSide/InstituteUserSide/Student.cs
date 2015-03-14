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
                stuImage.ImageLocation = pic;
            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            InstituteServices.StudentServicesClient client = new InstituteServices.StudentServicesClient();

            InstituteServices.Student student = new InstituteServices.Student()
            {

            };
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            InstituteServices.StudentServicesClient client = new InstituteServices.StudentServicesClient();

            InstituteServices.Student student = new InstituteServices.Student()
            {

            };
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
