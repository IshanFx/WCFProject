using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace InstituteAdminSide
{
    partial class Reports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.reportTab = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnStudentIncomeChart = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnTeacherAllPay = new System.Windows.Forms.RadioButton();
            this.rbnTeacherSearchPay = new System.Windows.Forms.RadioButton();
            this.txtTeacherYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTeacherMonth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listTeacherPayment = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTeacherIncomeChart = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.listEmployeepayment = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbnEmployeeAllPay = new System.Windows.Forms.RadioButton();
            this.rbnEmployeeSearchPay = new System.Windows.Forms.RadioButton();
            this.txtEmployeeYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEmployeeMonth = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.chartIncome = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.listStudentPayment = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbnStudentAllpayment = new System.Windows.Forms.RadioButton();
            this.rbnStudentSearchPayment = new System.Windows.Forms.RadioButton();
            this.txtStudentPayYear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbStudentPayMonth = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.reportTab.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncome)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportTab
            // 
            this.reportTab.Controls.Add(this.tabPage3);
            this.reportTab.Controls.Add(this.tabPage4);
            this.reportTab.Controls.Add(this.tabPage5);
            this.reportTab.Controls.Add(this.tabPage1);
            this.reportTab.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportTab.ItemSize = new System.Drawing.Size(119, 28);
            this.reportTab.Location = new System.Drawing.Point(13, 27);
            this.reportTab.Multiline = true;
            this.reportTab.Name = "reportTab";
            this.reportTab.Padding = new System.Drawing.Point(0, 0);
            this.reportTab.SelectedIndex = 0;
            this.reportTab.Size = new System.Drawing.Size(1015, 526);
            this.reportTab.TabIndex = 28;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.listStudentPayment);
            this.tabPage3.Controls.Add(this.btnStudentIncomeChart);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1007, 490);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Student Payment";
            // 
            // btnStudentIncomeChart
            // 
            this.btnStudentIncomeChart.BackColor = System.Drawing.Color.Peru;
            this.btnStudentIncomeChart.ForeColor = System.Drawing.Color.White;
            this.btnStudentIncomeChart.Location = new System.Drawing.Point(7, 414);
            this.btnStudentIncomeChart.Name = "btnStudentIncomeChart";
            this.btnStudentIncomeChart.Size = new System.Drawing.Size(207, 36);
            this.btnStudentIncomeChart.TabIndex = 16;
            this.btnStudentIncomeChart.Text = "Income Chart";
            this.btnStudentIncomeChart.UseVisualStyleBackColor = false;
            this.btnStudentIncomeChart.Click += new System.EventHandler(this.StudentIncomehartLoad);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.listTeacherPayment);
            this.tabPage4.Controls.Add(this.btnTeacherIncomeChart);
            this.tabPage4.Location = new System.Drawing.Point(4, 32);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1007, 490);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Teacher Payment";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnTeacherAllPay);
            this.groupBox1.Controls.Add(this.rbnTeacherSearchPay);
            this.groupBox1.Controls.Add(this.txtTeacherYear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbTeacherMonth);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(11, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(978, 85);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // rbnTeacherAllPay
            // 
            this.rbnTeacherAllPay.AutoSize = true;
            this.rbnTeacherAllPay.Location = new System.Drawing.Point(11, 31);
            this.rbnTeacherAllPay.Name = "rbnTeacherAllPay";
            this.rbnTeacherAllPay.Size = new System.Drawing.Size(141, 23);
            this.rbnTeacherAllPay.TabIndex = 20;
            this.rbnTeacherAllPay.TabStop = true;
            this.rbnTeacherAllPay.Text = "All Payments";
            this.rbnTeacherAllPay.UseVisualStyleBackColor = true;
            this.rbnTeacherAllPay.CheckedChanged += new System.EventHandler(this.TeacherAllPay_Rbn);
            // 
            // rbnTeacherSearchPay
            // 
            this.rbnTeacherSearchPay.AutoSize = true;
            this.rbnTeacherSearchPay.Location = new System.Drawing.Point(359, 31);
            this.rbnTeacherSearchPay.Name = "rbnTeacherSearchPay";
            this.rbnTeacherSearchPay.Size = new System.Drawing.Size(87, 23);
            this.rbnTeacherSearchPay.TabIndex = 21;
            this.rbnTeacherSearchPay.TabStop = true;
            this.rbnTeacherSearchPay.Text = "Search";
            this.rbnTeacherSearchPay.UseVisualStyleBackColor = true;
            this.rbnTeacherSearchPay.CheckedChanged += new System.EventHandler(this.TeacherSearchPay_Rbn);
            // 
            // txtTeacherYear
            // 
            this.txtTeacherYear.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherYear.Location = new System.Drawing.Point(853, 36);
            this.txtTeacherYear.Name = "txtTeacherYear";
            this.txtTeacherYear.Size = new System.Drawing.Size(118, 25);
            this.txtTeacherYear.TabIndex = 16;
            this.txtTeacherYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTeacherYear_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(786, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Year";
            // 
            // cmbTeacherMonth
            // 
            this.cmbTeacherMonth.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTeacherMonth.FormattingEnabled = true;
            this.cmbTeacherMonth.Location = new System.Drawing.Point(633, 33);
            this.cmbTeacherMonth.Name = "cmbTeacherMonth";
            this.cmbTeacherMonth.Size = new System.Drawing.Size(121, 26);
            this.cmbTeacherMonth.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(547, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Month";
            // 
            // listTeacherPayment
            // 
            this.listTeacherPayment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listTeacherPayment.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTeacherPayment.Location = new System.Drawing.Point(9, 104);
            this.listTeacherPayment.Name = "listTeacherPayment";
            this.listTeacherPayment.Size = new System.Drawing.Size(989, 334);
            this.listTeacherPayment.TabIndex = 26;
            this.listTeacherPayment.UseCompatibleStateImageBehavior = false;
            this.listTeacherPayment.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 105;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Year";
            this.columnHeader3.Width = 124;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Month";
            this.columnHeader4.Width = 190;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Payment Date";
            this.columnHeader5.Width = 218;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Amount";
            this.columnHeader6.Width = 163;
            // 
            // btnTeacherIncomeChart
            // 
            this.btnTeacherIncomeChart.BackColor = System.Drawing.Color.Peru;
            this.btnTeacherIncomeChart.ForeColor = System.Drawing.Color.White;
            this.btnTeacherIncomeChart.Location = new System.Drawing.Point(20, 439);
            this.btnTeacherIncomeChart.Name = "btnTeacherIncomeChart";
            this.btnTeacherIncomeChart.Size = new System.Drawing.Size(207, 36);
            this.btnTeacherIncomeChart.TabIndex = 17;
            this.btnTeacherIncomeChart.Text = "Payment";
            this.btnTeacherIncomeChart.UseVisualStyleBackColor = false;
            this.btnTeacherIncomeChart.Click += new System.EventHandler(this.TeacherIncomeChar_load);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.White;
            this.tabPage5.Controls.Add(this.listEmployeepayment);
            this.tabPage5.Controls.Add(this.groupBox4);
            this.tabPage5.Controls.Add(this.button5);
            this.tabPage5.Location = new System.Drawing.Point(4, 32);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1007, 490);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Employee payment";
            // 
            // listEmployeepayment
            // 
            this.listEmployeepayment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listEmployeepayment.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listEmployeepayment.Location = new System.Drawing.Point(9, 102);
            this.listEmployeepayment.Name = "listEmployeepayment";
            this.listEmployeepayment.Size = new System.Drawing.Size(989, 332);
            this.listEmployeepayment.TabIndex = 27;
            this.listEmployeepayment.UseCompatibleStateImageBehavior = false;
            this.listEmployeepayment.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Id";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Name";
            this.columnHeader8.Width = 105;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Year";
            this.columnHeader9.Width = 124;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Month";
            this.columnHeader10.Width = 190;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Payment Date";
            this.columnHeader11.Width = 218;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Amount";
            this.columnHeader12.Width = 163;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbnEmployeeAllPay);
            this.groupBox4.Controls.Add(this.rbnEmployeeSearchPay);
            this.groupBox4.Controls.Add(this.txtEmployeeYear);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.cmbEmployeeMonth);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(10, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(978, 85);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            // 
            // rbnEmployeeAllPay
            // 
            this.rbnEmployeeAllPay.AutoSize = true;
            this.rbnEmployeeAllPay.Location = new System.Drawing.Point(11, 31);
            this.rbnEmployeeAllPay.Name = "rbnEmployeeAllPay";
            this.rbnEmployeeAllPay.Size = new System.Drawing.Size(141, 23);
            this.rbnEmployeeAllPay.TabIndex = 20;
            this.rbnEmployeeAllPay.TabStop = true;
            this.rbnEmployeeAllPay.Text = "All Payments";
            this.rbnEmployeeAllPay.UseVisualStyleBackColor = true;
            this.rbnEmployeeAllPay.CheckedChanged += new System.EventHandler(this.EmployeeAllPay_Rbn);
            // 
            // rbnEmployeeSearchPay
            // 
            this.rbnEmployeeSearchPay.AutoSize = true;
            this.rbnEmployeeSearchPay.Location = new System.Drawing.Point(359, 31);
            this.rbnEmployeeSearchPay.Name = "rbnEmployeeSearchPay";
            this.rbnEmployeeSearchPay.Size = new System.Drawing.Size(87, 23);
            this.rbnEmployeeSearchPay.TabIndex = 21;
            this.rbnEmployeeSearchPay.TabStop = true;
            this.rbnEmployeeSearchPay.Text = "Search";
            this.rbnEmployeeSearchPay.UseVisualStyleBackColor = true;
            this.rbnEmployeeSearchPay.CheckedChanged += new System.EventHandler(this.TeacherSearchPay_Rbn);
            // 
            // txtEmployeeYear
            // 
            this.txtEmployeeYear.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeYear.Location = new System.Drawing.Point(853, 36);
            this.txtEmployeeYear.Name = "txtEmployeeYear";
            this.txtEmployeeYear.Size = new System.Drawing.Size(118, 25);
            this.txtEmployeeYear.TabIndex = 16;
            this.txtEmployeeYear.TextChanged += new System.EventHandler(this.txtEmployeeYear_TextChanged);
            this.txtEmployeeYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmployeeYear_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(786, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Year";
            // 
            // cmbEmployeeMonth
            // 
            this.cmbEmployeeMonth.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployeeMonth.FormattingEnabled = true;
            this.cmbEmployeeMonth.Location = new System.Drawing.Point(633, 33);
            this.cmbEmployeeMonth.Name = "cmbEmployeeMonth";
            this.cmbEmployeeMonth.Size = new System.Drawing.Size(121, 26);
            this.cmbEmployeeMonth.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(547, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Month";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Peru;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(20, 440);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(207, 36);
            this.button5.TabIndex = 19;
            this.button5.Text = "Payment";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.EmployeeChart_load);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.chartIncome);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1007, 490);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Total Income";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Peru;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(28, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 36);
            this.button2.TabIndex = 18;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // chartIncome
            // 
            chartArea1.Name = "ChartArea1";
            this.chartIncome.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartIncome.Legends.Add(legend1);
            this.chartIncome.Location = new System.Drawing.Point(28, 48);
            this.chartIncome.Name = "chartIncome";
            this.chartIncome.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Income";
            this.chartIncome.Series.Add(series1);
            this.chartIncome.Size = new System.Drawing.Size(880, 414);
            this.chartIncome.TabIndex = 0;
            this.chartIncome.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 643);
            this.panel1.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(743, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 60);
            this.label9.TabIndex = 78;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Image = ((System.Drawing.Image)(resources.GetObject("label18.Image")));
            this.label18.Location = new System.Drawing.Point(950, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 60);
            this.label18.TabIndex = 77;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Image = ((System.Drawing.Image)(resources.GetObject("label16.Image")));
            this.label16.Location = new System.Drawing.Point(881, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 60);
            this.label16.TabIndex = 76;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Image = ((System.Drawing.Image)(resources.GetObject("label15.Image")));
            this.label15.Location = new System.Drawing.Point(812, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 60);
            this.label15.TabIndex = 75;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.reportTab);
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1091, 577);
            this.panel2.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Stencil Std", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 49);
            this.label6.TabIndex = 16;
            this.label6.Text = "Report";
            // 
            // listStudentPayment
            // 
            this.listStudentPayment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.listStudentPayment.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F);
            this.listStudentPayment.Location = new System.Drawing.Point(8, 95);
            this.listStudentPayment.Name = "listStudentPayment";
            this.listStudentPayment.Size = new System.Drawing.Size(989, 313);
            this.listStudentPayment.TabIndex = 18;
            this.listStudentPayment.UseCompatibleStateImageBehavior = false;
            this.listStudentPayment.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Name";
            this.columnHeader13.Width = 103;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Year";
            this.columnHeader14.Width = 128;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Month";
            this.columnHeader15.Width = 164;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Amount";
            this.columnHeader16.Width = 227;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Course ID";
            this.columnHeader17.Width = 191;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Batch";
            this.columnHeader18.Width = 158;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbnStudentAllpayment);
            this.groupBox2.Controls.Add(this.rbnStudentSearchPayment);
            this.groupBox2.Controls.Add(this.txtStudentPayYear);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbStudentPayMonth);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(7, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(978, 85);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // rbnStudentAllpayment
            // 
            this.rbnStudentAllpayment.AutoSize = true;
            this.rbnStudentAllpayment.Location = new System.Drawing.Point(11, 31);
            this.rbnStudentAllpayment.Name = "rbnStudentAllpayment";
            this.rbnStudentAllpayment.Size = new System.Drawing.Size(141, 23);
            this.rbnStudentAllpayment.TabIndex = 20;
            this.rbnStudentAllpayment.TabStop = true;
            this.rbnStudentAllpayment.Text = "All Payments";
            this.rbnStudentAllpayment.UseVisualStyleBackColor = true;
            this.rbnStudentAllpayment.CheckedChanged += new System.EventHandler(this.rbnStudentAllpayment_CheckedChanged);
            // 
            // rbnStudentSearchPayment
            // 
            this.rbnStudentSearchPayment.AutoSize = true;
            this.rbnStudentSearchPayment.Location = new System.Drawing.Point(363, 31);
            this.rbnStudentSearchPayment.Name = "rbnStudentSearchPayment";
            this.rbnStudentSearchPayment.Size = new System.Drawing.Size(87, 23);
            this.rbnStudentSearchPayment.TabIndex = 21;
            this.rbnStudentSearchPayment.TabStop = true;
            this.rbnStudentSearchPayment.Text = "Search";
            this.rbnStudentSearchPayment.UseVisualStyleBackColor = true;
            this.rbnStudentSearchPayment.CheckedChanged += new System.EventHandler(this.rbnStudentSearchPayment_CheckedChanged);
            // 
            // txtStudentPayYear
            // 
            this.txtStudentPayYear.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentPayYear.Location = new System.Drawing.Point(852, 34);
            this.txtStudentPayYear.Name = "txtStudentPayYear";
            this.txtStudentPayYear.Size = new System.Drawing.Size(118, 25);
            this.txtStudentPayYear.TabIndex = 16;
            this.txtStudentPayYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StudentPaymentYearSelect);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(785, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Year";
            // 
            // cmbStudentPayMonth
            // 
            this.cmbStudentPayMonth.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStudentPayMonth.FormattingEnabled = true;
            this.cmbStudentPayMonth.Location = new System.Drawing.Point(632, 31);
            this.cmbStudentPayMonth.Name = "cmbStudentPayMonth";
            this.cmbStudentPayMonth.Size = new System.Drawing.Size(121, 26);
            this.cmbStudentPayMonth.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label7.Location = new System.Drawing.Point(546, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Month";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 631);
            this.Controls.Add(this.panel1);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.reportTab.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartIncome)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl reportTab;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Panel panel1;
        private Label label6;
        private Button btnStudentIncomeChart;
        private Button btnTeacherIncomeChart;
        private TabPage tabPage1;
        private Chart chartIncome;
        private Button button5;
        private RadioButton rbnEmployeeAllPay;
        private GroupBox groupBox4;
        private RadioButton rbnEmployeeSearchPay;
        private TextBox txtEmployeeYear;
        private Label label1;
        private ComboBox cmbEmployeeMonth;
        private Label label4;
        private Label label9;
        private Label label18;
        private Label label16;
        private Label label15;
        private Panel panel2;
        private ListView listTeacherPayment;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ListView listEmployeepayment;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private GroupBox groupBox1;
        private RadioButton rbnTeacherAllPay;
        private RadioButton rbnTeacherSearchPay;
        private TextBox txtTeacherYear;
        private Label label2;
        private ComboBox cmbTeacherMonth;
        private Label label3;
        private Button button2;
        private ListView listStudentPayment;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private GroupBox groupBox2;
        private RadioButton rbnStudentAllpayment;
        private RadioButton rbnStudentSearchPayment;
        private TextBox txtStudentPayYear;
        private Label label5;
        private ComboBox cmbStudentPayMonth;
        private Label label7;
    }
}