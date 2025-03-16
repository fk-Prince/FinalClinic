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
            this.appointmentPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addAppointmentB = new System.Windows.Forms.Button();
            this.allAppointmentB = new System.Windows.Forms.Button();
            this.rescheduleB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // appointmentPanel
            // 
            this.appointmentPanel.Location = new System.Drawing.Point(11, 82);
            this.appointmentPanel.Name = "appointmentPanel";
            this.appointmentPanel.Size = new System.Drawing.Size(1057, 591);
            this.appointmentPanel.TabIndex = 10068;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 2);
            this.panel1.TabIndex = 10067;
            // 
            // addAppointmentB
            // 
            this.addAppointmentB.BackColor = System.Drawing.Color.White;
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
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1057, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 10070;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // AppointmentForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1080, 684);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rescheduleB);
            this.Controls.Add(this.appointmentPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addAppointmentB);
            this.Controls.Add(this.allAppointmentB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppointmentForm";
            this.Text = "ab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel appointmentPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addAppointmentB;
        private System.Windows.Forms.Button allAppointmentB;
        private System.Windows.Forms.Button rescheduleB;
        private System.Windows.Forms.Label label3;
    }
}