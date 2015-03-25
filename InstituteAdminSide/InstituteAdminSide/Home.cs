using System;
using System.Windows.Forms;

namespace InstituteAdminSide
{
    public partial class Home : Form
    {
        private CustomFormControl formControl = new CustomFormControl();
        public Home()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyChart c = new MyChart();
            c.Show();
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
           
        }

       

        private void timeMenuButton_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            lblTime.Text = time.ToString("HH:mm:ss");
            lblDate.Text = time.ToString("yyyy/MM/dd");

        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void timerMenuButtonMin_Tick(object sender, EventArgs e)
        {
         
        }

       
        private void teacherFormShow(object sender, EventArgs e)
        {
            formControl.FormLoad(new Teacher(), this);
        }

        private void employeeFormShow(object sender, EventArgs e)
        {
            formControl.FormLoad(new Employee(), this);
        }

        private void reportFormShow(object sender, EventArgs e)
        {
            formControl.FormLoad(new Reports(), this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formControl.FormLoad(new Email(), this);
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
