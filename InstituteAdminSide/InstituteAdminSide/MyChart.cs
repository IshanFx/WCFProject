using System;
using System.Data;
using System.Windows.Forms;

namespace InstituteAdminSide
{
    public partial class MyChart : Form
    {
        DataTable table;
        public MyChart()
        {
            InitializeComponent();
        }
        public MyChart(DataSet set)
        {
            table = new DataTable();
            table = set.Tables[0];
            InitializeComponent();
        }

        private void Chart_Load(object sender, EventArgs e)
        {

            FillChartData();
        }

        private void FillChartData()
        {
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
