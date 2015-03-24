using System;
using System.Collections;
using System.Data;
using System.Runtime.Remoting.Proxies;
using System.Windows.Forms;

namespace InstituteAdminSide
{
    public partial class MyChart : Form
    {
        DataTable table;
        private string formName;
        private int type;
        public MyChart()
        {
            InitializeComponent();
        }
        public MyChart(DataSet set,string name,int type)
        {
            table = new DataTable();
            table = set.Tables[0];
            InitializeComponent();
            formName = name;
            this.type = type;

        }

       
        private void Chart_Load(object sender, EventArgs e)
        {
            if (type.Equals(1))
            {
                chartTitle.Text = formName;
                Hashtable teacherHashtable = new Hashtable();
                Reports.AddTeacherToHashtable(table, teacherHashtable);

                for (int i = 1; i < 13; i++)
                {
                    chartIncomePart.Series["Income"].Points.AddXY(i, teacherHashtable[i]);
                }

            }
            if (type.Equals(2))
            {
                chartTitle.Text = formName;
                Hashtable employeeHashtable = new Hashtable();
                Reports.AddEmployeeToHashtable(table, employeeHashtable);

                for (int i = 1; i < 13; i++)
                {
                    chartIncomePart.Series["Income"].Points.AddXY(i, employeeHashtable[i]);
                }
            }

        }

       
       
    }

}
