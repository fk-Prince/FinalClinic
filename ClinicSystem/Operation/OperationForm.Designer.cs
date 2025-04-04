namespace ClinicSystem
{
    partial class OperationForm
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
            this.operationFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.addOperationPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboRoomType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.picturePrice = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureDuration = new System.Windows.Forms.PictureBox();
            this.pictureName = new System.Windows.Forms.PictureBox();
            this.pictureCode = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Description = new System.Windows.Forms.Label();
            this.opDescription = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.opDuration = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.opPrice = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.opName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.opCode = new System.Windows.Forms.TextBox();
            this.timerin = new System.Windows.Forms.Timer(this.components);
            this.timerout = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.addOperationPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCode)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // operationFlowPanel
            // 
            this.operationFlowPanel.AutoScroll = true;
            this.operationFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.operationFlowPanel.Location = new System.Drawing.Point(13, 75);
            this.operationFlowPanel.Name = "operationFlowPanel";
            this.operationFlowPanel.Size = new System.Drawing.Size(0, 0);
            this.operationFlowPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(139)))), ((int)(((byte)(189)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(163)))), ((int)(((byte)(216)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(821, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Operation";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.SearchBar);
            this.panel1.Location = new System.Drawing.Point(16, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 49);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search Operation Code / Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ClinicSystem.Properties.Resources.search24;
            this.pictureBox1.Location = new System.Drawing.Point(7, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // SearchBar
            // 
            this.SearchBar.BackColor = System.Drawing.Color.White;
            this.SearchBar.Location = new System.Drawing.Point(40, 24);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(170, 20);
            this.SearchBar.TabIndex = 0;
            this.SearchBar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // flowLayout
            // 
            this.flowLayout.AutoScroll = true;
            this.flowLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.flowLayout.Location = new System.Drawing.Point(0, 114);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Size = new System.Drawing.Size(1080, 601);
            this.flowLayout.TabIndex = 3;
            // 
            // addOperationPanel
            // 
            this.addOperationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.addOperationPanel.Controls.Add(this.panel2);
            this.addOperationPanel.Controls.Add(this.picturePrice);
            this.addOperationPanel.Controls.Add(this.button3);
            this.addOperationPanel.Controls.Add(this.pictureDuration);
            this.addOperationPanel.Controls.Add(this.pictureName);
            this.addOperationPanel.Controls.Add(this.pictureCode);
            this.addOperationPanel.Controls.Add(this.button2);
            this.addOperationPanel.Controls.Add(this.label8);
            this.addOperationPanel.Controls.Add(this.panel8);
            this.addOperationPanel.Controls.Add(this.panel7);
            this.addOperationPanel.Controls.Add(this.panel5);
            this.addOperationPanel.Controls.Add(this.panel4);
            this.addOperationPanel.Controls.Add(this.panel3);
            this.addOperationPanel.Location = new System.Drawing.Point(-463, 114);
            this.addOperationPanel.Name = "addOperationPanel";
            this.addOperationPanel.Size = new System.Drawing.Size(457, 575);
            this.addOperationPanel.TabIndex = 4;
            this.addOperationPanel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.comboRoomType);
            this.panel2.Controls.Add(this.label7);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(35, 290);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 35);
            this.panel2.TabIndex = 5;
            // 
            // comboRoomType
            // 
            this.comboRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRoomType.FormattingEnabled = true;
            this.comboRoomType.Location = new System.Drawing.Point(185, 9);
            this.comboRoomType.Name = "comboRoomType";
            this.comboRoomType.Size = new System.Drawing.Size(204, 21);
            this.comboRoomType.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Available Room Type";
            // 
            // picturePrice
            // 
            this.picturePrice.Location = new System.Drawing.Point(430, 246);
            this.picturePrice.Name = "picturePrice";
            this.picturePrice.Size = new System.Drawing.Size(16, 16);
            this.picturePrice.TabIndex = 12;
            this.picturePrice.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::ClinicSystem.Properties.Resources.back;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(25, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 24);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureDuration
            // 
            this.pictureDuration.Location = new System.Drawing.Point(430, 196);
            this.pictureDuration.Name = "pictureDuration";
            this.pictureDuration.Size = new System.Drawing.Size(16, 16);
            this.pictureDuration.TabIndex = 11;
            this.pictureDuration.TabStop = false;
            // 
            // pictureName
            // 
            this.pictureName.Location = new System.Drawing.Point(431, 144);
            this.pictureName.Name = "pictureName";
            this.pictureName.Size = new System.Drawing.Size(16, 16);
            this.pictureName.TabIndex = 10;
            this.pictureName.TabStop = false;
            // 
            // pictureCode
            // 
            this.pictureCode.Location = new System.Drawing.Point(431, 93);
            this.pictureCode.Name = "pictureCode";
            this.pictureCode.Size = new System.Drawing.Size(16, 16);
            this.pictureCode.TabIndex = 9;
            this.pictureCode.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(139)))), ((int)(((byte)(189)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(163)))), ((int)(((byte)(216)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(143, 494);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "SUBMIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(138, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Operation Details";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.Description);
            this.panel8.Controls.Add(this.opDescription);
            this.panel8.ForeColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(35, 353);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(396, 96);
            this.panel8.TabIndex = 6;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(3, 8);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(60, 13);
            this.Description.TabIndex = 1;
            this.Description.Text = "Description";
            // 
            // opDescription
            // 
            this.opDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opDescription.BackColor = System.Drawing.Color.White;
            this.opDescription.Location = new System.Drawing.Point(185, 5);
            this.opDescription.Multiline = true;
            this.opDescription.Name = "opDescription";
            this.opDescription.Size = new System.Drawing.Size(204, 88);
            this.opDescription.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.opDuration);
            this.panel7.ForeColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(35, 188);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(396, 32);
            this.panel7.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Est. Duration (HH:MM:SS)";
            // 
            // opDuration
            // 
            this.opDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opDuration.BackColor = System.Drawing.Color.White;
            this.opDuration.Location = new System.Drawing.Point(185, 6);
            this.opDuration.Name = "opDuration";
            this.opDuration.Size = new System.Drawing.Size(204, 20);
            this.opDuration.TabIndex = 0;
            this.opDuration.TextChanged += new System.EventHandler(this.opDuration_TextChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.opPrice);
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(35, 239);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(396, 32);
            this.panel5.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Price";
            // 
            // opPrice
            // 
            this.opPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opPrice.BackColor = System.Drawing.Color.White;
            this.opPrice.Location = new System.Drawing.Point(186, 5);
            this.opPrice.Name = "opPrice";
            this.opPrice.Size = new System.Drawing.Size(203, 20);
            this.opPrice.TabIndex = 0;
            this.opPrice.TextChanged += new System.EventHandler(this.opPrice_TextChanged);
            this.opPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.opName);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(35, 137);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(396, 32);
            this.panel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Operation Name";
            // 
            // opName
            // 
            this.opName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opName.BackColor = System.Drawing.Color.White;
            this.opName.Location = new System.Drawing.Point(186, 5);
            this.opName.Name = "opName";
            this.opName.Size = new System.Drawing.Size(203, 20);
            this.opName.TabIndex = 0;
            this.opName.TextChanged += new System.EventHandler(this.opName_TextChanged);
            this.opName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextOnly);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.opCode);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(35, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(396, 32);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operation Code";
            // 
            // opCode
            // 
            this.opCode.BackColor = System.Drawing.Color.White;
            this.opCode.Location = new System.Drawing.Point(185, 5);
            this.opCode.Name = "opCode";
            this.opCode.Size = new System.Drawing.Size(203, 20);
            this.opCode.TabIndex = 0;
            this.opCode.TextChanged += new System.EventHandler(this.opCode_TextChanged);
            // 
            // timerin
            // 
            this.timerin.Interval = 2;
            this.timerin.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerout
            // 
            this.timerout.Interval = 2;
            this.timerout.Tick += new System.EventHandler(this.timerout_Tick);
            // 
            // OperationForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1080, 719);
            this.Controls.Add(this.addOperationPanel);
            this.Controls.Add(this.flowLayout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.operationFlowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OperationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OperationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.addOperationPanel.ResumeLayout(false);
            this.addOperationPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCode)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel operationFlowPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayout;
        private System.Windows.Forms.Panel addOperationPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox opDescription;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox opDuration;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox opPrice;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox opName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox opCode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureName;
        private System.Windows.Forms.PictureBox pictureCode;
        private System.Windows.Forms.PictureBox pictureDuration;
        private System.Windows.Forms.PictureBox picturePrice;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timerin;
        private System.Windows.Forms.Timer timerout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboRoomType;
    }
}