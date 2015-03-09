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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void teacherSavebtn_Click(object sender, EventArgs e)
        {
            InstituteService.TeacherServicesClient client = new InstituteService.TeacherServicesClient();

            InstituteService.Teacher teacher = new InstituteService.Teacher() { 
                    TeacherId = int.Parse(teacherIdtxt.Text),
                    TeacherFName = teacherFNametxt.Text,
                    TeacherLName = teacherLNametxt.Text,
                    TeacherAddress = teacherAddresstxt.Text,
                    TeacherContact = teacherContacttxt.Text,
                    TeacherNIC = teacherNICtxt.Text,
                    TeacherMail = teacherMailtxt.Text,
                    TeacherSubject = teacherSubjectcmd.Text
            
            };

           int chk =  client.SaveTeacher(teacher);
           if (chk == 1) {
               MessageBox.Show("Teacher Saved");
           }
        }
    }
}
