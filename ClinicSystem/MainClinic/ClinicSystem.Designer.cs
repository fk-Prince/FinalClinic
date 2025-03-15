namespace ClinicSystem
{
    partial class ClinicSystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Date = new System.Windows.Forms.Label();
            this.Clock = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.appointmentButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.AddPatientS = new System.Windows.Forms.Button();
            this.DashboardS = new System.Windows.Forms.Button();
            this.dateTimer = new System.Windows.Forms.Timer(this.components);
            this.hoursTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.mainpanel);
            this.panel1.Controls.Add(this.label1);
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
            this.mainpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainpanel.AutoSize = true;
            this.mainpanel.Location = new System.Drawing.Point(226, 23);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1061, 684);
            this.mainpanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1278, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.panel2.Controls.Add(this.Date);
            this.panel2.Controls.Add(this.Clock);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 718);
            this.panel2.TabIndex = 0;
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
            this.Clock.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock.ForeColor = System.Drawing.Color.Black;
            this.Clock.Location = new System.Drawing.Point(21, 8);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(0, 40);
            this.Clock.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.appointmentButton);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.AddPatientS);
            this.panel3.Controls.Add(this.DashboardS);
            this.panel3.Location = new System.Drawing.Point(20, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 394);
            this.panel3.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(19, 312);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(139, 46);
            this.button8.TabIndex = 10000;
            this.button8.TabStop = false;
            this.button8.Text = "Clinic History";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClicked);
            // 
            // appointmentButton
            // 
            this.appointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appointmentButton.Location = new System.Drawing.Point(19, 266);
            this.appointmentButton.Name = "appointmentButton";
            this.appointmentButton.Size = new System.Drawing.Size(139, 46);
            this.appointmentButton.TabIndex = 10000;
            this.appointmentButton.TabStop = false;
            this.appointmentButton.Text = "Appointments";
            this.appointmentButton.UseVisualStyleBackColor = true;
            this.appointmentButton.Click += new System.EventHandler(this.appointmentButton_Click);
            this.appointmentButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClicked);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(19, 220);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 46);
            this.button6.TabIndex = 10000;
            this.button6.TabStop = false;
            this.button6.Text = "Rooms";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.roomClicked);
            this.button6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClicked);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(19, 174);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 46);
            this.button5.TabIndex = 10000;
            this.button5.TabStop = false;
            this.button5.Text = "Doctors";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClicked);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(19, 128);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 46);
            this.button4.TabIndex = 10000;
            this.button4.TabStop = false;
            this.button4.Text = "Operations";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.OperationClicked);
            this.button4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClicked);
            // 
            // AddPatientS
            // 
            this.AddPatientS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPatientS.Location = new System.Drawing.Point(19, 82);
            this.AddPatientS.Name = "AddPatientS";
            this.AddPatientS.Size = new System.Drawing.Size(139, 46);
            this.AddPatientS.TabIndex = 10000;
            this.AddPatientS.TabStop = false;
            this.AddPatientS.Text = "Patient";
            this.AddPatientS.UseVisualStyleBackColor = true;
            this.AddPatientS.Click += new System.EventHandler(this.AddPatientS_Click_1);
            this.AddPatientS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClicked);
            // 
            // DashboardS
            // 
            this.DashboardS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.DashboardS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardS.Location = new System.Drawing.Point(19, 36);
            this.DashboardS.Name = "DashboardS";
            this.DashboardS.Size = new System.Drawing.Size(139, 46);
            this.DashboardS.TabIndex = 10000;
            this.DashboardS.TabStop = false;
            this.DashboardS.Text = "Dashboard";
            this.DashboardS.UseVisualStyleBackColor = false;
            this.DashboardS.Click += new System.EventHandler(this.dashboardClicked);
            this.DashboardS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClicked);
            // 
            // dateTimer
            // 
            this.dateTimer.Enabled = true;
            this.dateTimer.Interval = 43200;
            this.dateTimer.Tick += new System.EventHandler(this.dateTimer_Tick);
            // 
            // hoursTimer
            // 
            this.hoursTimer.Enabled = true;
            this.hoursTimer.Interval = 1000;
            this.hoursTimer.Tick += new System.EventHandler(this.hoursTimer_Tick);
            // 
            // ClinicSystem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1300, 720);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClinicSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClinicSystem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Clock;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button appointmentButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button AddPatientS;
        private System.Windows.Forms.Button DashboardS;
        private System.Windows.Forms.Timer dateTimer;
        private System.Windows.Forms.Timer hoursTimer;
    }
}