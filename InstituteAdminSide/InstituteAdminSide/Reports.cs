using System;
using System.Data;
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
            if (rbnEmployeeAllPay.Checked)
            {

                employeeServices = new EmployeeServicesClient();
                dataSet = employeeServices.GetEmployeeAllPaymentReport();
                table = dataSet.Tables[0];
                ClearListView(listEmployeepayment);
                FillListView(table,listEmployeepayment);
            }
        }

        private void ClearListView(ListView listView)
        {
            listView.Items.Clear();
        }

       

        private void txtTeacherYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (rbnTeacherSearchPay.Checked && !String.IsNullOrEmpty(cmbTeacherMonth.Text) && !String.IsNullOrEmpty(txtTeacherYear.Text) && (e.KeyCode == Keys.Enter))
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
                if (rbnEmployeeSearchPay.Checked && !String.IsNullOrEmpty(cmbEmployeeMonth.Text) && !String.IsNullOrEmpty(txtEmployeeYear.Text) && (e.KeyCode == Keys.Enter))
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
            catch (Exception)
            {
                
                throw;
            }
            
        }
    }
}
