namespace ClinicSystem.Appointments
{
    partial class RescheduleForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateAppointmentB = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbOname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.comboEnd = new System.Windows.Forms.ComboBox();
            this.tbEnd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboStart = new System.Windows.Forms.ComboBox();
            this.tbStart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateSchedulePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbPname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboAppointment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.doctorL = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.updateAppointmentB);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(192, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 606);
            this.panel1.TabIndex = 0;
            // 
            // updateAppointmentB
            // 
            this.updateAppointmentB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.updateAppointmentB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateAppointmentB.Location = new System.Drawing.Point(194, 482);
            this.updateAppointmentB.Name = "updateAppointmentB";
            this.updateAppointmentB.Size = new System.Drawing.Size(284, 53);
            this.updateAppointmentB.TabIndex = 10088;
            this.updateAppointmentB.Text = "Update";
            this.updateAppointmentB.UseVisualStyleBackColor = false;
            this.updateAppointmentB.Click += new System.EventHandler(this.updateAppointmentB_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tbOname);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(66, 265);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(535, 36);
            this.panel7.TabIndex = 10085;
            // 
            // tbOname
            // 
            this.tbOname.Location = new System.Drawing.Point(141, 4);
            this.tbOname.Name = "tbOname";
            this.tbOname.ReadOnly = true;
            this.tbOname.Size = new System.Drawing.Size(389, 27);
            this.tbOname.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Operation Name";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.comboEnd);
            this.panel6.Controls.Add(this.tbEnd);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(66, 391);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(535, 36);
            this.panel6.TabIndex = 10087;
            // 
            // comboEnd
            // 
            this.comboEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEnd.Enabled = false;
            this.comboEnd.FormattingEnabled = true;
            this.comboEnd.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.comboEnd.Location = new System.Drawing.Point(472, 3);
            this.comboEnd.Name = "comboEnd";
            this.comboEnd.Size = new System.Drawing.Size(57, 28);
            this.comboEnd.TabIndex = 4;
            // 
            // tbEnd
            // 
            this.tbEnd.Enabled = false;
            this.tbEnd.Location = new System.Drawing.Point(141, 4);
            this.tbEnd.Name = "tbEnd";
            this.tbEnd.ReadOnly = true;
            this.tbEnd.Size = new System.Drawing.Size(325, 27);
            this.tbEnd.TabIndex = 2;
            this.tbEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "End-Time";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.comboStart);
            this.panel5.Controls.Add(this.tbStart);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(66, 349);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(535, 36);
            this.panel5.TabIndex = 10086;
            // 
            // comboStart
            // 
            this.comboStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStart.FormattingEnabled = true;
            this.comboStart.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.comboStart.Location = new System.Drawing.Point(472, 3);
            this.comboStart.Name = "comboStart";
            this.comboStart.Size = new System.Drawing.Size(57, 28);
            this.comboStart.TabIndex = 3;
            this.comboStart.SelectedIndexChanged += new System.EventHandler(this.comboStart_SelectedIndexChanged);
            // 
            // tbStart
            // 
            this.tbStart.Location = new System.Drawing.Point(141, 4);
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(325, 27);
            this.tbStart.TabIndex = 2;
            this.tbStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbStart.TextChanged += new System.EventHandler(this.tbStart_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Start Time";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dateSchedulePicker);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(66, 307);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(535, 36);
            this.panel4.TabIndex = 10085;
            // 
            // dateSchedulePicker
            // 
            this.dateSchedulePicker.Location = new System.Drawing.Point(141, 5);
            this.dateSchedulePicker.Name = "dateSchedulePicker";
            this.dateSchedulePicker.Size = new System.Drawing.Size(389, 27);
            this.dateSchedulePicker.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Date-Scheduled";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbPname);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(66, 223);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(535, 36);
            this.panel3.TabIndex = 10084;
            // 
            // tbPname
            // 
            this.tbPname.Location = new System.Drawing.Point(141, 4);
            this.tbPname.Name = "tbPname";
            this.tbPname.ReadOnly = true;
            this.tbPname.Size = new System.Drawing.Size(389, 27);
            this.tbPname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Patient Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboAppointment);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 36);
            this.panel2.TabIndex = 10083;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Appointment No.";
            // 
            // comboAppointment
            // 
            this.comboAppointment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAppointment.FormattingEnabled = true;
            this.comboAppointment.Location = new System.Drawing.Point(131, 4);
            this.comboAppointment.Name = "comboAppointment";
            this.comboAppointment.Size = new System.Drawing.Size(105, 28);
            this.comboAppointment.TabIndex = 0;
            this.comboAppointment.SelectedIndexChanged += new System.EventHandler(this.comboAppointment_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 37);
            this.label1.TabIndex = 10082;
            this.label1.Text = "Appointment Details";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.doctorL);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(0, 149);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(535, 36);
            this.panel8.TabIndex = 10085;
            // 
            // doctorL
            // 
            this.doctorL.AutoSize = true;
            this.doctorL.Location = new System.Drawing.Point(117, 8);
            this.doctorL.Name = "doctorL";
            this.doctorL.Size = new System.Drawing.Size(0, 20);
            this.doctorL.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Doctor Name";
            // 
            // RescheduleForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1080, 619);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RescheduleForm";
            this.Text = "RescheduleForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbPname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboAppointment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox tbOname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboEnd;
        private System.Windows.Forms.ComboBox comboStart;
        private System.Windows.Forms.DateTimePicker dateSchedulePicker;
        private System.Windows.Forms.Button updateAppointmentB;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label doctorL;
    }
}