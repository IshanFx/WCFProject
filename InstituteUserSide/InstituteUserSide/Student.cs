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
            GetCourseData();
            GetLastId();
        }

        string gender;
        string pic;
        string filename;
        bool IsClick=false;

        
        
        private void button4_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picloca = dlg.FileName.ToString();
                filename = picloca;
                stuImage.ImageLocation = picloca;
                pic = filename;
            }  
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                GenRadioChk();
                InstituteServices.StudentServicesClient client = new InstituteServices.StudentServicesClient();
                InstituteServices.Student student = new InstituteServices.Student()             
               {
                   stuid = Convert.ToInt32(txtstuid.Text),
                   stuCourseID = Convert.ToInt32(txtcourseid.Text),
                   stuFName = txtfname.Text,
                   stuLName = txtlname.Text,
                   stuAddr = txtadd.Text,
                   stuContact = Convert.ToInt32(txtcont.Text),
                   stuGender = gender,
                   stuPhoto=pic
               };
                int chk = client.SaveStudent(student);             
                if (chk > 0)
                {
                    MessageBox.Show("Student Saved");
                    GetLastId();
                    clear();
                }
                else
                {
                    MessageBox.Show("Student not Saved");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsClick == true)
                {
                    GenRadioChk();
                    InstituteServices.StudentServicesClient client = new InstituteServices.StudentServicesClient();
                    InstituteServices.Student student = new InstituteServices.Student();
                    new InstituteServices.Student()
                    {
                        stuid = Convert.ToInt32(txtstuid.Text),
                        stuCourseID = Convert.ToInt32(txtcourseid.Text),
                        stuFName = txtfname.Text,
                        stuLName = txtlname.Text,
                        stuAddr = txtadd.Text,
                        stuContact = Convert.ToInt32(txtcont.Text),
                        stuGender = gender
                    };
                    int chk = client.UpdateStudent(student);
                    if (chk > 0)
                    {
                        MessageBox.Show("Student Updated");
                        GetLastId();
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Student not Updates");
                    }
                }
                else
                {
                    MessageBox.Show("Search Before Update", "Message");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            
            int id=Convert.ToInt32(txtstuid.Text);
            InstituteServices.StudentServicesClient client = new InstituteServices.StudentServicesClient();
            InstituteServices.Student student = new InstituteServices.Student();

            if (id >= client.studentlastid())
            {
                MessageBox.Show("Enter Valid Student ID", "Message");
            }
            else
            {
                Savebtn.Enabled = false;
                IsClick = true;

                student = client.SearchStudentDate(Convert.ToInt32(txtstuid.Text));
                txtfname.Text = student.stuFName.ToString();
                txtlname.Text = student.stuLName.ToString();
                txtadd.Text = student.stuAddr.ToString();
                txtcont.Text = student.stuContact.ToString();
                gender = student.stuGender.ToString();
                if (gender == "F")
                {
                    radioGenF.Checked = true;
                }
                else
                {
                    radioGenM.Checked = true;
                }
            }
        }

        public void clear()
        {
            GetLastId();
            IsClick = false;
            Savebtn.Enabled = true;
            txtcourseid.Text = "";
            txtfname.Text = "";
            txtlname.Text = "";
            txtadd.Text = "";
            txtcont.Text = "";
            radioGenF.Checked = false;
            radioGenM.Checked = false;
        }

        public void GetLastId()
        {
            InstituteServices.StudentServicesClient  client=new InstituteServices.StudentServicesClient();
            txtstuid.Text=client.studentlastid().ToString();
        }

        public void GenRadioChk()
        {
            if (radioGenF.Checked == true)
            {
                gender = "F";
            }
            else
                gender = "M";
        }

        public void GetCourseData()
        {
            InstituteServices.StudentServicesClient  client=new InstituteServices.StudentServicesClient();
            DataSet set =client.GetStuCourseData();
            DataTable table = set.Tables[0];
            StuCosGrid.DataSource = table;
        }

        public void stuAllData()
        {
            InstituteServices.StudentServicesClient client = new InstituteServices.StudentServicesClient();
            DataSet set = client.GetAllStudentData();
            DataTable table = set.Tables[0];
            StuAlDataGrid.DataSource = table;
        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {
            stuAllData();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
