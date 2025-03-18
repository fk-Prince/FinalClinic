namespace ClinicSystem.MainClinic
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Username = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lastMonthTimer = new System.Windows.Forms.Timer(this.components);
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.doctorT = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.lastMonthTotal = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.totalDoctor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(163)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 100);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(987, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 30);
            this.button1.TabIndex = 105;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Username);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(857, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 47);
            this.panel3.TabIndex = 106;
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(163)))), ((int)(((byte)(216)))));
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.White;
            this.Username.Location = new System.Drawing.Point(3, 14);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(164, 20);
            this.Username.TabIndex = 104;
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(173, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 103;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 26.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantum ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ClinicSystem.Properties.Resources.Logo85;
            this.pictureBox1.Location = new System.Drawing.Point(24, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 85);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 34);
            this.label2.TabIndex = 101;
            this.label2.Text = "Care";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(120)))));
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 2);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(163)))), ((int)(((byte)(216)))));
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(91, 166);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(184, 205);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(200)))), ((int)(((byte)(225)))));
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(0, 120);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(183, 91);
            this.panel5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Patient";
            // 
            // lastMonthTimer
            // 
            this.lastMonthTimer.Enabled = true;
            this.lastMonthTimer.Interval = 200;
            this.lastMonthTimer.Tick += new System.EventHandler(this.lastMonthTimer_Tick);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(163)))), ((int)(((byte)(216)))));
            this.panel8.Controls.Add(this.panel7);
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Location = new System.Drawing.Point(91, 438);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(184, 205);
            this.panel8.TabIndex = 4;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(200)))), ((int)(((byte)(225)))));
            this.panel11.Controls.Add(this.label7);
            this.panel11.Location = new System.Drawing.Point(0, 120);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(183, 96);
            this.panel11.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total Doctor";
            // 
            // doctorT
            // 
            this.doctorT.Enabled = true;
            this.doctorT.Interval = 200;
            this.doctorT.Tick += new System.EventHandler(this.doctorT_Tick);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lastMonthTotal);
            this.panel6.Location = new System.Drawing.Point(20, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(147, 110);
            this.panel6.TabIndex = 1;
            // 
            // lastMonthTotal
            // 
            this.lastMonthTotal.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold);
            this.lastMonthTotal.Location = new System.Drawing.Point(10, 11);
            this.lastMonthTotal.Name = "lastMonthTotal";
            this.lastMonthTotal.Size = new System.Drawing.Size(130, 86);
            this.lastMonthTotal.TabIndex = 0;
            this.lastMonthTotal.Text = "0";
            this.lastMonthTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.totalDoctor);
            this.panel7.Location = new System.Drawing.Point(19, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(147, 110);
            this.panel7.TabIndex = 5;
            // 
            // totalDoctor
            // 
            this.totalDoctor.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold);
            this.totalDoctor.Location = new System.Drawing.Point(10, 11);
            this.totalDoctor.Name = "totalDoctor";
            this.totalDoctor.Size = new System.Drawing.Size(130, 86);
            this.totalDoctor.TabIndex = 0;
            this.totalDoctor.Text = "0";
            this.totalDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DashboardForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(184)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1080, 684);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer lastMonthTimer;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer doctorT;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lastMonthTotal;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label totalDoctor;
    }
}