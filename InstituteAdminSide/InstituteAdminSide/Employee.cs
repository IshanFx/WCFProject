using System;
using System.Data;
using System.Windows.Forms;
using InstituteAdminSide.InstituteService;

namespace InstituteAdminSide
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        EmployeeServicesClient client;
        InstituteService.Employee employee;
        private void empSavebtn_Click(object sender, EventArgs e)
        {
            char[] employeeNIC = empNICtxt.Text.ToCharArray();
           
            client = new EmployeeServicesClient();
            if (String.IsNullOrEmpty(empIdtxt.Text) ||
                String.IsNullOrEmpty(empFNametxt.Text) ||
                String.IsNullOrEmpty(empLNametxt.Text) ||
                String.IsNullOrEmpty(empNICtxt.Text) ||
                String.IsNullOrEmpty(empAdd1txt.Text)
                )
            {
                MessageBox.Show("Please Fill Form");
            }

            
   
            else if (!employeeNIC.Length.Equals(9)) {
                MessageBox.Show("Please check NIC. It should be 9 Characters");
            
            }
            else

            {
                string NICX = "V";

                if(rbnNICX.Checked){
                   NICX = "X"; 
                }

                try
                {
                    employee = new InstituteService.Employee()
                    {
                        EmpId = int.Parse(empIdtxt.Text),
                        EmpFName = empFNametxt.Text,
                        EmpLName = empLNametxt.Text,
                        EmpContact = empContacttxt.Text,
                        EmpAddress = empAdd1txt.Text,
                        EmpNIC = empNICtxt.Text+NICX
                    };

                    int chk = client.SaveEmployee(employee);
                    if (chk.Equals(1))
                    {
                        MessageBox.Show(string.Format("Employeed Id {0} Saved", empIdtxt.Text), "Employee Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RegisterFieldClear();
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please check Employee id");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                
            }
        }

        private void empModbtn_Click(object sender, EventArgs e)
        {
           client = new EmployeeServicesClient();
           try
           {
               if (String.IsNullOrEmpty(empIdtxt.Text) ||
                   String.IsNullOrEmpty(empFNametxt.Text) ||
                   String.IsNullOrEmpty(empLNametxt.Text) ||
                   String.IsNullOrEmpty(empNICtxt.Text) ||
                   String.IsNullOrEmpty(empAdd1txt.Text))
               {
                   employee = new InstituteService.Employee()
                   {
                       EmpId = int.Parse(empIdtxt.Text),
                       EmpFName = empFNametxt.Text,
                       EmpLName = empLNametxt.Text,
                       EmpContact = empContacttxt.Text,
                       EmpAddress = empAdd1txt.Text,
                       EmpNIC = empNICtxt.Text

                   };
               }
               else
               {
                   int chk = client.UpdateEmployee(employee);
                   if (chk.Equals(1))
                   {
                       MessageBox.Show(String.Format("Employee Id {0} Updated ",empIdtxt.Text) , "Employee Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       RegisterFieldClear();
                   }
               }
           }
           catch (FormatException ex)
           {
               MessageBox.Show("Please Check Employee ID");
           }
           catch (Exception ex) 
           {
               MessageBox.Show(ex.Message);
           }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                client = new EmployeeServicesClient();

                employee = new InstituteService.Employee();

                employee = client.SearchEmployeeData(int.Parse(empIdtxt.Text));

                empLNametxt.Text = employee.EmpLName;
                empFNametxt.Text = employee.EmpFName;
                empNICtxt.Text = employee.EmpNIC;
                empAdd1txt.Text = employee.EmpAddress;
                empContacttxt.Text = employee.EmpContact;
                btnEmployeeSave.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
                client = new EmployeeServicesClient();
                try
                {
                     employee = new InstituteService.Employee()
                    {
                        EmpId = int.Parse(empPayID.Text.ToString()),
                        EmpPayMonth = payEmpMonthcmb.SelectedItem.ToString(),
                        EmpPayYear = int.Parse(payEmpYeartxt.Text),
                        EmpPayDate = DateTime.Now,
                        EmpPayAmount = double.Parse(payEmpAmounttxt.Text.ToString())

                    };

                    int chk = client.SaveEmployeePayments(employee);


                    if (chk == 1)
                    {
                        MessageBox.Show("Employee Payment saved");
                    }

                    else
                        MessageBox.Show("Not Saved");
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please check Entered data");
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                GetEmployeeLastId();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
             client = new EmployeeServicesClient();
            try
            {
                InstituteService.Employee emploee = new InstituteService.Employee();
                DataSet set = client.GetEmployeeData();
                DataTable table = set.Tables[0];
                empAlldatagrid.DataSource = table;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            GetEmployeeLastId();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            RegisterFieldClear();
            btnEmployeeSave.Enabled = true;
        }
        private void RegisterFieldClear() {
            empIdtxt.Clear();
            empContacttxt.Clear();
            empAdd1txt.Clear();
            empFNametxt.Clear();
            empLNametxt.Clear();
            empNICtxt.Clear();

        }
        private void GetEmployeeLastId() {
            client = new EmployeeServicesClient();
            empLastIdlbl.Text = client.GetEmployeeLastId().ToString();
        
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
