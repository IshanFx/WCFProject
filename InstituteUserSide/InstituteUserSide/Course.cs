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
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
            TeacherGrid();
            getlastid();
            fillReport();
        }
        bool isRunning= false;

        private void CosSavebtn_Click(object sender, EventArgs e)
        {
            if (txtTechid.Text==""||
                txtCoursid.Text ==""||
                Daycombo.Text ==""||
                StTimecombo.Text ==""||
                EntimeCombo.Text ==""||
                txtBatch.Text ==""||
                txtTechid.Text =="")
            {
                MessageBox.Show("Please Fill All Filds", "Meassge",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
            }
            else
            {
                InstituteServices.CourseServicesClient client = new InstituteServices.CourseServicesClient();
                try
                {
                    InstituteServices.Course course = new InstituteServices.Course()
                     {
                         CourseId = Convert.ToInt32(txtCoursid.Text),
                         CourseDay = Daycombo.Text,
                         CourseStartTime = StTimecombo.Text,
                         CourseEndTime = EntimeCombo.Text,
                         CourseBatch = Convert.ToInt32(txtBatch.Text),
                         CourseTeacherId = Convert.ToInt32(txtTechid.Text)
                     };

                    int chk = client.SaveCourse(course);
                    if (chk == 1)
                    {
                        MessageBox.Show("Course Saved", "Message");
                        clear();
                        getlastid();
                        fillReport();
                    }
                    else
                    {
                        MessageBox.Show("Course Not Saved","Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Some Problem Of Server","Message",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                }
            }
        }

        private void CosUpdatebtn_Click(object sender, EventArgs e)
        {
            if (isRunning== false)
            {
                MessageBox.Show("Search Before Update","Message",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            } 
            else{
            if (txtTechid.Text == ""||
                txtCoursid.Text == ""||
                Daycombo.Text == ""||
                StTimecombo.Text == ""||
                EntimeCombo.Text == ""||
                txtBatch.Text == ""||
                txtTechid.Text == "")
            {
                MessageBox.Show("Please Fill All Filds", "Meassge", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {

                InstituteServices.CourseServicesClient client = new InstituteServices.CourseServicesClient();
                try
                {
                    InstituteServices.Course course = new InstituteServices.Course()
                    {
                        CourseId = Convert.ToInt32(txtCoursid.Text),
                        CourseDay = Daycombo.Text,
                        CourseStartTime = StTimecombo.Text,
                        CourseEndTime = EntimeCombo.Text,
                        CourseBatch = Convert.ToInt32(txtBatch.Text),
                        CourseTeacherId = Convert.ToInt32(txtTechid.Text)
                    };

                    int chk = client.UpdateCourse(course);
                    if (chk == 1)
                    {
                        MessageBox.Show("Course Updated", "Message");
                        clear();
                        getlastid();
                        fillReport();
                    }
                    else
                    {
                        MessageBox.Show("Course Not Saved", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            }
        }

        private void CosClearbtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void clear()
        {
            txtBatch.Clear();
            getlastid();
            txtTechid.Clear();
            StTimecombo.Text = "---Select---";
            EntimeCombo.Text = "---Select---";
            Daycombo.Text = "---Select---";
            isRunning = false;
            CosSavebtn.Enabled = true;
            
        }

        public void getlastid()
        {
            InstituteServices.CourseServicesClient client = new InstituteServices.CourseServicesClient();
            txtCoursid.Text = client.GetCourseLastId().ToString();
        }

        public void fillReport()
        {
            InstituteServices.CourseServicesClient client = new InstituteServices.CourseServicesClient();
            DataSet set = client.GetAllCourseData();
            DataTable table = set.Tables[0];
            CoursDataGrid.DataSource = table;
        }

        public void TeacherGrid()
        {
             InstituteServices.CourseServicesClient client = new InstituteServices.CourseServicesClient();

             InstituteServices.Course course = new InstituteServices.Course();
             DataSet set = client.GetCourseData();
             DataTable table = set.Tables[0];
             couTeaDetails.DataSource = table;
        }

        private void couTeaDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTechid.Text = couTeaDetails.CurrentRow.Cells[0].Value.ToString();
        }


        private void CosSearchBtn_Click(object sender, EventArgs e)
        {
            InstituteServices.CourseServicesClient client = new InstituteServices.CourseServicesClient();
            int id = Convert.ToInt32(txtCoursid.Text);
            if (id >= client.GetCourseLastId())
            {
                MessageBox.Show("Please Enter Valid Course ID", "Meassge", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            else
            {
                CosSavebtn.Enabled = false;
                
                InstituteServices.Course course = new InstituteServices.Course();
                course = client.SearchCourse(Convert.ToInt32(txtCoursid.Text));
                txtTechid.Text = course.CourseTeacherId.ToString();
                Daycombo.Text = course.CourseDay;
                StTimecombo.Text = course.CourseStartTime;
                EntimeCombo.Text = course.CourseEndTime;
                txtBatch.Text = course.CourseBatch.ToString();
                isRunning = true;
            }
        }

    }
}
