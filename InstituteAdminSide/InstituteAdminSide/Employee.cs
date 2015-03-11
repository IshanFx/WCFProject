using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InstituteAdminSide
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void empSavebtn_Click(object sender, EventArgs e)
        {
            InstituteService.EmployeeServicesClient client = new InstituteService.EmployeeServicesClient();

            InstituteService.Employee employee= new InstituteService.Employee()
            {
                EmpId =int.Parse( empIdtxt.Text),
                EmpFName = empFNametxt.Text,
                EmpLName = empLNametxt.Text,
                EmpContact = empContacttxt.Text,
                EmpAddress = empAdd1txt.Text,
                EmpNIC = empNICtxt.Text
            };
            int chk =client.SaveEmployee(employee);
            if (chk == 1)
            {
                MessageBox.Show("Saved");
            }
        }

        private void empModbtn_Click(object sender, EventArgs e)
        {
            InstituteService.EmployeeServicesClient client = new InstituteService.EmployeeServicesClient();

            InstituteService.Employee employee = new InstituteService.Employee() {
                EmpId = int.Parse(empIdtxt.Text),
                EmpFName = empFNametxt.Text,
                EmpLName = empLNametxt.Text,
                EmpContact = empContacttxt.Text,
                EmpAddress = empAdd1txt.Text,
                EmpNIC = empNICtxt.Text
            
            };
           int chk =  client.UpdateEmployee(employee);
           if (chk == 1) {
               MessageBox.Show("Updated");
           }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            InstituteService.EmployeeServicesClient client = new InstituteService.EmployeeServicesClient();

            InstituteService.Employee employee = new InstituteService.Employee();
            employee = client.SearchEmployeeData(int.Parse(empIdtxt.Text));

            empLNametxt.Text = employee.EmpLName;
            empFNametxt.Text = employee.EmpFName;
            empNICtxt.Text = employee.EmpNIC;
            empAdd1txt.Text = employee.EmpAddress;
            empContacttxt.Text = employee.EmpContact;


        }

        private void button7_Click(object sender, EventArgs e)
        {
          
                InstituteService.EmployeeServicesClient client = new InstituteService.EmployeeServicesClient();
               
                InstituteService.Employee employee = new InstituteService.Employee() { 
                    EmpId = int.Parse(empPayID.Text.ToString()),
                    EmpPayMonth  =payEmpMonthcmb.SelectedItem.ToString(),
                    EmpPayYear =int.Parse( payEmpYeartxt.Text),
                    EmpPayDate = DateTime.Now,
                    EmpPayAmount = double.Parse(payEmpAmounttxt.Text.ToString())                

                };

               int chk =  client.SaveEmployeePayments(employee);
               if (chk == 1)
               {
                   MessageBox.Show("Employee Payment saved");
               }
               else
                   MessageBox.Show("Not Saved");
            
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            InstituteService.EmployeeServicesClient client = new InstituteService.EmployeeServicesClient();

            InstituteService.Employee emploee = new InstituteService.Employee();
            DataSet set = client.GetEmployeeData();
            DataTable table = set.Tables[0];
            empAlldatagrid.DataSource = table;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
