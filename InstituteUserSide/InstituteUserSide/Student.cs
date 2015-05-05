﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace InstituteUserSide
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
            GetCourseData();
            GetLastId();
            StuMrkAtnBtn.Enabled = false;
        }

        string gender;
        string pic;
        string filename;
        bool IsClick=false;
        bool IsNotPay = false;

       
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
                if(txtstuid.Text==""||
                    txtcourseid.Text==""||
                    txtfname.Text==""||
                    txtlname.Text==""||
                    txtadd.Text==""||
                    txtcont.Text==""||
                    stuImage.Image==null)
                {
                    MessageBox.Show("Fill All The Data", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
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
                    MessageBox.Show("Student Saved","Message");
                    GetLastId();
                    clear();
                }
                else
                {
                    MessageBox.Show("Student not Saved","Message",MessageBoxButtons.OK,MessageBoxIcon.Question);
                }
                
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
                    InstituteServices.Student student = new InstituteServices.Student()
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
                            MessageBox.Show("Student not Updates", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                    }
                
                else
                {
                    MessageBox.Show("Search Before Update", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                }
            
            catch (Exception ex)
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
                MessageBox.Show("Enter Valid Student ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                using (MemoryStream mStream = new MemoryStream(student.getImg))
                {
                    stuImage.Image = Image.FromStream(mStream);
                }
            }
        }

        public void clear()
        {
            GetLastId();
            IsClick = false;
            IsNotPay = false;
            Savebtn.Enabled = true;
            txtcourseid.Text = "";
            txtfname.Text = "";
            txtlname.Text = "";
            txtadd.Text = "";
            txtcont.Text = "";
            radioGenF.Checked = false;
            radioGenM.Checked = false;
            txtStuAttenCosID.Text = "";
            txtStuAttenStuID.Text = "";
            stuImage.Image = global::InstituteUserSide.Properties.Resources.propic;
            StuImagePay.Image = global::InstituteUserSide.Properties.Resources.propic;
        }

        public void GetLastId()
        {
            InstituteServices.StudentServicesClient client = new InstituteServices.StudentServicesClient();
            txtstuid.Text = client.studentlastid().ToString();
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
            DataSet set = client.GetStuCourseData();
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

        public void StuAttenReport()
        {
            InstituteServices.StudentServicesClient client = new InstituteServices.StudentServicesClient();
            DataSet set = client.GetStuAttenReport();
            DataTable table = set.Tables[0];
            StuAttenDataGrid.DataSource = table;
        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {
          
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void StuPaymentChkBtn_Click(object sender, EventArgs e)
        {
            string status;
            try
            {
                if (txtStuAttenStuID.Text == "" || txtStuAttenCosID.Text == "")
                {
                    MessageBox.Show("Enter Both ID", "Message");
                }
                else
                {
                    PaymentStuImage();
                    InstituteServices.StudentServicesClient client = new InstituteServices.StudentServicesClient();
                    status = client.stupaymentcheck(Convert.ToInt32(txtStuAttenStuID.Text), Convert.ToInt32(txtStuAttenCosID.Text));
                    if (status != null)
                    {
                        StuMrkAtnBtn.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Student Is Not Payment For This Month", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        IsNotPay = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StuMrkAtnBtn_Click(object sender, EventArgs e)
        {
            InstituteServices.StudentServicesClient client = new InstituteServices.StudentServicesClient();
            InstituteServices.Student student = new InstituteServices.Student()
            {
                stuid = Convert.ToInt32(txtStuAttenStuID.Text),
                stuCourseID = Convert.ToInt32(txtStuAttenCosID.Text)
            };
            int month =Convert.ToInt32(DateTime.Now.Date.ToString("MM"));
            int year=Convert.ToInt32(DateTime.Now.Year.ToString());
            int day =Convert.ToInt32(DateTime.Now.Date.ToString("dd"));

            int chk = client.StudentAttenSave(student, month, year, day);
            if (chk > 0)
            {
                MessageBox.Show("Student Attendance Save","Message");
                clear();
            }
            else
            {
                MessageBox.Show("Student Attendance Not Save","Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void StuPayBtn_Click(object sender, EventArgs e)
        {
            if (StuAttenMonth.Text == "" || txtStuAtenYear.Text == "" || txtstuPayFee.Text == "")
            {
                MessageBox.Show("Fill All The Filds", "Message");
            }
            else
            {
                if (txtStuAttenCosID.Text == "" || txtStuAttenStuID.Text == "")
                {
                    MessageBox.Show("Fill Student ID & Course ID", "Message");
                }
                else
                {
                    InstituteServices.StudentServicesClient client = new InstituteServices.StudentServicesClient();
                    InstituteServices.Student student = new InstituteServices.Student()
                    {
                        stuid = Convert.ToInt32(txtStuAttenStuID.Text),
                        stuCourseID = Convert.ToInt32(txtStuAttenCosID.Text)
                    };
                    string month = StuAttenMonth.Text;
                    int year = Convert.ToInt32(txtStuAtenYear.Text);
                    int amount = Convert.ToInt32(txtstuPayFee.Text);

                    int chk = client.StudentPaySave(student, month, year, amount);
                    if (chk > 0)
                    {
                        MessageBox.Show("Student Payment Save", "Message");
                        if (IsNotPay == true)
                        {
                            StuMrkAtnBtn.Enabled = true;
                            StuAttenMonth.Text = "";
                            txtStuAtenYear.Text = "";
                            txtstuPayFee.Text = "";
                        }
                        else
                        {
                            clear();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Student Attendance Not Save");
                    }
                }
            }
        }

        public void PaymentStuImage()
        {
            InstituteServices.StudentServicesClient client = new InstituteServices.StudentServicesClient();
            InstituteServices.Student student = new InstituteServices.Student();
            student = client.SearchStudentDate(Convert.ToInt32(txtStuAttenStuID.Text));
            using (MemoryStream mStream = new MemoryStream(student.getImg))
            {
                StuImagePay.Image = Image.FromStream(mStream);
            }
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            stuAllData();
        }

        private void tabPage5_Enter(object sender, EventArgs e)
        {
            StuAttenReport();
        }

        private void txtStuAttenStuID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtStuAttenCosID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtStuAtenYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtstuPayFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtcourseid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtstuid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtcont_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

    }
}
