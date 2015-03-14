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
        }

        private void CosSavebtn_Click(object sender, EventArgs e)
        {
            InstituteService.CourseServicesClient client = new InstituteService.CourseServicesClient();
            try
            {
                InstituteService.Course course = new InstituteService.Course()
                {
                    CourseId = Convert.ToInt32(txtCoursid.Text),
                    CourseDay = Daycombo.Text,
                    CourseStartTime = StTimecombo.Text,
                    CourseEndTime = EntimeCombo.Text,
                    CourseBatch = Convert.ToInt32(txtBatch.Text)
                };

                int chk = client.SaveCourse(course);
                if (chk == 1)
                {
                    MessageBox.Show("Course Saved", "Message");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void CosUpdatebtn_Click(object sender, EventArgs e)
        {
            InstituteService.CourseServicesClient client = new InstituteService.CourseServicesClient();

            InstituteService.Course course = new InstituteService.Course()
            {

            };
        }

        private void CosClearbtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void clear()
        {
            txtBatch.Clear();
            txtCoursid.Clear();
            txtCoursid.Clear();
        }

        public void getlastid()
        {

        }

    }
}
