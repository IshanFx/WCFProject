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

        string gender=null;
        string filename = null;
        public void genderset()
        {
            if(sturadioF.Checked==true)
            {
                gender = "F";
            }
            else
            {
                gender = "M";
            }
        }

        private void stusavebtn_Click(object sender, EventArgs e)
        {
            genderset();
            InstituteService.StudentServicesClient client = new InstituteService.StudentServicesClient();

            InstituteService.Student student = new InstituteService.Student() { 
            
                stuid=Convert.ToInt32(txtstuid.Text),
                stuCourseID=Convert.ToInt32(txtstucourseid.Text),
                stuFName=txtfname.Text,
                stuLName=txtstulname.Text,
                stuAddr=txtstuadd.Text,
                stuContact=Convert.ToInt32(txtstucontact.Text),
                stuGender=gender,
                stuPhoto=filename
            };

            int chk = client.SaveStudent(student);
            if (chk == 1)
            {
                MessageBox.Show("Student Saved","Message");
            }
        }

        private void stuupdatebtn_Click(object sender, EventArgs e)
        {
            genderset();
            InstituteService.StudentServicesClient client = new InstituteService.StudentServicesClient();

            InstituteService.Student student = new InstituteService.Student()
            {

                stuid = Convert.ToInt32(txtstuid.Text),
                stuCourseID = Convert.ToInt32(txtstucourseid.Text),
                stuFName = txtfname.Text,
                stuLName = txtstulname.Text,
                stuAddr = txtstuadd.Text,
                stuContact = Convert.ToInt32(txtstucontact.Text),
                stuGender = gender,
                
            };

            int chk = client.SaveStudent(student);
            if (chk == 1)
            {
                MessageBox.Show("Message", "Student Updated");
            }
        }

        private void stuclearbtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void StuBrowserbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picloca = dlg.FileName.ToString();
                filename = picloca;
                stupicture.ImageLocation = picloca;             
            }   
        }

        private void stushowbtn_Click(object sender, EventArgs e)
        {

        }

        public void clear()
        {
            txtfname.Clear();
            txtstuadd.Clear();
            txtstucontact.Clear();
            txtstucourseid.Clear();
            txtstulname.Clear();
            //getlastid();
            //stupicture.Image.Dispose();
        }

        public void getlastid()
        {

        }

    }
}
