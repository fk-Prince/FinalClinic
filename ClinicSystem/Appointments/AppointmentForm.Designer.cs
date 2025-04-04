﻿namespace ClinicSystem
{
    partial class AppointmentForm
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
            this.addAppointmentB = new System.Windows.Forms.Button();
            this.allAppointmentB = new System.Windows.Forms.Button();
            this.rescheduleB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.appointmentPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // addAppointmentB
            // 
            this.addAppointmentB.BackColor = System.Drawing.Color.White;
            this.addAppointmentB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addAppointmentB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAppointmentB.Location = new System.Drawing.Point(219, 12);
            this.addAppointmentB.Name = "addAppointmentB";
            this.addAppointmentB.Size = new System.Drawing.Size(170, 42);
            this.addAppointmentB.TabIndex = 10066;
            this.addAppointmentB.Text = "Add Appointment";
            this.addAppointmentB.UseVisualStyleBackColor = false;
            this.addAppointmentB.Click += new System.EventHandler(this.addAppointmentB_Click);
            this.addAppointmentB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClicked);
            // 
            // allAppointmentB
            // 
            this.allAppointmentB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.allAppointmentB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.allAppointmentB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allAppointmentB.Location = new System.Drawing.Point(12, 12);
            this.allAppointmentB.Name = "allAppointmentB";
            this.allAppointmentB.Size = new System.Drawing.Size(170, 42);
            this.allAppointmentB.TabIndex = 10065;
            this.allAppointmentB.Text = "All Appointments";
            this.allAppointmentB.UseVisualStyleBackColor = false;
            this.allAppointmentB.Click += new System.EventHandler(this.allAppointmentB_Click);
            this.allAppointmentB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClicked);
            // 
            // rescheduleB
            // 
            this.rescheduleB.BackColor = System.Drawing.Color.White;
            this.rescheduleB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rescheduleB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rescheduleB.Location = new System.Drawing.Point(425, 12);
            this.rescheduleB.Name = "rescheduleB";
            this.rescheduleB.Size = new System.Drawing.Size(170, 42);
            this.rescheduleB.TabIndex = 10069;
            this.rescheduleB.Text = "Re-Schedule";
            this.rescheduleB.UseVisualStyleBackColor = false;
            this.rescheduleB.Click += new System.EventHandler(this.rescheduleB_Click);
            this.rescheduleB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(120)))));
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 10);
            this.panel1.TabIndex = 10067;
            // 
            // appointmentPanel
            // 
            this.appointmentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.appointmentPanel.Location = new System.Drawing.Point(0, 65);
            this.appointmentPanel.Name = "appointmentPanel";
            this.appointmentPanel.Size = new System.Drawing.Size(1080, 654);
            this.appointmentPanel.TabIndex = 10068;
            // 
            // AppointmentForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(1080, 719);
            this.Controls.Add(this.rescheduleB);
            this.Controls.Add(this.appointmentPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addAppointmentB);
            this.Controls.Add(this.allAppointmentB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppointmentForm";
            this.Text = "ab";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addAppointmentB;
        private System.Windows.Forms.Button allAppointmentB;
        private System.Windows.Forms.Button rescheduleB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel appointmentPanel;
    }
}