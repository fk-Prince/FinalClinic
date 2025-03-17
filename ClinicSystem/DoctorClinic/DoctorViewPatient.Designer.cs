namespace ClinicSystem
{
    partial class DoctorViewPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorViewPatient));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.PatientList = new System.Windows.Forms.TabPage();
            this.patientGrid = new System.Windows.Forms.DataGridView();
            this.PatientDetails = new System.Windows.Forms.TabPage();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.comboOpNo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.limit = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.datePickerSchedule = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.comboEnd = new System.Windows.Forms.ComboBox();
            this.tbEndTime = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.comboStart = new System.Windows.Forms.ComboBox();
            this.tbStartTime = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.comboOperations = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDiagnosis = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.datePickerBDay = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.RoomNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbPatientId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchPatient = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.PatientList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientGrid)).BeginInit();
            this.PatientDetails.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.PatientList);
            this.tabControl.Controls.Add(this.PatientDetails);
            this.tabControl.Location = new System.Drawing.Point(32, 94);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1006, 562);
            this.tabControl.TabIndex = 1;
            this.tabControl.TabIndexChanged += new System.EventHandler(this.TabChanged);
            // 
            // PatientList
            // 
            this.PatientList.Controls.Add(this.patientGrid);
            this.PatientList.Location = new System.Drawing.Point(4, 22);
            this.PatientList.Name = "PatientList";
            this.PatientList.Padding = new System.Windows.Forms.Padding(3);
            this.PatientList.Size = new System.Drawing.Size(998, 536);
            this.PatientList.TabIndex = 0;
            this.PatientList.Text = "Patient List";
            this.PatientList.UseVisualStyleBackColor = true;
            // 
            // patientGrid
            // 
            this.patientGrid.AllowUserToAddRows = false;
            this.patientGrid.AllowUserToDeleteRows = false;
            this.patientGrid.AllowUserToResizeColumns = false;
            this.patientGrid.AllowUserToResizeRows = false;
            this.patientGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patientGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.patientGrid.ColumnHeadersHeight = 35;
            this.patientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.patientGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.patientGrid.Location = new System.Drawing.Point(3, 3);
            this.patientGrid.MultiSelect = false;
            this.patientGrid.Name = "patientGrid";
            this.patientGrid.ReadOnly = true;
            this.patientGrid.RowHeadersVisible = false;
            this.patientGrid.RowHeadersWidth = 30;
            this.patientGrid.RowTemplate.ReadOnly = true;
            this.patientGrid.Size = new System.Drawing.Size(992, 530);
            this.patientGrid.TabIndex = 1;
            this.patientGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientClicked);
            // 
            // PatientDetails
            // 
            this.PatientDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.PatientDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PatientDetails.Controls.Add(this.panel16);
            this.PatientDetails.Controls.Add(this.panel15);
            this.PatientDetails.Controls.Add(this.limit);
            this.PatientDetails.Controls.Add(this.panel14);
            this.PatientDetails.Controls.Add(this.panel13);
            this.PatientDetails.Controls.Add(this.panel12);
            this.PatientDetails.Controls.Add(this.panel11);
            this.PatientDetails.Controls.Add(this.SaveButton);
            this.PatientDetails.Controls.Add(this.panel10);
            this.PatientDetails.Controls.Add(this.panel9);
            this.PatientDetails.Controls.Add(this.panel8);
            this.PatientDetails.Controls.Add(this.panel7);
            this.PatientDetails.Controls.Add(this.panel6);
            this.PatientDetails.Controls.Add(this.panel5);
            this.PatientDetails.Controls.Add(this.panel4);
            this.PatientDetails.Controls.Add(this.panel3);
            this.PatientDetails.Controls.Add(this.panel2);
            this.PatientDetails.Location = new System.Drawing.Point(4, 22);
            this.PatientDetails.Name = "PatientDetails";
            this.PatientDetails.Padding = new System.Windows.Forms.Padding(3);
            this.PatientDetails.Size = new System.Drawing.Size(998, 536);
            this.PatientDetails.TabIndex = 1;
            this.PatientDetails.Text = "Patient Details";
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Gray;
            this.panel16.Location = new System.Drawing.Point(575, 18);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(2, 500);
            this.panel16.TabIndex = 11;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.comboOpNo);
            this.panel15.Controls.Add(this.label15);
            this.panel15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel15.Location = new System.Drawing.Point(608, 62);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(253, 33);
            this.panel15.TabIndex = 8;
            // 
            // comboOpNo
            // 
            this.comboOpNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOpNo.FormattingEnabled = true;
            this.comboOpNo.Location = new System.Drawing.Point(169, 4);
            this.comboOpNo.Name = "comboOpNo";
            this.comboOpNo.Size = new System.Drawing.Size(81, 25);
            this.comboOpNo.TabIndex = 1;
            this.comboOpNo.SelectedIndexChanged += new System.EventHandler(this.comboOpNo_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Appointment Detail No.";
            // 
            // limit
            // 
            this.limit.AutoSize = true;
            this.limit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limit.Location = new System.Drawing.Point(606, 485);
            this.limit.Name = "limit";
            this.limit.Size = new System.Drawing.Size(133, 17);
            this.limit.TabIndex = 10;
            this.limit.Text = "Up to 200 characters.";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.datePickerSchedule);
            this.panel14.Controls.Add(this.label14);
            this.panel14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel14.Location = new System.Drawing.Point(608, 148);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(357, 33);
            this.panel14.TabIndex = 9;
            // 
            // datePickerSchedule
            // 
            this.datePickerSchedule.CalendarMonthBackground = System.Drawing.Color.White;
            this.datePickerSchedule.CustomFormat = "";
            this.datePickerSchedule.Enabled = false;
            this.datePickerSchedule.Location = new System.Drawing.Point(123, 4);
            this.datePickerSchedule.Name = "datePickerSchedule";
            this.datePickerSchedule.Size = new System.Drawing.Size(231, 25);
            this.datePickerSchedule.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Schedule";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.comboEnd);
            this.panel13.Controls.Add(this.tbEndTime);
            this.panel13.Controls.Add(this.label13);
            this.panel13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel13.Location = new System.Drawing.Point(608, 239);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(357, 33);
            this.panel13.TabIndex = 9;
            // 
            // comboEnd
            // 
            this.comboEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEnd.Enabled = false;
            this.comboEnd.FormattingEnabled = true;
            this.comboEnd.Location = new System.Drawing.Point(294, 5);
            this.comboEnd.Name = "comboEnd";
            this.comboEnd.Size = new System.Drawing.Size(60, 25);
            this.comboEnd.TabIndex = 3;
            // 
            // tbEndTime
            // 
            this.tbEndTime.Enabled = false;
            this.tbEndTime.Location = new System.Drawing.Point(79, 5);
            this.tbEndTime.Name = "tbEndTime";
            this.tbEndTime.Size = new System.Drawing.Size(209, 25);
            this.tbEndTime.TabIndex = 2;
            this.tbEndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "End-Time";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.comboStart);
            this.panel12.Controls.Add(this.tbStartTime);
            this.panel12.Controls.Add(this.label12);
            this.panel12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel12.Location = new System.Drawing.Point(608, 193);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(357, 33);
            this.panel12.TabIndex = 8;
            // 
            // comboStart
            // 
            this.comboStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStart.Enabled = false;
            this.comboStart.FormattingEnabled = true;
            this.comboStart.Location = new System.Drawing.Point(294, 4);
            this.comboStart.Name = "comboStart";
            this.comboStart.Size = new System.Drawing.Size(60, 25);
            this.comboStart.TabIndex = 2;
            // 
            // tbStartTime
            // 
            this.tbStartTime.Enabled = false;
            this.tbStartTime.Location = new System.Drawing.Point(79, 4);
            this.tbStartTime.Name = "tbStartTime";
            this.tbStartTime.Size = new System.Drawing.Size(209, 25);
            this.tbStartTime.TabIndex = 1;
            this.tbStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Start-Time";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.tbContact);
            this.panel11.Controls.Add(this.label11);
            this.panel11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel11.Location = new System.Drawing.Point(28, 401);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(421, 33);
            this.panel11.TabIndex = 3;
            // 
            // tbContact
            // 
            this.tbContact.BackColor = System.Drawing.Color.White;
            this.tbContact.Enabled = false;
            this.tbContact.Location = new System.Drawing.Point(145, 4);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(188, 25);
            this.tbContact.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Contact Number";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.White;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(874, 485);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(91, 34);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.comboOperations);
            this.panel10.Controls.Add(this.label10);
            this.panel10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel10.Location = new System.Drawing.Point(608, 101);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(354, 33);
            this.panel10.TabIndex = 7;
            // 
            // comboOperations
            // 
            this.comboOperations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOperations.FormattingEnabled = true;
            this.comboOperations.Location = new System.Drawing.Point(123, 4);
            this.comboOperations.Name = "comboOperations";
            this.comboOperations.Size = new System.Drawing.Size(228, 25);
            this.comboOperations.TabIndex = 1;
            this.comboOperations.SelectedIndexChanged += new System.EventHandler(this.comboOperations_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Operations";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.label9);
            this.panel9.Controls.Add(this.tbDiagnosis);
            this.panel9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel9.Location = new System.Drawing.Point(608, 296);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(357, 183);
            this.panel9.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Diagnosis";
            // 
            // tbDiagnosis
            // 
            this.tbDiagnosis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbDiagnosis.Location = new System.Drawing.Point(0, 26);
            this.tbDiagnosis.MaxLength = 200;
            this.tbDiagnosis.Multiline = true;
            this.tbDiagnosis.Name = "tbDiagnosis";
            this.tbDiagnosis.Size = new System.Drawing.Size(355, 155);
            this.tbDiagnosis.TabIndex = 5;
            this.tbDiagnosis.TextChanged += new System.EventHandler(this.tbDiagnosis_TextChanged);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.tbGender);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(28, 347);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(194, 33);
            this.panel8.TabIndex = 4;
            // 
            // tbGender
            // 
            this.tbGender.BackColor = System.Drawing.Color.White;
            this.tbGender.Enabled = false;
            this.tbGender.Location = new System.Drawing.Point(99, 4);
            this.tbGender.Name = "tbGender";
            this.tbGender.Size = new System.Drawing.Size(92, 25);
            this.tbGender.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Gender";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.datePickerBDay);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(28, 298);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(421, 33);
            this.panel7.TabIndex = 4;
            // 
            // datePickerBDay
            // 
            this.datePickerBDay.CalendarMonthBackground = System.Drawing.Color.White;
            this.datePickerBDay.CustomFormat = "";
            this.datePickerBDay.Enabled = false;
            this.datePickerBDay.Location = new System.Drawing.Point(145, 4);
            this.datePickerBDay.Name = "datePickerBDay";
            this.datePickerBDay.Size = new System.Drawing.Size(268, 25);
            this.datePickerBDay.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Birth-Date";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbAge);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(251, 347);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(198, 33);
            this.panel6.TabIndex = 3;
            // 
            // tbAge
            // 
            this.tbAge.BackColor = System.Drawing.Color.White;
            this.tbAge.Enabled = false;
            this.tbAge.Location = new System.Drawing.Point(119, 3);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(71, 25);
            this.tbAge.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Age";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.RoomNo);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(25, 101);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(194, 33);
            this.panel5.TabIndex = 4;
            // 
            // RoomNo
            // 
            this.RoomNo.BackColor = System.Drawing.Color.White;
            this.RoomNo.Enabled = false;
            this.RoomNo.Location = new System.Drawing.Point(99, 5);
            this.RoomNo.Name = "RoomNo";
            this.RoomNo.Size = new System.Drawing.Size(92, 25);
            this.RoomNo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Room No.";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbPatientId);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(25, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(194, 33);
            this.panel4.TabIndex = 3;
            // 
            // tbPatientId
            // 
            this.tbPatientId.BackColor = System.Drawing.Color.White;
            this.tbPatientId.Enabled = false;
            this.tbPatientId.Location = new System.Drawing.Point(99, 4);
            this.tbPatientId.Name = "tbPatientId";
            this.tbPatientId.ReadOnly = true;
            this.tbPatientId.Size = new System.Drawing.Size(92, 25);
            this.tbPatientId.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Patient ID";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbAddress);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(28, 249);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(515, 33);
            this.panel3.TabIndex = 2;
            // 
            // tbAddress
            // 
            this.tbAddress.BackColor = System.Drawing.Color.White;
            this.tbAddress.Enabled = false;
            this.tbAddress.Location = new System.Drawing.Point(145, 4);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(359, 25);
            this.tbAddress.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbFullName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(28, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(515, 33);
            this.panel2.TabIndex = 0;
            // 
            // tbFullName
            // 
            this.tbFullName.BackColor = System.Drawing.Color.White;
            this.tbFullName.Enabled = false;
            this.tbFullName.Location = new System.Drawing.Point(145, 4);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(359, 25);
            this.tbFullName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Patient Full Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchPatient);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(26, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 45);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Patient Name / ID";
            // 
            // searchPatient
            // 
            this.searchPatient.Location = new System.Drawing.Point(28, 20);
            this.searchPatient.Name = "searchPatient";
            this.searchPatient.Size = new System.Drawing.Size(175, 22);
            this.searchPatient.TabIndex = 0;
            this.searchPatient.TextChanged += new System.EventHandler(this.searchPatient_TextChanged);
            // 
            // DoctorViewPatient
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1079, 683);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorViewPatient";
            this.Text = "DoctorViewPatient";
            this.tabControl.ResumeLayout(false);
            this.PatientList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientGrid)).EndInit();
            this.PatientDetails.ResumeLayout(false);
            this.PatientDetails.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage PatientList;
        private System.Windows.Forms.TabPage PatientDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchPatient;
        private System.Windows.Forms.DataGridView patientGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbPatientId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox RoomNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datePickerBDay;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDiagnosis;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox comboOperations;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox tbEndTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox tbStartTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker datePickerSchedule;
        private System.Windows.Forms.Label limit;
        private System.Windows.Forms.ComboBox comboEnd;
        private System.Windows.Forms.ComboBox comboStart;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.ComboBox comboOpNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel16;
    }
}