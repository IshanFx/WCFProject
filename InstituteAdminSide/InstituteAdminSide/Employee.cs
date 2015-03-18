using System;
using System.CodeDom;
using System.Data;
using System.ServiceModel;
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
                MessageBox.Show("Please Fill Form","Fill Form",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }

            
   
            else if (!employeeNIC.Length.Equals(9)) {
                MessageBox.Show("Please check NIC. It should be 9 Characters","Check NIC",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            
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
                    MessageBox.Show("Please check Employee id","Id Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                    MessageBox.Show("Please Fill All Data", "Fill data", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else if (int.Parse(empIdtxt.Text) <= client.GetEmployeeLastId())
                {
                    MessageBox.Show("Please Enter Id Greater then Last Id", "Enter Id", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
                else
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
                    int chk = client.UpdateEmployee(employee);
                    if (chk.Equals(1))
                    {
                        MessageBox.Show(String.Format("Employee Id {0} Updated ", empIdtxt.Text), "Employee Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RegisterFieldClear();
                    }
                }
            }
            catch (TimeoutException timeout)
            {
                MessageBox.Show("Requesting time was out,Try again ", "Time out", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (FormatException formatException)
            {
                MessageBox.Show("Please Check Employee ID","Id Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                String NICType = employee.EmpNIC[9].ToString();
                if (NICType.Equals("V"))
                {
                    rbnNICY.Checked = true;
                }
                else
                {
                    rbnNICX.Checked = true;
                }
                String NICRemoved = employee.EmpNIC.Remove(9);
                empNICtxt.Text = NICRemoved;
                empAdd1txt.Text = employee.EmpAddress;
                empContacttxt.Text = employee.EmpContact;
                btnEmployeeSave.Enabled = false;

            }
            catch (TimeoutException timeout)
            {
                MessageBox.Show("Requesting time was out,Try again ", "Time out", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                        MessageBox.Show("Employee Payment saved","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }

                    else
                        MessageBox.Show("payment Not Saved", "Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please check Entered data","Id Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                ListViewItem list = null;
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    list = new ListViewItem(table.Rows[i][0].ToString());
                    list.SubItems.Add(table.Rows[i][1].ToString()+" "+table.Rows[i][2].ToString());
                    list.SubItems.Add(table.Rows[i][3].ToString());
                    list.SubItems.Add(table.Rows[i][4].ToString());
                    list.SubItems.Add(table.Rows[i][5].ToString());
                    listEmployeeData.Items.Add(list);
                }
                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                client = new EmployeeServicesClient();
                empLastIdlbl.Text = client.GetEmployeeLastId().ToString();
        
            }
            catch (Exception exception)
            {
                MessageBox.Show("Cannot get Id", "Id error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
