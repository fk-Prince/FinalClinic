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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClinicSystem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.StaffIdentity = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
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
            this.mainpanel = new System.Windows.Forms.Panel();
            this.dateTimer = new System.Windows.Forms.Timer(this.components);
            this.hoursTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.mainpanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 720);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Sitka Text", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(4, 685);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 30);
            this.button1.TabIndex = 109;
            this.button1.Text = "SIGN OUT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.StaffIdentity);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Location = new System.Drawing.Point(0, 636);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 47);
            this.panel5.TabIndex = 108;
            // 
            // StaffIdentity
            // 
            this.StaffIdentity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.StaffIdentity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StaffIdentity.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffIdentity.ForeColor = System.Drawing.Color.White;
            this.StaffIdentity.Location = new System.Drawing.Point(57, 14);
            this.StaffIdentity.Name = "StaffIdentity";
            this.StaffIdentity.ReadOnly = true;
            this.StaffIdentity.Size = new System.Drawing.Size(154, 20);
            this.StaffIdentity.TabIndex = 104;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 44);
            this.pictureBox2.TabIndex = 103;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(120)))));
            this.panel4.Location = new System.Drawing.Point(218, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 718);
            this.panel4.TabIndex = 3;
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
            this.Clock.ForeColor = System.Drawing.Color.White;
            this.Clock.Location = new System.Drawing.Point(21, 8);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(0, 40);
            this.Clock.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.appointmentButton);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.AddPatientS);
            this.panel3.Controls.Add(this.DashboardS);
            this.panel3.Location = new System.Drawing.Point(0, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 319);
            this.panel3.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = global::ClinicSystem.Properties.Resources.clinicrecord;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(-1, 271);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(221, 46);
            this.button8.TabIndex = 10000;
            this.button8.TabStop = false;
            this.button8.Text = "Clinic History";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            this.button8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClicked);
            // 
            // appointmentButton
            // 
            this.appointmentButton.FlatAppearance.BorderSize = 0;
            this.appointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appointmentButton.ForeColor = System.Drawing.Color.White;
            this.appointmentButton.Image = global::ClinicSystem.Properties.Resources.appointment;
            this.appointmentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.appointmentButton.Location = new System.Drawing.Point(-1, 226);
            this.appointmentButton.Name = "appointmentButton";
            this.appointmentButton.Size = new System.Drawing.Size(221, 46);
            this.appointmentButton.TabIndex = 10000;
            this.appointmentButton.TabStop = false;
            this.appointmentButton.Text = "Appointments";
            this.appointmentButton.UseVisualStyleBackColor = true;
            this.appointmentButton.Click += new System.EventHandler(this.appointmentButton_Click);
            this.appointmentButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClicked);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::ClinicSystem.Properties.Resources.rooms;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(-1, 181);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(221, 46);
            this.button6.TabIndex = 10000;
            this.button6.TabStop = false;
            this.button6.Text = "Rooms";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.roomClicked);
            this.button6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClicked);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::ClinicSystem.Properties.Resources.doctor2;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 136);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(220, 46);
            this.button5.TabIndex = 10000;
            this.button5.TabStop = false;
            this.button5.Text = "Doctors";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClicked);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::ClinicSystem.Properties.Resources.operation;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 91);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 46);
            this.button4.TabIndex = 10000;
            this.button4.TabStop = false;
            this.button4.Text = "Operations";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.OperationClicked);
            this.button4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClicked);
            // 
            // AddPatientS
            // 
            this.AddPatientS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.AddPatientS.FlatAppearance.BorderSize = 0;
            this.AddPatientS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPatientS.ForeColor = System.Drawing.Color.White;
            this.AddPatientS.Image = global::ClinicSystem.Properties.Resources.patient;
            this.AddPatientS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddPatientS.Location = new System.Drawing.Point(-1, 46);
            this.AddPatientS.Name = "AddPatientS";
            this.AddPatientS.Size = new System.Drawing.Size(221, 46);
            this.AddPatientS.TabIndex = 10000;
            this.AddPatientS.TabStop = false;
            this.AddPatientS.Text = "Patient";
            this.AddPatientS.UseVisualStyleBackColor = false;
            this.AddPatientS.Click += new System.EventHandler(this.AddPatientS_Click_1);
            this.AddPatientS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClicked);
            // 
            // DashboardS
            // 
            this.DashboardS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.DashboardS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DashboardS.FlatAppearance.BorderSize = 0;
            this.DashboardS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardS.ForeColor = System.Drawing.Color.White;
            this.DashboardS.Image = global::ClinicSystem.Properties.Resources.dashboard;
            this.DashboardS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardS.Location = new System.Drawing.Point(-1, 1);
            this.DashboardS.Name = "DashboardS";
            this.DashboardS.Size = new System.Drawing.Size(219, 46);
            this.DashboardS.TabIndex = 10000;
            this.DashboardS.TabStop = false;
            this.DashboardS.Text = "Dashboard";
            this.DashboardS.UseVisualStyleBackColor = false;
            this.DashboardS.Click += new System.EventHandler(this.dashboardClicked);
            this.DashboardS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClicked);
            // 
            // mainpanel
            // 
            this.mainpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainpanel.AutoSize = true;
            this.mainpanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.mainpanel.Location = new System.Drawing.Point(219, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1080, 719);
            this.mainpanel.TabIndex = 3;
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
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel mainpanel;
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox StaffIdentity;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}