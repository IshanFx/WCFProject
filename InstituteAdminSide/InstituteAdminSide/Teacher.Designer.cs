using System.ComponentModel;
using System.Windows.Forms;

namespace InstituteAdminSide
{
    partial class Teacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.txtLastId = new System.Windows.Forms.TextBox();
            this.rbnNICV = new System.Windows.Forms.RadioButton();
            this.rbnNICX = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnTeacherUpdate = new System.Windows.Forms.Button();
            this.btnTeacherSave = new System.Windows.Forms.Button();
            this.teacherSubjectcmd = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.teacherMailtxt = new System.Windows.Forms.TextBox();
            this.teacherAddresstxt = new System.Windows.Forms.TextBox();
            this.teacherContacttxt = new System.Windows.Forms.TextBox();
            this.teacherNICtxt = new System.Windows.Forms.TextBox();
            this.teacherLNametxt = new System.Windows.Forms.TextBox();
            this.teacherFNametxt = new System.Windows.Forms.TextBox();
            this.teacherIdtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEmployeePayment = new System.Windows.Forms.Button();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.txtPaymentYear = new System.Windows.Forms.TextBox();
            this.txtPaymentMonth = new System.Windows.Forms.TextBox();
            this.txtPaymentTeaId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listTeacherData = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Stencil", 14.25F);
            this.tabControl1.Location = new System.Drawing.Point(9, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(902, 601);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.txtLastId);
            this.tabPage1.Controls.Add(this.rbnNICV);
            this.tabPage1.Controls.Add(this.rbnNICX);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.btnTeacherUpdate);
            this.tabPage1.Controls.Add(this.btnTeacherSave);
            this.tabPage1.Controls.Add(this.teacherSubjectcmd);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.teacherMailtxt);
            this.tabPage1.Controls.Add(this.teacherAddresstxt);
            this.tabPage1.Controls.Add(this.teacherContacttxt);
            this.tabPage1.Controls.Add(this.teacherNICtxt);
            this.tabPage1.Controls.Add(this.teacherLNametxt);
            this.tabPage1.Controls.Add(this.teacherFNametxt);
            this.tabPage1.Controls.Add(this.teacherIdtxt);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(894, 566);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Register";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkGreen;
            this.label14.Location = new System.Drawing.Point(80, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 22);
            this.label14.TabIndex = 66;
            this.label14.Text = "Last Id";
            // 
            // txtLastId
            // 
            this.txtLastId.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.txtLastId.Location = new System.Drawing.Point(257, 19);
            this.txtLastId.Name = "txtLastId";
            this.txtLastId.Size = new System.Drawing.Size(61, 26);
            this.txtLastId.TabIndex = 65;
            // 
            // rbnNICV
            // 
            this.rbnNICV.AutoSize = true;
            this.rbnNICV.Location = new System.Drawing.Point(415, 237);
            this.rbnNICV.Name = "rbnNICV";
            this.rbnNICV.Size = new System.Drawing.Size(39, 26);
            this.rbnNICV.TabIndex = 64;
            this.rbnNICV.TabStop = true;
            this.rbnNICV.Text = "V";
            this.rbnNICV.UseVisualStyleBackColor = true;
            // 
            // rbnNICX
            // 
            this.rbnNICX.AutoSize = true;
            this.rbnNICX.Location = new System.Drawing.Point(475, 237);
            this.rbnNICX.Name = "rbnNICX";
            this.rbnNICX.Size = new System.Drawing.Size(40, 26);
            this.rbnNICX.TabIndex = 63;
            this.rbnNICX.TabStop = true;
            this.rbnNICX.Text = "X";
            this.rbnNICX.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGreen;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(415, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 40);
            this.button3.TabIndex = 62;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.ForestGreen;
            this.button2.Location = new System.Drawing.Point(755, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 40);
            this.button2.TabIndex = 61;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.clearFields);
            // 
            // btnTeacherUpdate
            // 
            this.btnTeacherUpdate.BackColor = System.Drawing.Color.DarkGreen;
            this.btnTeacherUpdate.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnTeacherUpdate.FlatAppearance.BorderSize = 2;
            this.btnTeacherUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacherUpdate.ForeColor = System.Drawing.Color.White;
            this.btnTeacherUpdate.Location = new System.Drawing.Point(590, 514);
            this.btnTeacherUpdate.Name = "btnTeacherUpdate";
            this.btnTeacherUpdate.Size = new System.Drawing.Size(110, 40);
            this.btnTeacherUpdate.TabIndex = 60;
            this.btnTeacherUpdate.Text = "Update";
            this.btnTeacherUpdate.UseVisualStyleBackColor = false;
            this.btnTeacherUpdate.Click += new System.EventHandler(this.updateTeacher);
            // 
            // btnTeacherSave
            // 
            this.btnTeacherSave.BackColor = System.Drawing.Color.DarkGreen;
            this.btnTeacherSave.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnTeacherSave.FlatAppearance.BorderSize = 2;
            this.btnTeacherSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacherSave.ForeColor = System.Drawing.Color.White;
            this.btnTeacherSave.Location = new System.Drawing.Point(454, 514);
            this.btnTeacherSave.Name = "btnTeacherSave";
            this.btnTeacherSave.Size = new System.Drawing.Size(110, 40);
            this.btnTeacherSave.TabIndex = 59;
            this.btnTeacherSave.Text = "Save";
            this.btnTeacherSave.UseVisualStyleBackColor = false;
            this.btnTeacherSave.Click += new System.EventHandler(this.teacherSavebtn_Click);
            // 
            // teacherSubjectcmd
            // 
            this.teacherSubjectcmd.FormattingEnabled = true;
            this.teacherSubjectcmd.Location = new System.Drawing.Point(257, 451);
            this.teacherSubjectcmd.Name = "teacherSubjectcmd";
            this.teacherSubjectcmd.Size = new System.Drawing.Size(137, 30);
            this.teacherSubjectcmd.TabIndex = 58;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkGreen;
            this.label13.Location = new System.Drawing.Point(80, 459);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 22);
            this.label13.TabIndex = 57;
            this.label13.Text = "Subject";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkGreen;
            this.label12.Location = new System.Drawing.Point(81, 404);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 22);
            this.label12.TabIndex = 56;
            this.label12.Text = "E-Mail";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkGreen;
            this.label11.Location = new System.Drawing.Point(80, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 22);
            this.label11.TabIndex = 55;
            this.label11.Text = "Address";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // teacherMailtxt
            // 
            this.teacherMailtxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.teacherMailtxt.Location = new System.Drawing.Point(257, 404);
            this.teacherMailtxt.Name = "teacherMailtxt";
            this.teacherMailtxt.Size = new System.Drawing.Size(137, 26);
            this.teacherMailtxt.TabIndex = 53;
            // 
            // teacherAddresstxt
            // 
            this.teacherAddresstxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.teacherAddresstxt.Location = new System.Drawing.Point(257, 345);
            this.teacherAddresstxt.Name = "teacherAddresstxt";
            this.teacherAddresstxt.Size = new System.Drawing.Size(137, 26);
            this.teacherAddresstxt.TabIndex = 52;
            // 
            // teacherContacttxt
            // 
            this.teacherContacttxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.teacherContacttxt.Location = new System.Drawing.Point(257, 290);
            this.teacherContacttxt.Name = "teacherContacttxt";
            this.teacherContacttxt.Size = new System.Drawing.Size(137, 26);
            this.teacherContacttxt.TabIndex = 51;
            // 
            // teacherNICtxt
            // 
            this.teacherNICtxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.teacherNICtxt.Location = new System.Drawing.Point(257, 235);
            this.teacherNICtxt.Name = "teacherNICtxt";
            this.teacherNICtxt.Size = new System.Drawing.Size(137, 26);
            this.teacherNICtxt.TabIndex = 50;
            // 
            // teacherLNametxt
            // 
            this.teacherLNametxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.teacherLNametxt.Location = new System.Drawing.Point(257, 176);
            this.teacherLNametxt.Name = "teacherLNametxt";
            this.teacherLNametxt.Size = new System.Drawing.Size(137, 26);
            this.teacherLNametxt.TabIndex = 49;
            // 
            // teacherFNametxt
            // 
            this.teacherFNametxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.teacherFNametxt.Location = new System.Drawing.Point(257, 118);
            this.teacherFNametxt.Name = "teacherFNametxt";
            this.teacherFNametxt.Size = new System.Drawing.Size(137, 26);
            this.teacherFNametxt.TabIndex = 48;
            // 
            // teacherIdtxt
            // 
            this.teacherIdtxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.teacherIdtxt.Location = new System.Drawing.Point(257, 66);
            this.teacherIdtxt.Name = "teacherIdtxt";
            this.teacherIdtxt.Size = new System.Drawing.Size(61, 26);
            this.teacherIdtxt.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(80, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 22);
            this.label6.TabIndex = 46;
            this.label6.Text = "Contact";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(81, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 22);
            this.label7.TabIndex = 45;
            this.label7.Text = "NIC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGreen;
            this.label8.Location = new System.Drawing.Point(81, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 22);
            this.label8.TabIndex = 44;
            this.label8.Text = "Last Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGreen;
            this.label9.Location = new System.Drawing.Point(80, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 22);
            this.label9.TabIndex = 43;
            this.label9.Text = "First Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkGreen;
            this.label10.Location = new System.Drawing.Point(80, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 22);
            this.label10.TabIndex = 42;
            this.label10.Text = "Teacher Id";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEmployeePayment);
            this.tabPage2.Controls.Add(this.txtPaymentAmount);
            this.tabPage2.Controls.Add(this.txtPaymentYear);
            this.tabPage2.Controls.Add(this.txtPaymentMonth);
            this.tabPage2.Controls.Add(this.txtPaymentTeaId);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Font = new System.Drawing.Font("Stencil", 14.25F);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(894, 566);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Payment";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEmployeePayment
            // 
            this.btnEmployeePayment.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEmployeePayment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEmployeePayment.FlatAppearance.BorderSize = 2;
            this.btnEmployeePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeePayment.ForeColor = System.Drawing.Color.White;
            this.btnEmployeePayment.Location = new System.Drawing.Point(265, 357);
            this.btnEmployeePayment.Name = "btnEmployeePayment";
            this.btnEmployeePayment.Size = new System.Drawing.Size(194, 37);
            this.btnEmployeePayment.TabIndex = 42;
            this.btnEmployeePayment.Text = "Save";
            this.btnEmployeePayment.UseVisualStyleBackColor = false;
            this.btnEmployeePayment.Click += new System.EventHandler(this.employeePaymentSave);
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.txtPaymentAmount.Location = new System.Drawing.Point(265, 274);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(137, 26);
            this.txtPaymentAmount.TabIndex = 41;
            // 
            // txtPaymentYear
            // 
            this.txtPaymentYear.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.txtPaymentYear.Location = new System.Drawing.Point(265, 198);
            this.txtPaymentYear.Name = "txtPaymentYear";
            this.txtPaymentYear.Size = new System.Drawing.Size(137, 26);
            this.txtPaymentYear.TabIndex = 39;
            // 
            // txtPaymentMonth
            // 
            this.txtPaymentMonth.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.txtPaymentMonth.Location = new System.Drawing.Point(265, 129);
            this.txtPaymentMonth.Name = "txtPaymentMonth";
            this.txtPaymentMonth.Size = new System.Drawing.Size(137, 26);
            this.txtPaymentMonth.TabIndex = 38;
            // 
            // txtPaymentTeaId
            // 
            this.txtPaymentTeaId.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.txtPaymentTeaId.Location = new System.Drawing.Point(265, 64);
            this.txtPaymentTeaId.Name = "txtPaymentTeaId";
            this.txtPaymentTeaId.Size = new System.Drawing.Size(61, 26);
            this.txtPaymentTeaId.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(88, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 22);
            this.label5.TabIndex = 36;
            this.label5.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(88, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 34;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(88, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "Month";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(88, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Teacher Id";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listTeacherData);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(894, 566);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listTeacherData
            // 
            this.listTeacherData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7});
            this.listTeacherData.Font = new System.Drawing.Font("Adobe Hebrew", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTeacherData.GridLines = true;
            this.listTeacherData.Location = new System.Drawing.Point(6, 20);
            this.listTeacherData.Name = "listTeacherData";
            this.listTeacherData.Size = new System.Drawing.Size(848, 477);
            this.listTeacherData.TabIndex = 2;
            this.listTeacherData.UseCompatibleStateImageBehavior = false;
            this.listTeacherData.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 71;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 162;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nic";
            this.columnHeader3.Width = 136;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Contact";
            this.columnHeader5.Width = 152;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Address";
            this.columnHeader4.Width = 257;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "E-mail";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Subject";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 714);
            this.panel1.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Image = ((System.Drawing.Image)(resources.GetObject("label18.Image")));
            this.label18.Location = new System.Drawing.Point(640, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 60);
            this.label18.TabIndex = 78;
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Image = ((System.Drawing.Image)(resources.GetObject("label17.Image")));
            this.label17.Location = new System.Drawing.Point(847, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 60);
            this.label17.TabIndex = 77;
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Image = ((System.Drawing.Image)(resources.GetObject("label16.Image")));
            this.label16.Location = new System.Drawing.Point(778, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 60);
            this.label16.TabIndex = 76;
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Image = ((System.Drawing.Image)(resources.GetObject("label15.Image")));
            this.label15.Location = new System.Drawing.Point(709, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 60);
            this.label15.TabIndex = 75;
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(3, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 630);
            this.panel2.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 44);
            this.label4.TabIndex = 63;
            this.label4.Text = "Teacher";
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 711);
            this.Controls.Add(this.panel1);
            this.Name = "Teacher";
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.Teacher_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox teacherMailtxt;
        private TextBox teacherAddresstxt;
        private TextBox teacherContacttxt;
        private TextBox teacherNICtxt;
        private TextBox teacherLNametxt;
        private TextBox teacherFNametxt;
        private TextBox teacherIdtxt;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TabPage tabPage2;
        private Button btnEmployeePayment;
        private TextBox txtPaymentAmount;
        private TextBox txtPaymentYear;
        private TextBox txtPaymentMonth;
        private TextBox txtPaymentTeaId;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox teacherSubjectcmd;
        private Button button3;
        private Button button2;
        private Button btnTeacherUpdate;
        private Button btnTeacherSave;
        private TabPage tabPage3;
        private Panel panel1;
        private Label label4;
        private RadioButton rbnNICV;
        private RadioButton rbnNICX;
        private Label label14;
        private TextBox txtLastId;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Panel panel2;
        private ListView listTeacherData;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}