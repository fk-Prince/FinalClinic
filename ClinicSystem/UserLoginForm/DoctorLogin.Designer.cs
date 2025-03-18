namespace ClinicSystem.UserLoginForm
{
    partial class DoctorLogin
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PIN = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DoctorID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.PIN);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.DoctorID);
            this.panel1.Location = new System.Drawing.Point(25, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 155);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(56, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ClinicSystem.Properties.Resources.Lock;
            this.pictureBox3.Location = new System.Drawing.Point(6, 65);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // PIN
            // 
            this.PIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIN.HideSelection = false;
            this.PIN.Location = new System.Drawing.Point(44, 69);
            this.PIN.Name = "PIN";
            this.PIN.Size = new System.Drawing.Size(229, 26);
            this.PIN.TabIndex = 9;
            this.PIN.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ClinicSystem.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(6, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // DoctorID
            // 
            this.DoctorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorID.Location = new System.Drawing.Point(44, 16);
            this.DoctorID.Name = "DoctorID";
            this.DoctorID.Size = new System.Drawing.Size(229, 26);
            this.DoctorID.TabIndex = 8;
            // 
            // DoctorLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(163)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(333, 191);
            this.Controls.Add(this.panel1);
            this.Name = "DoctorLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox PIN;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox DoctorID;
        private System.Windows.Forms.Button button1;
    }
}