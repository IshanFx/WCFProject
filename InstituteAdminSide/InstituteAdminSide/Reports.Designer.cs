namespace InstituteAdminSide
{
    partial class Reports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.reportTab = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.stuAllPay = new System.Windows.Forms.Button();
            this.stuPayTable = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.tyear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tsearchbtn = new System.Windows.Forms.Button();
            this.teachPayTable = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tcomb = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.empPayYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.eserchbtn = new System.Windows.Forms.Button();
            this.empPayTable = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.empMonth = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.reportTab.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stuPayTable)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachPayTable)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empPayTable)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportTab
            // 
            this.reportTab.Controls.Add(this.tabPage3);
            this.reportTab.Controls.Add(this.tabPage4);
            this.reportTab.Controls.Add(this.tabPage5);
            this.reportTab.Controls.Add(this.tabPage1);
            this.reportTab.Font = new System.Drawing.Font("Stencil Std", 14.25F, System.Drawing.FontStyle.Bold);
            this.reportTab.ItemSize = new System.Drawing.Size(119, 28);
            this.reportTab.Location = new System.Drawing.Point(14, 88);
            this.reportTab.Multiline = true;
            this.reportTab.Name = "reportTab";
            this.reportTab.Padding = new System.Drawing.Point(0, 0);
            this.reportTab.SelectedIndex = 0;
            this.reportTab.Size = new System.Drawing.Size(1015, 541);
            this.reportTab.TabIndex = 28;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.stuAllPay);
            this.tabPage3.Controls.Add(this.stuPayTable);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1007, 505);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Student";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(836, 414);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 33);
            this.button4.TabIndex = 17;
            this.button4.Text = "PDF";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Income Chart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stuAllPay
            // 
            this.stuAllPay.BackColor = System.Drawing.Color.SaddleBrown;
            this.stuAllPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stuAllPay.ForeColor = System.Drawing.Color.White;
            this.stuAllPay.Location = new System.Drawing.Point(7, 24);
            this.stuAllPay.Name = "stuAllPay";
            this.stuAllPay.Size = new System.Drawing.Size(132, 35);
            this.stuAllPay.TabIndex = 15;
            this.stuAllPay.Text = "All";
            this.stuAllPay.UseVisualStyleBackColor = false;
            this.stuAllPay.Click += new System.EventHandler(this.stuAllPay_Click);
            // 
            // stuPayTable
            // 
            this.stuPayTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stuPayTable.Location = new System.Drawing.Point(3, 79);
            this.stuPayTable.Name = "stuPayTable";
            this.stuPayTable.Size = new System.Drawing.Size(994, 305);
            this.stuPayTable.TabIndex = 13;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.tyear);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.tsearchbtn);
            this.tabPage4.Controls.Add(this.teachPayTable);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.tcomb);
            this.tabPage4.Location = new System.Drawing.Point(4, 32);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1007, 505);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Teacher";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 439);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 36);
            this.button2.TabIndex = 17;
            this.button2.Text = "Income Chart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tyear
            // 
            this.tyear.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.tyear.Location = new System.Drawing.Point(194, 47);
            this.tyear.Name = "tyear";
            this.tyear.Size = new System.Drawing.Size(118, 26);
            this.tyear.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil Std", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(189, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Year";
            // 
            // tsearchbtn
            // 
            this.tsearchbtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.tsearchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tsearchbtn.ForeColor = System.Drawing.Color.White;
            this.tsearchbtn.Location = new System.Drawing.Point(366, 34);
            this.tsearchbtn.Name = "tsearchbtn";
            this.tsearchbtn.Size = new System.Drawing.Size(121, 39);
            this.tsearchbtn.TabIndex = 12;
            this.tsearchbtn.Text = "Search";
            this.tsearchbtn.UseVisualStyleBackColor = false;
            // 
            // teachPayTable
            // 
            this.teachPayTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachPayTable.Location = new System.Drawing.Point(20, 114);
            this.teachPayTable.Name = "teachPayTable";
            this.teachPayTable.Size = new System.Drawing.Size(791, 189);
            this.teachPayTable.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil Std", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(28, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Month";
            // 
            // tcomb
            // 
            this.tcomb.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.tcomb.FormattingEnabled = true;
            this.tcomb.Location = new System.Drawing.Point(33, 47);
            this.tcomb.Name = "tcomb";
            this.tcomb.Size = new System.Drawing.Size(121, 26);
            this.tcomb.TabIndex = 9;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.White;
            this.tabPage5.Controls.Add(this.button5);
            this.tabPage5.Controls.Add(this.empPayYear);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.button3);
            this.tabPage5.Controls.Add(this.eserchbtn);
            this.tabPage5.Controls.Add(this.empPayTable);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.empMonth);
            this.tabPage5.Location = new System.Drawing.Point(4, 32);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1007, 505);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Employee";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(20, 440);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(207, 36);
            this.button5.TabIndex = 19;
            this.button5.Text = "Income Chart";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // empPayYear
            // 
            this.empPayYear.Location = new System.Drawing.Point(218, 43);
            this.empPayYear.Name = "empPayYear";
            this.empPayYear.Size = new System.Drawing.Size(121, 33);
            this.empPayYear.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil Std", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(213, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Year";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SaddleBrown;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(707, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 33);
            this.button3.TabIndex = 15;
            this.button3.Text = "All";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // eserchbtn
            // 
            this.eserchbtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.eserchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eserchbtn.ForeColor = System.Drawing.Color.White;
            this.eserchbtn.Location = new System.Drawing.Point(358, 43);
            this.eserchbtn.Name = "eserchbtn";
            this.eserchbtn.Size = new System.Drawing.Size(135, 33);
            this.eserchbtn.TabIndex = 14;
            this.eserchbtn.Text = "Search";
            this.eserchbtn.UseVisualStyleBackColor = false;
            // 
            // empPayTable
            // 
            this.empPayTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empPayTable.Location = new System.Drawing.Point(20, 114);
            this.empPayTable.Name = "empPayTable";
            this.empPayTable.Size = new System.Drawing.Size(805, 296);
            this.empPayTable.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil Std", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(25, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Month";
            // 
            // empMonth
            // 
            this.empMonth.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.empMonth.FormattingEnabled = true;
            this.empMonth.Location = new System.Drawing.Point(30, 48);
            this.empMonth.Name = "empMonth";
            this.empMonth.Size = new System.Drawing.Size(121, 26);
            this.empMonth.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1007, 505);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Total Income";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(28, 20);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(880, 442);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.reportTab);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 643);
            this.panel1.TabIndex = 29;
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
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SaddleBrown;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(551, 34);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 35);
            this.button6.TabIndex = 18;
            this.button6.Text = "All";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 639);
            this.Controls.Add(this.panel1);
            this.Name = "Reports";
            this.Text = "Reports";
            this.reportTab.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stuPayTable)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachPayTable)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empPayTable)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl reportTab;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button stuAllPay;
        private System.Windows.Forms.DataGridView stuPayTable;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox tyear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tsearchbtn;
        private System.Windows.Forms.DataGridView teachPayTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tcomb;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox empPayYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button eserchbtn;
        private System.Windows.Forms.DataGridView empPayTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox empMonth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}