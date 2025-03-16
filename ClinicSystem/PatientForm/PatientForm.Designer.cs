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
            this.label3 = new System.Windows.Forms.Label();
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
            this.patientPanel.Location = new System.Drawing.Point(12, 74);
            this.patientPanel.Name = "patientPanel";
            this.patientPanel.Size = new System.Drawing.Size(1056, 598);
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
            this.label3.TabIndex = 103;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FormPatient
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1080, 684);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.patientPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addPatient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPatient";
            this.Text = "PatientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPatient;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel patientPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}