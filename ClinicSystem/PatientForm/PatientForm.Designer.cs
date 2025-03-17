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
            this.button2 = new System.Windows.Forms.Button();
            this.patientPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // addPatient
            // 
            this.addPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(156, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "View Patients";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.mouseClicked);
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.viewPatientClicked);
            // 
            // patientPanel
            // 
            this.patientPanel.Location = new System.Drawing.Point(0, 66);
            this.patientPanel.Name = "patientPanel";
            this.patientPanel.Size = new System.Drawing.Size(1080, 655);
            this.patientPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 2);
            this.panel1.TabIndex = 3;
            // 
            // FormPatient
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1080, 719);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.patientPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addPatient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPatient";
            this.Text = "PatientForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addPatient;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel patientPanel;
        private System.Windows.Forms.Panel panel1;
    }
}