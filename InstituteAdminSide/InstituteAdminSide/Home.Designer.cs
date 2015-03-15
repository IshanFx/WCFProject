namespace InstituteAdminSide
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.button2 = new System.Windows.Forms.Button();
            this.dateShow = new System.Windows.Forms.Label();
            this.timeShow = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeMenuButton = new System.Windows.Forms.Timer(this.components);
            this.timerMenuButtonMin = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGreen;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Stencil Std", 26.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.LimeGreen;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(429, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(303, 303);
            this.button2.TabIndex = 17;
            this.button2.Text = "Teachers";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.teacherFormShow);
            // 
            // dateShow
            // 
            this.dateShow.BackColor = System.Drawing.Color.White;
            this.dateShow.Font = new System.Drawing.Font("Stencil Std", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateShow.ForeColor = System.Drawing.Color.Maroon;
            this.dateShow.Location = new System.Drawing.Point(802, 611);
            this.dateShow.Name = "dateShow";
            this.dateShow.Size = new System.Drawing.Size(447, 80);
            this.dateShow.TabIndex = 14;
            this.dateShow.Text = "Date";
            this.dateShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeShow
            // 
            this.timeShow.BackColor = System.Drawing.Color.White;
            this.timeShow.Font = new System.Drawing.Font("Stencil Std", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeShow.ForeColor = System.Drawing.Color.Maroon;
            this.timeShow.Location = new System.Drawing.Point(886, 65);
            this.timeShow.Name = "timeShow";
            this.timeShow.Size = new System.Drawing.Size(263, 80);
            this.timeShow.TabIndex = 13;
            this.timeShow.Text = "Time";
            this.timeShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Stencil Std", 26.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Location = new System.Drawing.Point(84, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(659, 46);
            this.label8.TabIndex = 12;
            this.label8.Text = "Institute Of Higher Education";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Stencil Std", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(740, 126);
            this.label1.TabIndex = 11;
            this.label1.Text = "ACME(Admin)";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Sienna;
            this.button5.FlatAppearance.BorderSize = 3;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Stencil Std", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Tomato;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(49, 216);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(303, 303);
            this.button5.TabIndex = 16;
            this.button5.Text = "Employee";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.employeeFormShow);
            this.button5.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
            this.button5.MouseHover += new System.EventHandler(this.button5_MouseHover);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SandyBrown;
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Stencil Std", 26.25F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(793, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(304, 303);
            this.button4.TabIndex = 15;
            this.button4.Text = "Report";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.reportFormShow);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 600);
            this.panel1.TabIndex = 18;
            // 
            // timeMenuButton
            // 
            this.timeMenuButton.Interval = 10;
            this.timeMenuButton.Tick += new System.EventHandler(this.timeMenuButton_Tick);
            // 
            // timerMenuButtonMin
            // 
            this.timerMenuButtonMin.Tick += new System.EventHandler(this.timerMenuButtonMin_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 603);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateShow);
            this.Controls.Add(this.timeShow);
            this.Name = "Home";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label dateShow;
        private System.Windows.Forms.Label timeShow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timeMenuButton;
        private System.Windows.Forms.Timer timerMenuButtonMin;
    }
}