namespace ClinicSystem
{
    partial class FormPatient
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
            this.addPatient = new System.Windows.Forms.Button();
            this.viewPatient = new System.Windows.Forms.Button();
            this.patientPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPatient
            // 
            this.addPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.addPatient.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPatient.Location = new System.Drawing.Point(12, 12);
            this.addPatient.Name = "addPatient";
            this.addPatient.Size = new System.Drawing.Size(124, 42);
            this.addPatient.TabIndex = 0;
            this.addPatient.Text = "Add Patient";
            this.addPatient.UseVisualStyleBackColor = false;
            this.addPatient.Click += new System.EventHandler(this.mouseClicked);
            this.addPatient.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addPatientClicked);
            // 
            // viewPatient
            // 
            this.viewPatient.BackColor = System.Drawing.Color.White;
            this.viewPatient.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.viewPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewPatient.Location = new System.Drawing.Point(156, 12);
            this.viewPatient.Name = "viewPatient";
            this.viewPatient.Size = new System.Drawing.Size(124, 42);
            this.viewPatient.TabIndex = 1;
            this.viewPatient.Text = "View Patients";
            this.viewPatient.UseVisualStyleBackColor = false;
            this.viewPatient.Click += new System.EventHandler(this.mouseClicked);
            this.viewPatient.MouseClick += new System.Windows.Forms.MouseEventHandler(this.viewPatientClicked);
            // 
            // patientPanel
            // 
            this.patientPanel.Location = new System.Drawing.Point(0, 0);
            this.patientPanel.Name = "patientPanel";
            this.patientPanel.Size = new System.Drawing.Size(1080, 655);
            this.patientPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(120)))));
            this.panel1.Controls.Add(this.patientPanel);
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 2);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 653);
            this.panel2.TabIndex = 4;
            // 
            // FormPatient
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(1080, 719);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.viewPatient);
            this.Controls.Add(this.addPatient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPatient";
            this.Text = "PatientForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addPatient;
        private System.Windows.Forms.Button viewPatient;
        private System.Windows.Forms.Panel patientPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}