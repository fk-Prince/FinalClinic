namespace ClinicSystem.Main2
{
    partial class DoctorAppointmentForm
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
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioToday = new System.Windows.Forms.RadioButton();
            this.selection = new System.Windows.Forms.RadioButton();
            this.datePickDate = new System.Windows.Forms.DateTimePicker();
            this.allSchedule = new System.Windows.Forms.RadioButton();
            this.monthRadio = new System.Windows.Forms.RadioButton();
            this.weekRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowPanel.Location = new System.Drawing.Point(44, 140);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(991, 515);
            this.flowPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioToday);
            this.panel1.Controls.Add(this.selection);
            this.panel1.Controls.Add(this.datePickDate);
            this.panel1.Controls.Add(this.allSchedule);
            this.panel1.Controls.Add(this.monthRadio);
            this.panel1.Controls.Add(this.weekRadio);
            this.panel1.Location = new System.Drawing.Point(44, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 46);
            this.panel1.TabIndex = 1;
            // 
            // radioToday
            // 
            this.radioToday.AutoSize = true;
            this.radioToday.Checked = true;
            this.radioToday.Location = new System.Drawing.Point(16, 15);
            this.radioToday.Name = "radioToday";
            this.radioToday.Size = new System.Drawing.Size(55, 17);
            this.radioToday.TabIndex = 5;
            this.radioToday.TabStop = true;
            this.radioToday.Text = "Today";
            this.radioToday.UseVisualStyleBackColor = true;
            this.radioToday.CheckedChanged += new System.EventHandler(this.radioToday_Check);
            // 
            // selection
            // 
            this.selection.AutoSize = true;
            this.selection.Location = new System.Drawing.Point(500, 15);
            this.selection.Name = "selection";
            this.selection.Size = new System.Drawing.Size(88, 17);
            this.selection.TabIndex = 4;
            this.selection.Text = "Select a date";
            this.selection.UseVisualStyleBackColor = true;
            this.selection.CheckedChanged += new System.EventHandler(this.x_CheckedChanged);
            // 
            // datePickDate
            // 
            this.datePickDate.Location = new System.Drawing.Point(633, 14);
            this.datePickDate.Name = "datePickDate";
            this.datePickDate.Size = new System.Drawing.Size(234, 20);
            this.datePickDate.TabIndex = 3;
            this.datePickDate.Visible = false;
            this.datePickDate.ValueChanged += new System.EventHandler(this.datePickDate_ValueChanged);
            // 
            // allSchedule
            // 
            this.allSchedule.AutoSize = true;
            this.allSchedule.Location = new System.Drawing.Point(356, 15);
            this.allSchedule.Name = "allSchedule";
            this.allSchedule.Size = new System.Drawing.Size(89, 17);
            this.allSchedule.TabIndex = 2;
            this.allSchedule.Text = "All Schedules";
            this.allSchedule.UseVisualStyleBackColor = true;
            this.allSchedule.CheckedChanged += new System.EventHandler(this.allScheduleRadio_Check);
            // 
            // monthRadio
            // 
            this.monthRadio.AutoSize = true;
            this.monthRadio.Location = new System.Drawing.Point(239, 15);
            this.monthRadio.Name = "monthRadio";
            this.monthRadio.Size = new System.Drawing.Size(78, 17);
            this.monthRadio.TabIndex = 1;
            this.monthRadio.Text = "This Month";
            this.monthRadio.UseVisualStyleBackColor = true;
            this.monthRadio.CheckedChanged += new System.EventHandler(this.monthRadio_Check);
            // 
            // weekRadio
            // 
            this.weekRadio.AutoSize = true;
            this.weekRadio.Location = new System.Drawing.Point(116, 15);
            this.weekRadio.Name = "weekRadio";
            this.weekRadio.Size = new System.Drawing.Size(77, 17);
            this.weekRadio.TabIndex = 0;
            this.weekRadio.Text = "This Week";
            this.weekRadio.UseVisualStyleBackColor = true;
            this.weekRadio.CheckedChanged += new System.EventHandler(this.weekRadio_Check);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Appointments";
            // 
            // DoctorAppointmentForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1079, 683);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorAppointmentForm";
            this.Text = "DoctorScheduleForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton weekRadio;
        private System.Windows.Forms.RadioButton monthRadio;
        private System.Windows.Forms.DateTimePicker datePickDate;
        private System.Windows.Forms.RadioButton allSchedule;
        private System.Windows.Forms.RadioButton selection;
        private System.Windows.Forms.RadioButton radioToday;
        private System.Windows.Forms.Label label1;
    }
}