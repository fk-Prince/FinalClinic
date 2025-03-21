﻿namespace ClinicSystem
{
    partial class DoctorClinics
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SchedulesD = new System.Windows.Forms.Button();
            this.ViewPatientD = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.Label();
            this.Clock = new System.Windows.Forms.Label();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.DateTimer = new System.Windows.Forms.Timer(this.components);
            this.Home = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.mainpanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 720);
            this.panel1.TabIndex = 1;
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(200)))), ((int)(((byte)(225)))));
            this.mainpanel.Location = new System.Drawing.Point(220, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1079, 718);
            this.mainpanel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(163)))), ((int)(((byte)(216)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.Date);
            this.panel2.Controls.Add(this.Clock);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 718);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(120)))));
            this.panel4.Location = new System.Drawing.Point(218, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 718);
            this.panel4.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.SchedulesD);
            this.panel3.Controls.Add(this.ViewPatientD);
            this.panel3.Controls.Add(this.Home);
            this.panel3.Location = new System.Drawing.Point(0, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 175);
            this.panel3.TabIndex = 3;
            // 
            // SchedulesD
            // 
            this.SchedulesD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SchedulesD.Image = global::ClinicSystem.Properties.Resources.appointment;
            this.SchedulesD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SchedulesD.Location = new System.Drawing.Point(6, 111);
            this.SchedulesD.Name = "SchedulesD";
            this.SchedulesD.Size = new System.Drawing.Size(206, 46);
            this.SchedulesD.TabIndex = 10000;
            this.SchedulesD.TabStop = false;
            this.SchedulesD.Text = "Appointments";
            this.SchedulesD.UseVisualStyleBackColor = true;
            this.SchedulesD.Click += new System.EventHandler(this.SchedulesD_Click);
            this.SchedulesD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClicked);
            // 
            // ViewPatientD
            // 
            this.ViewPatientD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewPatientD.Image = global::ClinicSystem.Properties.Resources.patient;
            this.ViewPatientD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewPatientD.Location = new System.Drawing.Point(6, 65);
            this.ViewPatientD.Name = "ViewPatientD";
            this.ViewPatientD.Size = new System.Drawing.Size(206, 46);
            this.ViewPatientD.TabIndex = 10000;
            this.ViewPatientD.TabStop = false;
            this.ViewPatientD.Text = "View Patients";
            this.ViewPatientD.UseVisualStyleBackColor = true;
            this.ViewPatientD.Click += new System.EventHandler(this.ViewPatientD_Click);
            this.ViewPatientD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClicked);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.White;
            this.Date.Location = new System.Drawing.Point(54, 46);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(0, 25);
            this.Date.TabIndex = 2;
            // 
            // Clock
            // 
            this.Clock.AutoSize = true;
            this.Clock.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.Clock.ForeColor = System.Drawing.Color.Black;
            this.Clock.Location = new System.Drawing.Point(21, 8);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(0, 40);
            this.Clock.TabIndex = 1;
            // 
            // ClockTimer
            // 
            this.ClockTimer.Enabled = true;
            this.ClockTimer.Interval = 1000;
            this.ClockTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DateTimer
            // 
            this.DateTimer.Enabled = true;
            this.DateTimer.Interval = 72000000;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(163)))), ((int)(((byte)(216)))));
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Image = global::ClinicSystem.Properties.Resources.home;
            this.Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.Location = new System.Drawing.Point(6, 19);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(206, 46);
            this.Home.TabIndex = 10000;
            this.Home.TabStop = false;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            this.Home.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClicked);
            // 
            // DoctorClinics
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1300, 720);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorClinics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorClinic";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Clock;
        private System.Windows.Forms.Timer ClockTimer;
        private System.Windows.Forms.Timer DateTimer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button SchedulesD;
        private System.Windows.Forms.Button ViewPatientD;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel panel4;
    }
}