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
    public partial class MyChart : Form
    {
        public MyChart()
        {
            InitializeComponent();
        }

        private void Chart_Load(object sender, EventArgs e)
        {
            InstituteService.TeacherServicesClient client = new InstituteService.TeacherServicesClient();
            DataSet set = client.GetTeachersIncome();
            DataTable table = set.Tables[0];
            int c = table.Rows.Count;
            for (int x = 0; x < c; x++)
            {
                chart1.Series["Income"].Points.AddXY(table.Rows[x][1], table.Rows[x][0]);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
