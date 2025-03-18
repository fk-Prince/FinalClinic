namespace ClinicSystem.Doctors
{
    partial class DoctorMainForm
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
            this.doctorpanel = new System.Windows.Forms.Panel();
            this.addDoctorB = new System.Windows.Forms.Button();
            this.viewDoctorB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(120)))));
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 2);
            this.panel1.TabIndex = 107;
            // 
            // doctorpanel
            // 
            this.doctorpanel.Location = new System.Drawing.Point(0, 68);
            this.doctorpanel.Name = "doctorpanel";
            this.doctorpanel.Size = new System.Drawing.Size(1080, 651);
            this.doctorpanel.TabIndex = 106;
            // 
            // addDoctorB
            // 
            this.addDoctorB.BackColor = System.Drawing.Color.White;
            this.addDoctorB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDoctorB.Location = new System.Drawing.Point(156, 12);
            this.addDoctorB.Name = "addDoctorB";
            this.addDoctorB.Size = new System.Drawing.Size(124, 42);
            this.addDoctorB.TabIndex = 105;
            this.addDoctorB.Text = "Add Doctors";
            this.addDoctorB.UseVisualStyleBackColor = false;
            this.addDoctorB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClicked);
            // 
            // viewDoctorB
            // 
            this.viewDoctorB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.viewDoctorB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewDoctorB.Location = new System.Drawing.Point(12, 12);
            this.viewDoctorB.Name = "viewDoctorB";
            this.viewDoctorB.Size = new System.Drawing.Size(124, 42);
            this.viewDoctorB.TabIndex = 104;
            this.viewDoctorB.Text = "View Doctors";
            this.viewDoctorB.UseVisualStyleBackColor = false;
            this.viewDoctorB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClicked);
            // 
            // DoctorMainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(163)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1080, 719);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.doctorpanel);
            this.Controls.Add(this.addDoctorB);
            this.Controls.Add(this.viewDoctorB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorMainForm";
            this.Text = "1080, 719";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel doctorpanel;
        private System.Windows.Forms.Button addDoctorB;
        private System.Windows.Forms.Button viewDoctorB;
    }
}