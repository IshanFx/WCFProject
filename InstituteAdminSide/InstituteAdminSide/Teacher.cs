using System;
using System.Data;
using System.Windows.Forms;
using InstituteAdminSide.InstituteService;

namespace InstituteAdminSide
{
    public partial class Teacher : Form
    {
        private TeacherServicesClient client;
        private InstituteService.Teacher teacher;
        private DataSet set;
        private DataTable table;
        private CustomFormControl formControl = new CustomFormControl();
        public Teacher()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void teacherSavebtn_Click(object sender, EventArgs e)
        {
            client = new TeacherServicesClient();
            int chk = 0;

            //check TextFields Values
            if (String.IsNullOrEmpty(teacherIdtxt.Text)||
                String.IsNullOrEmpty(teacherFNametxt.Text)||
                String.IsNullOrEmpty(teacherLNametxt.Text)||
                String.IsNullOrEmpty(teacherAddresstxt.Text)||
                String.IsNullOrEmpty(teacherSubjectcmd.Text)||
                String.IsNullOrEmpty(teacherNICtxt.Text)
                 )
            {
                MessageBox.Show(String.Format("Please Fill The Form"));
            }
            else if(!teacherNICtxt.TextLength.Equals(9))
            {
                MessageBox.Show("NIC Number Should be 9 Numbers");
            }
            else
            {
                string NICType = "V";
                if (rbnNICX.Checked)
                {
                    NICType = "X";
                }
                             try
                            {
                                 //pass values to service
                                teacher = new InstituteService.Teacher()
                                {
                                    TeacherId = int.Parse(teacherIdtxt.Text),
                                    TeacherFName = teacherFNametxt.Text,
                                    TeacherLName = teacherLNametxt.Text,
                                    TeacherAddress = teacherAddresstxt.Text,
                                    TeacherContact = teacherContacttxt.Text,
                                    TeacherNIC = teacherNICtxt.Text + NICType,
                                    TeacherMail = teacherMailtxt.Text,
                                    TeacherSubject = teacherSubjectcmd.Text

                                };

                                chk = client.SaveTeacher(teacher);
                                if (chk == 1)
                                {
                                    MessageBox.Show(string.Format("Teacher id {0} saved", teacherIdtxt.Text),"Teacher Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show(string.Format("Teacher id {0} Not Saved", teacherIdtxt.Text), "Teacher Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            catch (Exception exception)
                            {
                                MessageBox.Show(exception.Message,"Teacher Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
            }
            ClearFields();
            GetTeacherLastId();
        }

        private void updateTeacher(object sender, EventArgs e)
        {
            client = new TeacherServicesClient();
            int chk = 0;

            //check textfields values
           if (String.IsNullOrEmpty(teacherIdtxt.Text)||
                String.IsNullOrEmpty(teacherFNametxt.Text)||
                String.IsNullOrEmpty(teacherLNametxt.Text)||
                String.IsNullOrEmpty(teacherAddresstxt.Text)||
                String.IsNullOrEmpty(teacherSubjectcmd.Text)||
                String.IsNullOrEmpty(teacherNICtxt.Text)
                 )
            {
                MessageBox.Show(String.Format("Please Fill The Form"));
            }
            else if (!teacherNICtxt.TextLength.Equals(9))
            {
                MessageBox.Show("NIC Number Should be 9 Numbers");
            }
            else
            {
                string NICType = "V";
                if (rbnNICX.Checked)
                {
                    NICType = "X";
                }
                try
                {
                    //pass values to service
                    teacher = new InstituteService.Teacher()
                    {
                        TeacherId = int.Parse(teacherIdtxt.Text),
                        TeacherFName = teacherFNametxt.Text,
                        TeacherLName = teacherLNametxt.Text,
                        TeacherAddress = teacherAddresstxt.Text,
                        TeacherContact = teacherContacttxt.Text,
                        TeacherNIC = teacherNICtxt.Text+NICType,
                        TeacherMail = teacherMailtxt.Text,
                        TeacherSubject = teacherSubjectcmd.Text

                    };
                    chk = client.UpdateTeacher(teacher);
                    if (chk.Equals(1))
                    {
                        MessageBox.Show(String.Format("Teacher Id {0} Updated Success", teacherIdtxt.Text),
                            "Teacher Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(String.Format("Teacehr id {0} Not Updated", teacherIdtxt.Text),
                            "Teacher Message", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error Occure", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void clearFields(object sender, EventArgs e)
        {
            ClearFields();
            btnTeacherSave.Enabled = true;
        }

        //clear fields 
        private void ClearFields()
        {
            teacherAddresstxt.Clear();
            teacherContacttxt.Clear();
            teacherFNametxt.Clear();
            teacherLNametxt.Clear();
            teacherMailtxt.Clear();
            teacherNICtxt.Clear();
            
        }

        //get last saved id of teachers
        private void GetTeacherLastId()
        {
            
            client = new TeacherServicesClient();
            txtLastId.Text= client.GetTeacherLastId().ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(teacherIdtxt.Text))
            {
                MessageBox.Show("Please Enter TeacherId", "Enter Id", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                try
                {
                    //retrieve teachers data from service

                    client = new TeacherServicesClient();
                    set = client.GetTeacherData();
                    table = set.Tables[0];
                    teacherFNametxt.Text = table.Rows[0][1].ToString();
                    teacherLNametxt.Text = table.Rows[0][2].ToString();
                    teacherNICtxt.Text = table.Rows[0][3].ToString();
                    teacherContacttxt.Text = table.Rows[0][4].ToString();
                    teacherAddresstxt.Text = table.Rows[0][5].ToString();
                    teacherMailtxt.Text = table.Rows[0][6].ToString();
                    teacherSubjectcmd.Text = table.Rows[0][7].ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Can't get Data","Error" ,MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                
             }
            btnTeacherSave.Enabled = false;
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            GetTeacherLastId();
            FillGridTeacher();
        }

        private void FillGridTeacher()
        {
            client = new TeacherServicesClient();
            DataSet set = client.GetTeacherData();
            DataTable table = set.Tables[0];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                ListViewItem listView = new ListViewItem(table.Rows[i][0].ToString());
                listView.SubItems.Add(table.Rows[i][1] + " " + table.Rows[i][2]);
                listView.SubItems.Add(table.Rows[i][3].ToString());
                listView.SubItems.Add(table.Rows[i][4].ToString());
                listView.SubItems.Add(table.Rows[i][5].ToString());
                listView.SubItems.Add(table.Rows[i][6].ToString());
                listView.SubItems.Add(table.Rows[i][7].ToString());
                listTeacherData.Items.Add(listView);
            }
           
        }

        private void employeePaymentSave(object sender, EventArgs e)
        {
            client = new TeacherServicesClient();
            if (String.IsNullOrEmpty(txtPaymentTeaId.Text) ||
                String.IsNullOrEmpty(txtPaymentMonth.Text) ||
                String.IsNullOrEmpty(txtPaymentAmount.Text)||
                String.IsNullOrEmpty(txtPaymentYear.Text)
                )

            {
                MessageBox.Show("Please Fill all Data", "Fill Require", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                try
                {
                    teacher = new InstituteService.Teacher()
                    {
                        TeacherId = int.Parse(txtPaymentTeaId.Text),
                        TeacherPayDate = DateTime.Now.ToString("yyyy/MM/dd"),
                        TeacherPayMonth = txtPaymentMonth.Text,
                        TeacherPayYear = int.Parse(txtPaymentYear.Text),
                        TeacherPayAmount = Double.Parse(txtPaymentAmount.Text)
                    };

                    int chk = client.SaveTeacherPayment(teacher);
                    if (chk.Equals(1))
                    {
                        MessageBox.Show(String.Format("Teacher id {0} Payments Saved ",txtPaymentTeaId.Text),"Save Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(String.Format("Teacher id {0} payment not saved", txtPaymentTeaId.Text),
                            "Teacher Message", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show(@"Can't Save Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            
        }

        private void label18_Click(object sender, EventArgs e)
        {
            formControl.FormLoad(new Home(), this);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            formControl.FormLoad(new Employee() , this);
        }

        private void label16_Click(object sender, EventArgs e)
        {
            formControl.FormLoad(new Email(), this);
        }

        private void label17_Click(object sender, EventArgs e)
        {
            formControl.FormLoad(new Reports(), this);
        }
    }
}
