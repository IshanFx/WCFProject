using System;
using System.Collections;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using InstituteAdminSide.InstituteService;

namespace InstituteAdminSide
{
    public partial class Reports : Form
    {
        private TeacherServicesClient teacherServices;
        private EmployeeServicesClient employeeServices;
        private DataSet dataSet;
        private DataTable table;
        private ListViewItem listView;
        private Hashtable hashtableTotal = new Hashtable();
        public Reports()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }
        private void button6_Click(object sender, EventArgs e)
        {
           

        }
        private void TeacherAllPay_Rbn(object sender, EventArgs e)
        {
            try
            {
                if (rbnTeacherAllPay.Checked)
                {
                    teacherServices = new TeacherServicesClient();
                    dataSet = teacherServices.GetTeacherAllPaymentReport();
                    table = dataSet.Tables[0];
                    ClearListView(listTeacherPayment);
                    FillListView(table, listTeacherPayment);


                }
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void FillListView(DataTable table,ListView listViewName)
        {
            
            for (int i = 0; i < table.Rows.Count; i++)
            {
                listView = new ListViewItem(table.Rows[i][0].ToString());
                listView.SubItems.Add(table.Rows[i][1] + " " + table.Rows[i][2]);
                listView.SubItems.Add(table.Rows[i][3].ToString());
                listView.SubItems.Add(table.Rows[i][4].ToString());
                listView.SubItems.Add(table.Rows[i][5].ToString());
                listView.SubItems.Add(table.Rows[i][6].ToString());
                listViewName.Items.Add(listView);
            }
        }

        private void TeacherSearchPay_Rbn(object sender, EventArgs e)
        {

           
        }

        private void EmployeeAllPay_Rbn(object sender, EventArgs e)
        {
            try
            {
                if (rbnEmployeeAllPay.Checked)
                {

                    employeeServices = new EmployeeServicesClient();
                    dataSet = employeeServices.GetEmployeeAllPaymentReport();
                    table = dataSet.Tables[0];
                    ClearListView(listEmployeepayment);
                    FillListView(table, listEmployeepayment);
                }
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }

        private void ClearListView(ListView listView)
        {
            listView.Items.Clear();
        }

       

        private void txtTeacherYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (String.IsNullOrEmpty(cmbTeacherMonth.Text) || String.IsNullOrEmpty(txtTeacherYear.Text))
            {
                MessageBox.Show("Please Fill Month And Year", "Fill Data", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }

            else if (rbnTeacherSearchPay.Checked && !String.IsNullOrEmpty(cmbTeacherMonth.Text) && !String.IsNullOrEmpty(txtTeacherYear.Text) && (e.KeyCode == Keys.Enter))
            {


                teacherServices = new TeacherServicesClient();
                var teacher = new InstituteService.Teacher()
                {
                    TeacherPayYear = int.Parse(txtTeacherYear.Text),
                    TeacherPayMonth = cmbTeacherMonth.Text

                };

                dataSet = teacherServices.GetTeacherMonthYearpaymentReport(teacher);
                ClearListView(listTeacherPayment);
                table = dataSet.Tables[0];
                FillListView(table,listTeacherPayment);
            }
        }

        private void txtEmployeeYear_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(cmbEmployeeMonth.Text)|| String.IsNullOrEmpty(txtEmployeeYear.Text))
                {
                    MessageBox.Show("Please Fill Month And Year", "Fill Data", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
                else if (rbnEmployeeSearchPay.Checked && !String.IsNullOrEmpty(cmbEmployeeMonth.Text) && !String.IsNullOrEmpty(txtEmployeeYear.Text) && (e.KeyCode == Keys.Enter))
                {
                    employeeServices = new EmployeeServicesClient();
                    var employee = new InstituteService.Employee
                    {
                        EmpPayMonth = cmbEmployeeMonth.Text,
                        EmpPayYear = int.Parse(txtEmployeeYear.Text)

                    };
                    dataSet = employeeServices.GetEmployeeMonthYearpaymentReport(employee);
                    ClearListView(listEmployeepayment);
                    table = dataSet.Tables[0];
                    FillListView(table, listEmployeepayment);
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtEmployeeYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            employeeServices = new EmployeeServicesClient();
            teacherServices = new TeacherServicesClient();

            DataSet dataSetEmployee = employeeServices.GetEmployeePayment();
            DataSet dataSetTeacher = teacherServices.GetTeachersIncome();

            var hashtableTeacher = new Hashtable();
            var hashtableEmployee = new Hashtable();

            DataTable dataTableEmployee = dataSetEmployee.Tables[0];

            for (int i = 0; i < dataTableEmployee.Rows.Count; i++)
            {
                if (dataTableEmployee.Rows[i][1].Equals("January"))
                {
                    hashtableEmployee.Add(1, dataTableEmployee.Rows[i][0]);
                    continue;
                }
                if (dataTableEmployee.Rows[i][1].Equals("February"))
                {
                    hashtableEmployee.Add(2, dataTableEmployee.Rows[i][0]);
                    continue;
                }
                if (dataTableEmployee.Rows[i][1].Equals("March"))
                {
                    hashtableEmployee.Add(3, dataTableEmployee.Rows[i][0]);
                    continue;
                }
                if (dataTableEmployee.Rows[i][1].Equals("April"))
                {
                    hashtableEmployee.Add(4, dataTableEmployee.Rows[i][0]);
                    continue;
                }
                if (dataTableEmployee.Rows[i][1].Equals("May"))
                {
                    hashtableEmployee.Add(5, dataTableEmployee.Rows[i][0]);
                    continue;
                }
                if (dataTableEmployee.Rows[i][1].Equals("June"))
                {
                    hashtableEmployee.Add(6, dataTableEmployee.Rows[i][0]);
                    continue;
                }
                if (dataTableEmployee.Rows[i][1].Equals("July"))
                {
                    hashtableEmployee.Add(7, dataTableEmployee.Rows[i][0]);
                    continue;
                }
                if (dataTableEmployee.Rows[i][1].Equals("August"))
                {
                    hashtableEmployee.Add(8, dataTableEmployee.Rows[i][0]);
                    continue;
                }
                if (dataTableEmployee.Rows[i][1].Equals("September"))
                {
                    hashtableEmployee.Add(9, dataTableEmployee.Rows[i][0]);
                    continue;
                }
                if (dataTableEmployee.Rows[i][1].Equals("October"))
                {
                    hashtableEmployee.Add(10, dataTableEmployee.Rows[i][0]);
                    continue;
                }
                if (dataTableEmployee.Rows[i][1].Equals("November"))
                {
                    hashtableEmployee.Add(11, dataTableEmployee.Rows[i][0]);
                    continue;
                }
                if (dataTableEmployee.Rows[i][1].Equals("December"))
                {
                    hashtableEmployee.Add(12, dataTableEmployee.Rows[i][0]);
                   
                }
            }


            DataTable dataTableTeacher = dataSetTeacher.Tables[0];

            for (int i = 0; i < dataTableTeacher.Rows.Count; i++)
            {
                if (dataTableTeacher.Rows[i][1].Equals("January"))
                {
                   hashtableTeacher.Add(1,dataTableTeacher.Rows[i][0]);
                   continue;
                }
                if (dataTableTeacher.Rows[i][1].Equals("February"))
                {
                    hashtableTeacher.Add(2, dataTableTeacher.Rows[i][0]);
                    continue;
                }
                if (dataTableTeacher.Rows[i][1].Equals("March"))
                {
                    hashtableTeacher.Add(3, dataTableTeacher.Rows[i][0]);
                    continue;
                }
                if (dataTableTeacher.Rows[i][1].Equals("April"))
                {
                    hashtableTeacher.Add(4, dataTableTeacher.Rows[i][0]);
                    continue;
                }
                if (dataTableTeacher.Rows[i][1].Equals("May"))
                {
                    hashtableTeacher.Add(5, dataTableTeacher.Rows[i][0]);
                    continue;
                }
                if (dataTableTeacher.Rows[i][1].Equals("June"))
                {
                    hashtableTeacher.Add(6, dataTableTeacher.Rows[i][0]);
                    continue;
                }
                if (dataTableTeacher.Rows[i][1].Equals("July"))
                {
                    hashtableTeacher.Add(7, dataTableTeacher.Rows[i][0]);
                    continue;
                }
                if (dataTableTeacher.Rows[i][1].Equals("August"))
                {
                    hashtableTeacher.Add(8, dataTableTeacher.Rows[i][0]);
                    continue;
                }
                if (dataTableTeacher.Rows[i][1].Equals("September"))
                {
                    hashtableTeacher.Add(9, dataTableTeacher.Rows[i][0]);
                    continue;
                }
                if (dataTableTeacher.Rows[i][1].Equals("October"))
                {
                    hashtableTeacher.Add(10, dataTableTeacher.Rows[i][0]);
                    continue;
                }
                if (dataTableTeacher.Rows[i][1].Equals("November"))
                {
                    hashtableTeacher.Add(11, dataTableTeacher.Rows[i][0]);
                    continue;
                }
                if (dataTableTeacher.Rows[i][1].Equals("December"))
                {
                    hashtableTeacher.Add(12, dataTableTeacher.Rows[i][0]);
                   
                }
            }

            double total = 0;
            double totalEmployee = 0;
            double totalTeacher = 0;

            for (int i = 1; i < 13; i++)
            {
                totalEmployee = 0;
                totalTeacher = 0;

                if (hashtableEmployee[i] != null)
                    totalEmployee = Double.Parse(hashtableEmployee[i].ToString());
                if (hashtableTeacher[i] != null)
                    totalTeacher = Double.Parse(hashtableTeacher[i].ToString());

                total = totalEmployee + totalTeacher;
                hashtableTotal.Add(i,total);
            }

            for (int i = 1; i < 13; i++)
            {
                chartIncome.Series["Income"].Points.AddXY(i, hashtableTotal[i]);
            }

        }
    }
}
