using System;
using System.Data;
using System.Windows.Forms;
using InstituteAdminSide.InstituteService;

namespace InstituteAdminSide
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeacherServicesClient teacher = new TeacherServicesClient();
            MyChart chart = new MyChart(teacher.GetTeachersIncome());
            chart.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeServicesClient client = new EmployeeServicesClient();
           DataSet set  = client.GetEmployeePaymentFull();
           DataTable table = set.Tables[0];
           empPayTable.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            EmployeeServicesClient client = new EmployeeServicesClient();   
            MyChart chart = new MyChart(client.GetEmployeePayment());
            chart.Show();
        }

        private void stuAllPay_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TeacherServicesClient client = new TeacherServicesClient();
            DataSet set = client.GetTeachersPaymentFull();
            DataTable table = set.Tables[0];
            teachPayTable.DataSource = table;

        }
    }
}
