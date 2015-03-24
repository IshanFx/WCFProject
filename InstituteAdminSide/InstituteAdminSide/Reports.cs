using System;
using System.Collections;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using InstituteAdminSide.InstituteService;
using System.Threading;

namespace InstituteAdminSide
{
    public partial class Reports : Form
    {
        public TeacherServicesClient teacherServices;
        public EmployeeServicesClient employeeServices;
        public StudentServicesClient StudentServices;
        public DataSet dataSet;
        public DataTable table;
        public ListViewItem listView;
        public Hashtable hashtableTotal = new Hashtable();
        public Reports()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
       
        //get teacher all payment details to listview
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
                MessageBox.Show("Data Can't Retrieve", "Cannot get data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //fill list view with comming data
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

        //get employee all payment datails 
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
                MessageBox.Show("Data Can't Retrieve", "Cannot get data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        //clear the listview data
        private void ClearListView(ListView listView)
        {
            listView.Items.Clear();
        }

       
        //search teacher income details when press enter
        private void txtTeacherYear_KeyDown(object sender, KeyEventArgs e)
        {
            if ((String.IsNullOrEmpty(cmbTeacherMonth.Text) || String.IsNullOrEmpty(txtTeacherYear.Text))&& e.KeyCode==Keys.Enter)
            {
                MessageBox.Show("Please Fill Month And Year", "Fill Data", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }

            else if (rbnTeacherSearchPay.Checked && !String.IsNullOrEmpty(cmbTeacherMonth.Text) && !String.IsNullOrEmpty(txtTeacherYear.Text) && (e.KeyCode == Keys.Enter))
            {
                try
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
                    FillListView(table, listTeacherPayment);
                }
                catch (FormatException formatException)
                {
                    MessageBox.Show("Please check year and month", "Check data", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Check data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
        }

        //serach employee income when press enter key
        private void txtEmployeeYear_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                if ((String.IsNullOrEmpty(cmbEmployeeMonth.Text)|| String.IsNullOrEmpty(txtEmployeeYear.Text)) &&  (e.KeyCode==Keys.Enter))
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
            catch (FormatException formatException)
            {
                MessageBox.Show("Please check year and month", "Check data", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Check data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void txtEmployeeYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reports_Load(object sender, EventArgs e)
        {
            //student payment view
           
        }

      

        private void FillStudentListView(DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                ListViewItem list = new ListViewItem(table.Rows[i][0].ToString() + " " + table.Rows[i][1].ToString());
                list.SubItems.Add(table.Rows[i][2].ToString());
                list.SubItems.Add(table.Rows[i][3].ToString());
                list.SubItems.Add(table.Rows[i][4].ToString());
                list.SubItems.Add(table.Rows[i][5].ToString());
                list.SubItems.Add(table.Rows[i][6].ToString());
                listStudentPayment.Items.Add(list);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            GetIncomeToChart();
        }

        //Data need to get Income Details
        private void GetIncomeToChart()
        {
            employeeServices = new EmployeeServicesClient();
            teacherServices = new TeacherServicesClient();
            StudentServices = new StudentServicesClient();


            DataSet dataSetEmployee = employeeServices.GetEmployeePayment();
            DataSet dataSetTeacher = teacherServices.GetTeachersIncome();
            DataSet dataSetStudent = StudentServices.GetStudentIncomeReport();

            var hashtableTeacher = new Hashtable();
            var hashtableEmployee = new Hashtable();
            var hashtableStudent = new Hashtable();

            DataTable dataTableEmployee = dataSetEmployee.Tables[0];
            DataTable dataTableTeacher = dataSetTeacher.Tables[0];
            DataTable dataTableStudent = dataSetStudent.Tables[0];

            
            AddEmployeeToHashtable(dataTableEmployee, hashtableEmployee);
            AddTeacherToHashtable(dataTableTeacher, hashtableTeacher);
            AddStudentToHashtable(dataTableStudent, hashtableStudent);

            CalculateIncome(hashtableEmployee, hashtableTeacher,hashtableStudent);
        }

        //add student income to the hash table
        public static void AddStudentToHashtable(DataTable dataTableStudent, Hashtable hashtableStudent)
        {
            for (int i = 0; i < dataTableStudent.Rows.Count; i++)
            {
                if (dataTableStudent.Rows[i][1].Equals("January"))
                {
                    hashtableStudent.Add(1, dataTableStudent.Rows[i][0]);
                    continue;
                }
                if (dataTableStudent.Rows[i][1].Equals("February"))
                {
                    hashtableStudent.Add(2, dataTableStudent.Rows[i][0]);
                    continue;
                }
                if (dataTableStudent.Rows[i][1].Equals("March"))
                {
                    hashtableStudent.Add(3, dataTableStudent.Rows[i][0]);
                    continue;
                }
                if (dataTableStudent.Rows[i][1].Equals("April"))
                {
                    hashtableStudent.Add(4, dataTableStudent.Rows[i][0]);
                    continue;
                }
                if (dataTableStudent.Rows[i][1].Equals("May"))
                {
                    hashtableStudent.Add(5, dataTableStudent.Rows[i][0]);
                    continue;
                }
                if (dataTableStudent.Rows[i][1].Equals("June"))
                {
                    hashtableStudent.Add(6, dataTableStudent.Rows[i][0]);
                    continue;
                }
                if (dataTableStudent.Rows[i][1].Equals("July"))
                {
                    hashtableStudent.Add(7, dataTableStudent.Rows[i][0]);
                    continue;
                }
                if (dataTableStudent.Rows[i][1].Equals("August"))
                {
                    hashtableStudent.Add(8, dataTableStudent.Rows[i][0]);
                    continue;
                }
                if (dataTableStudent.Rows[i][1].Equals("September"))
                {
                    hashtableStudent.Add(9, dataTableStudent.Rows[i][0]);
                    continue;
                }
                if (dataTableStudent.Rows[i][1].Equals("October"))
                {
                    hashtableStudent.Add(10, dataTableStudent.Rows[i][0]);
                    continue;
                }
                if (dataTableStudent.Rows[i][1].Equals("November"))
                {
                    hashtableStudent.Add(11, dataTableStudent.Rows[i][0]);
                    continue;
                }
                if (dataTableStudent.Rows[i][1].Equals("December"))
                {
                    hashtableStudent.Add(12, dataTableStudent.Rows[i][0]);
                }
            }
        }

        //calculate income from the hashtable data
        private void CalculateIncome(Hashtable hashtableEmployee, Hashtable hashtableTeacher,Hashtable hashtableStudent)
        {
            double totalEmployee;
            double totalTeacher;
            double totalStudent;
            double total;
            for (int i = 1; i < 13; i++)
            {
                totalEmployee = 0;
                totalTeacher = 0;
                totalStudent = 0;

                if (hashtableEmployee[i] != null)
                    totalEmployee = Double.Parse(hashtableEmployee[i].ToString());
                if (hashtableTeacher[i] != null)
                    totalTeacher = Double.Parse(hashtableTeacher[i].ToString());
                if(hashtableStudent[i] !=null )
                    totalStudent = Double.Parse(hashtableStudent[i].ToString());

                total = totalEmployee + totalTeacher + totalStudent;
                hashtableTotal.Add(i, total);
            }

            for (int i = 1; i < 13; i++)
            {
                chartIncome.Series["Income"].Points.AddXY(i, hashtableTotal[i]);
            }
        }

        //add month and total to teacher hashtable
        public static void AddTeacherToHashtable(DataTable dataTableTeacher, Hashtable hashtableTeacher)
        {
            for (int i = 0; i < dataTableTeacher.Rows.Count; i++)
            {
                if (dataTableTeacher.Rows[i][1].Equals("January"))
                {
                    hashtableTeacher.Add(1, dataTableTeacher.Rows[i][0]);
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
        }

        //add month and income to employee hashtable
        public static void AddEmployeeToHashtable(DataTable dataTableEmployee, Hashtable hashtableEmployee)
        {
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
        }

        //load chart of income details of teacher
        private void TeacherIncomeChar_load(object sender, EventArgs e)
        {
            teacherServices = new TeacherServicesClient();
            DataSet set = teacherServices.GetTeachersIncome();
            MyChart chart = new MyChart(set,"Teacher",1);
            chart.Show();
        }

        //load chart of income details of employee
        private void EmployeeChart_load(object sender, EventArgs e)
        {
            employeeServices = new EmployeeServicesClient();
            DataSet set = employeeServices.GetEmployeePayment();
            MyChart chart = new MyChart(set, "Employee",2);
            chart.Show();
        }

        private void StudentIncomehartLoad(object sender, EventArgs e)
        {
            StudentServices = new StudentServicesClient();
            DataSet set = StudentServices.GetStudentIncomeReport();
            MyChart chart = new MyChart(set, "Student", 3);
            chart.Show();
        }

        private void studentYearpaymentSearch(object sender, KeyEventArgs e)
        {

        }

        private void rbnStudentAllpayment_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnStudentAllpayment.Checked)
            {
                ClearListView(listStudentPayment);
                StudentServices = new StudentServicesClient();
                DataSet set = StudentServices.GetStudentPaymentReport();
                DataTable table = set.Tables[0];


                FillStudentListView(table);
            }
        }

        private void StudentPaymentYearSelect(object sender, KeyEventArgs e)
        {
            if ((String.IsNullOrEmpty(cmbStudentPayMonth.Text) || String.IsNullOrEmpty(txtStudentPayYear.Text)) && e.KeyCode==Keys.Enter)
            {
                MessageBox.Show("Please Fill Month And Year", "Fill Data", MessageBoxButtons.OK,
                      MessageBoxIcon.Exclamation);
            }
            else if (rbnStudentSearchPayment.Checked && !String.IsNullOrEmpty(cmbStudentPayMonth.Text) && !String.IsNullOrEmpty(txtStudentPayYear.Text) && (e.KeyCode == Keys.Enter))
            {
                ClearListView(listStudentPayment);
                StudentServices = new StudentServicesClient();
                var student = new InstituteService.Student()
                {
                    StudentPayMonth = cmbStudentPayMonth.Text,
                    StudentPayYear = int.Parse(txtStudentPayYear.Text.ToString()) 
                };

                DataSet set = StudentServices.GetStudentYearpaymentReport(student);
                DataTable table = set.Tables[0];


                FillStudentListView(table);
            }
        }

        private void rbnStudentSearchPayment_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddMonthToCmb()
        {
            String[] months = {"January","February","March","April","May","June","July","August","September","October","November","December"};
        }


    }
}
