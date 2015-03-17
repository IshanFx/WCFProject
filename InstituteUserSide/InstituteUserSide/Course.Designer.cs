namespace InstituteUserSide
{
    partial class Course
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
            this.CosSearchBtn = new System.Windows.Forms.Button();
            this.couTeaDetails = new System.Windows.Forms.DataGridView();
            this.CosClearbtn = new System.Windows.Forms.Button();
            this.CosUpdatebtn = new System.Windows.Forms.Button();
            this.CosSavebtn = new System.Windows.Forms.Button();
            this.txtBatch = new System.Windows.Forms.TextBox();
            this.txtTechid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EntimeCombo = new System.Windows.Forms.ComboBox();
            this.StTimecombo = new System.Windows.Forms.ComboBox();
            this.Daycombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCoursid = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CoursDataGrid = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.couTeaDetails)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoursDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(12, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(897, 534);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CosSearchBtn);
            this.tabPage1.Controls.Add(this.couTeaDetails);
            this.tabPage1.Controls.Add(this.CosClearbtn);
            this.tabPage1.Controls.Add(this.CosUpdatebtn);
            this.tabPage1.Controls.Add(this.CosSavebtn);
            this.tabPage1.Controls.Add(this.txtBatch);
            this.tabPage1.Controls.Add(this.txtTechid);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.EntimeCombo);
            this.tabPage1.Controls.Add(this.StTimecombo);
            this.tabPage1.Controls.Add(this.Daycombo);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtCoursid);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(889, 497);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Register";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CosSearchBtn
            // 
            this.CosSearchBtn.Location = new System.Drawing.Point(351, 108);
            this.CosSearchBtn.Name = "CosSearchBtn";
            this.CosSearchBtn.Size = new System.Drawing.Size(99, 29);
            this.CosSearchBtn.TabIndex = 25;
            this.CosSearchBtn.Text = "Search";
            this.CosSearchBtn.UseVisualStyleBackColor = true;
            this.CosSearchBtn.Click += new System.EventHandler(this.CosSearchBtn_Click);
            // 
            // couTeaDetails
            // 
            this.couTeaDetails.AllowUserToAddRows = false;
            this.couTeaDetails.AllowUserToDeleteRows = false;
            this.couTeaDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.couTeaDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.couTeaDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.couTeaDetails.Location = new System.Drawing.Point(484, 50);
            this.couTeaDetails.Name = "couTeaDetails";
            this.couTeaDetails.ReadOnly = true;
            this.couTeaDetails.Size = new System.Drawing.Size(366, 283);
            this.couTeaDetails.TabIndex = 24;
            this.couTeaDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.couTeaDetails_CellClick);
            // 
            // CosClearbtn
            // 
            this.CosClearbtn.Location = new System.Drawing.Point(728, 436);
            this.CosClearbtn.Name = "CosClearbtn";
            this.CosClearbtn.Size = new System.Drawing.Size(135, 37);
            this.CosClearbtn.TabIndex = 23;
            this.CosClearbtn.Text = "Clear";
            this.CosClearbtn.UseVisualStyleBackColor = true;
            this.CosClearbtn.Click += new System.EventHandler(this.CosClearbtn_Click);
            // 
            // CosUpdatebtn
            // 
            this.CosUpdatebtn.Location = new System.Drawing.Point(573, 436);
            this.CosUpdatebtn.Name = "CosUpdatebtn";
            this.CosUpdatebtn.Size = new System.Drawing.Size(135, 37);
            this.CosUpdatebtn.TabIndex = 22;
            this.CosUpdatebtn.Text = "Update";
            this.CosUpdatebtn.UseVisualStyleBackColor = true;
            this.CosUpdatebtn.Click += new System.EventHandler(this.CosUpdatebtn_Click);
            // 
            // CosSavebtn
            // 
            this.CosSavebtn.Location = new System.Drawing.Point(414, 436);
            this.CosSavebtn.Name = "CosSavebtn";
            this.CosSavebtn.Size = new System.Drawing.Size(135, 37);
            this.CosSavebtn.TabIndex = 21;
            this.CosSavebtn.Text = "Save";
            this.CosSavebtn.UseVisualStyleBackColor = true;
            this.CosSavebtn.Click += new System.EventHandler(this.CosSavebtn_Click);
            // 
            // txtBatch
            // 
            this.txtBatch.Location = new System.Drawing.Point(216, 380);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.Size = new System.Drawing.Size(146, 29);
            this.txtBatch.TabIndex = 20;
            // 
            // txtTechid
            // 
            this.txtTechid.Location = new System.Drawing.Point(216, 47);
            this.txtTechid.Name = "txtTechid";
            this.txtTechid.Size = new System.Drawing.Size(100, 29);
            this.txtTechid.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Teacher ID";
            // 
            // EntimeCombo
            // 
            this.EntimeCombo.FormattingEnabled = true;
            this.EntimeCombo.Items.AddRange(new object[] {
            "8.00 AM",
            "10.00 AM",
            "12.00 Am",
            "2.00 PM",
            "4.00 PM",
            "6.00 PM"});
            this.EntimeCombo.Location = new System.Drawing.Point(216, 307);
            this.EntimeCombo.Name = "EntimeCombo";
            this.EntimeCombo.Size = new System.Drawing.Size(146, 32);
            this.EntimeCombo.TabIndex = 17;
            // 
            // StTimecombo
            // 
            this.StTimecombo.FormattingEnabled = true;
            this.StTimecombo.Items.AddRange(new object[] {
            "8.00 AM",
            "10.00 AM",
            "12.00 Am",
            "2.00 PM",
            "4.00 PM",
            "6.00 PM"});
            this.StTimecombo.Location = new System.Drawing.Point(216, 238);
            this.StTimecombo.Name = "StTimecombo";
            this.StTimecombo.Size = new System.Drawing.Size(146, 32);
            this.StTimecombo.TabIndex = 16;
            // 
            // Daycombo
            // 
            this.Daycombo.FormattingEnabled = true;
            this.Daycombo.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.Daycombo.Location = new System.Drawing.Point(216, 171);
            this.Daycombo.Name = "Daycombo";
            this.Daycombo.Size = new System.Drawing.Size(146, 32);
            this.Daycombo.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Batch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "End Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Start Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Course Id";
            // 
            // txtCoursid
            // 
            this.txtCoursid.Location = new System.Drawing.Point(216, 108);
            this.txtCoursid.Name = "txtCoursid";
            this.txtCoursid.Size = new System.Drawing.Size(100, 29);
            this.txtCoursid.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CoursDataGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(889, 497);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CoursDataGrid
            // 
            this.CoursDataGrid.AllowUserToAddRows = false;
            this.CoursDataGrid.AllowUserToDeleteRows = false;
            this.CoursDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CoursDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CoursDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoursDataGrid.Location = new System.Drawing.Point(23, 25);
            this.CoursDataGrid.Name = "CoursDataGrid";
            this.CoursDataGrid.ReadOnly = true;
            this.CoursDataGrid.Size = new System.Drawing.Size(842, 452);
            this.CoursDataGrid.TabIndex = 0;
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 622);
            this.Controls.Add(this.tabControl1);
            this.Name = "Course";
            this.Text = "Course";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.couTeaDetails)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CoursDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtCoursid;
        private System.Windows.Forms.Button CosClearbtn;
        private System.Windows.Forms.Button CosUpdatebtn;
        private System.Windows.Forms.Button CosSavebtn;
        private System.Windows.Forms.TextBox txtBatch;
        private System.Windows.Forms.TextBox txtTechid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox EntimeCombo;
        private System.Windows.Forms.ComboBox StTimecombo;
        private System.Windows.Forms.ComboBox Daycombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView CoursDataGrid;
        private System.Windows.Forms.DataGridView couTeaDetails;
        private System.Windows.Forms.Button CosSearchBtn;
    }
}