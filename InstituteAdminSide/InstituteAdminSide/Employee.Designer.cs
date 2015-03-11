namespace InstituteAdminSide
{
    partial class Employee
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.empLastIdlbl = new System.Windows.Forms.Label();
            this.empIdtxt = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.empModbtn = new System.Windows.Forms.Button();
            this.empSavebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.empContacttxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.empAdd1txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.empNICtxt = new System.Windows.Forms.TextBox();
            this.empFNametxt = new System.Windows.Forms.TextBox();
            this.empLNametxt = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.empPayID = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.payEmpAmounttxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.payEmpYeartxt = new System.Windows.Forms.TextBox();
            this.payEmpMonthcmb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.empAlldatagrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empAlldatagrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Stencil Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(11, 91);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(890, 555);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.empLastIdlbl);
            this.tabPage1.Controls.Add(this.empIdtxt);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.empModbtn);
            this.tabPage1.Controls.Add(this.empSavebtn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.empContacttxt);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.empAdd1txt);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.empNICtxt);
            this.tabPage1.Controls.Add(this.empFNametxt);
            this.tabPage1.Controls.Add(this.empLNametxt);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(882, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Register";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(734, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 40);
            this.button1.TabIndex = 41;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // empLastIdlbl
            // 
            this.empLastIdlbl.AutoSize = true;
            this.empLastIdlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empLastIdlbl.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.empLastIdlbl.ForeColor = System.Drawing.Color.White;
            this.empLastIdlbl.Location = new System.Drawing.Point(230, 15);
            this.empLastIdlbl.Name = "empLastIdlbl";
            this.empLastIdlbl.Size = new System.Drawing.Size(33, 25);
            this.empLastIdlbl.TabIndex = 40;
            this.empLastIdlbl.Text = "ID";
            // 
            // empIdtxt
            // 
            this.empIdtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empIdtxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.empIdtxt.Location = new System.Drawing.Point(230, 60);
            this.empIdtxt.Name = "empIdtxt";
            this.empIdtxt.Size = new System.Drawing.Size(100, 26);
            this.empIdtxt.TabIndex = 28;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkRed;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(413, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 33);
            this.button4.TabIndex = 39;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // empModbtn
            // 
            this.empModbtn.BackColor = System.Drawing.Color.Maroon;
            this.empModbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empModbtn.FlatAppearance.BorderSize = 0;
            this.empModbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empModbtn.ForeColor = System.Drawing.Color.White;
            this.empModbtn.Location = new System.Drawing.Point(579, 459);
            this.empModbtn.Name = "empModbtn";
            this.empModbtn.Size = new System.Drawing.Size(111, 40);
            this.empModbtn.TabIndex = 37;
            this.empModbtn.Text = "Modify";
            this.empModbtn.UseVisualStyleBackColor = false;
            this.empModbtn.Click += new System.EventHandler(this.empModbtn_Click);
            // 
            // empSavebtn
            // 
            this.empSavebtn.BackColor = System.Drawing.Color.Maroon;
            this.empSavebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empSavebtn.FlatAppearance.BorderSize = 0;
            this.empSavebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empSavebtn.ForeColor = System.Drawing.Color.White;
            this.empSavebtn.Location = new System.Drawing.Point(417, 459);
            this.empSavebtn.Name = "empSavebtn";
            this.empSavebtn.Size = new System.Drawing.Size(111, 40);
            this.empSavebtn.TabIndex = 36;
            this.empSavebtn.Text = "Save";
            this.empSavebtn.UseVisualStyleBackColor = false;
            this.empSavebtn.Click += new System.EventHandler(this.empSavebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(57, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(57, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(57, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(57, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Address";
            // 
            // empContacttxt
            // 
            this.empContacttxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.empContacttxt.Location = new System.Drawing.Point(230, 389);
            this.empContacttxt.MaxLength = 10;
            this.empContacttxt.Name = "empContacttxt";
            this.empContacttxt.Size = new System.Drawing.Size(159, 26);
            this.empContacttxt.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(57, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 22);
            this.label5.TabIndex = 24;
            this.label5.Text = "Contact";
            // 
            // empAdd1txt
            // 
            this.empAdd1txt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.empAdd1txt.Location = new System.Drawing.Point(230, 284);
            this.empAdd1txt.Multiline = true;
            this.empAdd1txt.Name = "empAdd1txt";
            this.empAdd1txt.Size = new System.Drawing.Size(159, 83);
            this.empAdd1txt.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(57, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 22);
            this.label8.TabIndex = 27;
            this.label8.Text = "NIC";
            // 
            // empNICtxt
            // 
            this.empNICtxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.empNICtxt.Location = new System.Drawing.Point(230, 221);
            this.empNICtxt.MaxLength = 10;
            this.empNICtxt.Name = "empNICtxt";
            this.empNICtxt.Size = new System.Drawing.Size(159, 26);
            this.empNICtxt.TabIndex = 31;
            // 
            // empFNametxt
            // 
            this.empFNametxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.empFNametxt.Location = new System.Drawing.Point(230, 106);
            this.empFNametxt.Name = "empFNametxt";
            this.empFNametxt.Size = new System.Drawing.Size(159, 26);
            this.empFNametxt.TabIndex = 29;
            // 
            // empLNametxt
            // 
            this.empLNametxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.empLNametxt.Location = new System.Drawing.Point(230, 164);
            this.empLNametxt.Name = "empLNametxt";
            this.empLNametxt.Size = new System.Drawing.Size(159, 26);
            this.empLNametxt.TabIndex = 30;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.empPayID);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.payEmpAmounttxt);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.payEmpYeartxt);
            this.tabPage2.Controls.Add(this.payEmpMonthcmb);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(882, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Payments";
            // 
            // empPayID
            // 
            this.empPayID.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.empPayID.Location = new System.Drawing.Point(364, 67);
            this.empPayID.Name = "empPayID";
            this.empPayID.Size = new System.Drawing.Size(98, 26);
            this.empPayID.TabIndex = 20;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DarkRed;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(572, 359);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(145, 47);
            this.button7.TabIndex = 19;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // payEmpAmounttxt
            // 
            this.payEmpAmounttxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.payEmpAmounttxt.Location = new System.Drawing.Point(364, 250);
            this.payEmpAmounttxt.MaxLength = 4;
            this.payEmpAmounttxt.Name = "payEmpAmounttxt";
            this.payEmpAmounttxt.Size = new System.Drawing.Size(192, 26);
            this.payEmpAmounttxt.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Stencil", 14.25F);
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(200, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 22);
            this.label10.TabIndex = 17;
            this.label10.Text = "Amount";
            // 
            // payEmpYeartxt
            // 
            this.payEmpYeartxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.payEmpYeartxt.Location = new System.Drawing.Point(364, 183);
            this.payEmpYeartxt.Name = "payEmpYeartxt";
            this.payEmpYeartxt.Size = new System.Drawing.Size(192, 26);
            this.payEmpYeartxt.TabIndex = 16;
            // 
            // payEmpMonthcmb
            // 
            this.payEmpMonthcmb.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.payEmpMonthcmb.FormattingEnabled = true;
            this.payEmpMonthcmb.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.payEmpMonthcmb.Location = new System.Drawing.Point(364, 125);
            this.payEmpMonthcmb.Name = "payEmpMonthcmb";
            this.payEmpMonthcmb.Size = new System.Drawing.Size(192, 26);
            this.payEmpMonthcmb.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Stencil", 14.25F);
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(202, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 22);
            this.label11.TabIndex = 13;
            this.label11.Text = "Year";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Stencil", 14.25F);
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(200, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 22);
            this.label12.TabIndex = 12;
            this.label12.Text = "Month";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Stencil", 14.25F);
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(200, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 22);
            this.label13.TabIndex = 11;
            this.label13.Text = "Employee ID";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.empAlldatagrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(882, 517);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // empAlldatagrid
            // 
            this.empAlldatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empAlldatagrid.Location = new System.Drawing.Point(6, 29);
            this.empAlldatagrid.Name = "empAlldatagrid";
            this.empAlldatagrid.Size = new System.Drawing.Size(870, 481);
            this.empAlldatagrid.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 672);
            this.panel1.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 44);
            this.label6.TabIndex = 42;
            this.label6.Text = "Employee ";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 668);
            this.Controls.Add(this.panel1);
            this.Name = "Employee";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empAlldatagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label empLastIdlbl;
        private System.Windows.Forms.TextBox empIdtxt;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button empModbtn;
        private System.Windows.Forms.Button empSavebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox empContacttxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox empAdd1txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox empNICtxt;
        private System.Windows.Forms.TextBox empFNametxt;
        private System.Windows.Forms.TextBox empLNametxt;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox payEmpAmounttxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox payEmpYeartxt;
        private System.Windows.Forms.ComboBox payEmpMonthcmb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView empAlldatagrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox empPayID;
    }
}

