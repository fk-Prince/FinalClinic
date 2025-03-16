namespace ClinicSystem
{
    partial class ViewPatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPatientForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PatientList = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.PatientDetails = new System.Windows.Forms.TabPage();
            this.panel14 = new System.Windows.Forms.Panel();
            this.tbBill = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.tbDoctorDiagnosis = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.comboDoctorAssigned = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.tbRoomNo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.datepickDateDischarged = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.datepickDateAdmitted = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.datepickBirthDay = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbfullName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboOperation = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbPatId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.PatientList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.PatientDetails.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PatientList);
            this.tabControl1.Controls.Add(this.PatientDetails);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 95);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1056, 491);
            this.tabControl1.TabIndex = 8;
            // 
            // PatientList
            // 
            this.PatientList.Controls.Add(this.dataGridView);
            this.PatientList.Location = new System.Drawing.Point(4, 29);
            this.PatientList.Name = "PatientList";
            this.PatientList.Padding = new System.Windows.Forms.Padding(3);
            this.PatientList.Size = new System.Drawing.Size(1048, 458);
            this.PatientList.TabIndex = 0;
            this.PatientList.Text = "Patient List";
            this.PatientList.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.dataGridView.ColumnHeadersHeight = 35;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 30;
            this.dataGridView.RowTemplate.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(1042, 452);
            this.dataGridView.TabIndex = 0;
            // 
            // PatientDetails
            // 
            this.PatientDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.PatientDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PatientDetails.Controls.Add(this.panel14);
            this.PatientDetails.Controls.Add(this.panel13);
            this.PatientDetails.Controls.Add(this.panel9);
            this.PatientDetails.Controls.Add(this.panel12);
            this.PatientDetails.Controls.Add(this.panel11);
            this.PatientDetails.Controls.Add(this.panel10);
            this.PatientDetails.Controls.Add(this.panel8);
            this.PatientDetails.Controls.Add(this.panel7);
            this.PatientDetails.Controls.Add(this.panel6);
            this.PatientDetails.Controls.Add(this.panel5);
            this.PatientDetails.Controls.Add(this.panel4);
            this.PatientDetails.Controls.Add(this.panel3);
            this.PatientDetails.Controls.Add(this.panel2);
            this.PatientDetails.Location = new System.Drawing.Point(4, 29);
            this.PatientDetails.Name = "PatientDetails";
            this.PatientDetails.Padding = new System.Windows.Forms.Padding(3);
            this.PatientDetails.Size = new System.Drawing.Size(1048, 458);
            this.PatientDetails.TabIndex = 1;
            this.PatientDetails.Text = "Patient Details";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.tbBill);
            this.panel14.Controls.Add(this.label15);
            this.panel14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel14.Location = new System.Drawing.Point(667, 16);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(350, 35);
            this.panel14.TabIndex = 8;
            // 
            // tbBill
            // 
            this.tbBill.Location = new System.Drawing.Point(116, 5);
            this.tbBill.Name = "tbBill";
            this.tbBill.ReadOnly = true;
            this.tbBill.Size = new System.Drawing.Size(227, 25);
            this.tbBill.TabIndex = 0;
            this.tbBill.TabStop = false;
            this.tbBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Patient Bill";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.tbDoctorDiagnosis);
            this.panel13.Controls.Add(this.label14);
            this.panel13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel13.Location = new System.Drawing.Point(597, 317);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(420, 122);
            this.panel13.TabIndex = 8;
            // 
            // tbDoctorDiagnosis
            // 
            this.tbDoctorDiagnosis.Enabled = false;
            this.tbDoctorDiagnosis.Location = new System.Drawing.Point(117, 5);
            this.tbDoctorDiagnosis.Multiline = true;
            this.tbDoctorDiagnosis.Name = "tbDoctorDiagnosis";
            this.tbDoctorDiagnosis.ReadOnly = true;
            this.tbDoctorDiagnosis.Size = new System.Drawing.Size(297, 114);
            this.tbDoctorDiagnosis.TabIndex = 0;
            this.tbDoctorDiagnosis.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Doctor Diagnosis";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.comboDoctorAssigned);
            this.panel9.Controls.Add(this.label10);
            this.panel9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel9.Location = new System.Drawing.Point(600, 264);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(417, 35);
            this.panel9.TabIndex = 5;
            // 
            // comboDoctorAssigned
            // 
            this.comboDoctorAssigned.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDoctorAssigned.FormattingEnabled = true;
            this.comboDoctorAssigned.Location = new System.Drawing.Point(184, 5);
            this.comboDoctorAssigned.Name = "comboDoctorAssigned";
            this.comboDoctorAssigned.Size = new System.Drawing.Size(230, 25);
            this.comboDoctorAssigned.TabIndex = 1;
            this.comboDoctorAssigned.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Doctor Assigned";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.tbRoomNo);
            this.panel12.Controls.Add(this.label13);
            this.panel12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel12.Location = new System.Drawing.Point(22, 16);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(169, 35);
            this.panel12.TabIndex = 7;
            // 
            // tbRoomNo
            // 
            this.tbRoomNo.Location = new System.Drawing.Point(94, 6);
            this.tbRoomNo.Name = "tbRoomNo";
            this.tbRoomNo.ReadOnly = true;
            this.tbRoomNo.Size = new System.Drawing.Size(70, 25);
            this.tbRoomNo.TabIndex = 0;
            this.tbRoomNo.TabStop = false;
            this.tbRoomNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "RoomNo. ";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.datepickDateDischarged);
            this.panel11.Controls.Add(this.label12);
            this.panel11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel11.Location = new System.Drawing.Point(22, 317);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(417, 35);
            this.panel11.TabIndex = 6;
            // 
            // datepickDateDischarged
            // 
            this.datepickDateDischarged.Enabled = false;
            this.datepickDateDischarged.Location = new System.Drawing.Point(171, 5);
            this.datepickDateDischarged.Name = "datepickDateDischarged";
            this.datepickDateDischarged.Size = new System.Drawing.Size(233, 25);
            this.datepickDateDischarged.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Date-Discharged";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.datepickDateAdmitted);
            this.panel10.Controls.Add(this.label11);
            this.panel10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel10.Location = new System.Drawing.Point(22, 267);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(417, 35);
            this.panel10.TabIndex = 5;
            // 
            // datepickDateAdmitted
            // 
            this.datepickDateAdmitted.Enabled = false;
            this.datepickDateAdmitted.Location = new System.Drawing.Point(171, 7);
            this.datepickDateAdmitted.Name = "datepickDateAdmitted";
            this.datepickDateAdmitted.Size = new System.Drawing.Size(233, 25);
            this.datepickDateAdmitted.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Date-Admitted";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.datepickBirthDay);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(22, 220);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(417, 35);
            this.panel8.TabIndex = 4;
            // 
            // datepickBirthDay
            // 
            this.datepickBirthDay.Enabled = false;
            this.datepickBirthDay.Location = new System.Drawing.Point(169, 6);
            this.datepickBirthDay.Name = "datepickBirthDay";
            this.datepickBirthDay.Size = new System.Drawing.Size(233, 25);
            this.datepickBirthDay.TabIndex = 0;
            this.datepickBirthDay.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "BirthDate";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tbAddress);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(22, 162);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(995, 35);
            this.panel7.TabIndex = 4;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(94, 5);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.ReadOnly = true;
            this.tbAddress.Size = new System.Drawing.Size(847, 25);
            this.tbAddress.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Address";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbGender);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(844, 112);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(173, 35);
            this.panel6.TabIndex = 3;
            // 
            // tbGender
            // 
            this.tbGender.Location = new System.Drawing.Point(91, 5);
            this.tbGender.Name = "tbGender";
            this.tbGender.ReadOnly = true;
            this.tbGender.Size = new System.Drawing.Size(78, 25);
            this.tbGender.TabIndex = 0;
            this.tbGender.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Gender";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbAge);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(641, 112);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(173, 35);
            this.panel5.TabIndex = 2;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(97, 5);
            this.tbAge.Name = "tbAge";
            this.tbAge.ReadOnly = true;
            this.tbAge.Size = new System.Drawing.Size(62, 25);
            this.tbAge.TabIndex = 0;
            this.tbAge.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Age";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbfullName);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(22, 112);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(527, 35);
            this.panel4.TabIndex = 3;
            // 
            // tbfullName
            // 
            this.tbfullName.Location = new System.Drawing.Point(94, 4);
            this.tbfullName.Name = "tbfullName";
            this.tbfullName.ReadOnly = true;
            this.tbfullName.Size = new System.Drawing.Size(430, 25);
            this.tbfullName.TabIndex = 1;
            this.tbfullName.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Full Name";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboOperation);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(600, 220);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(417, 35);
            this.panel3.TabIndex = 2;
            // 
            // comboOperation
            // 
            this.comboOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOperation.FormattingEnabled = true;
            this.comboOperation.Location = new System.Drawing.Point(184, 7);
            this.comboOperation.Name = "comboOperation";
            this.comboOperation.Size = new System.Drawing.Size(230, 25);
            this.comboOperation.TabIndex = 0;
            this.comboOperation.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Operations";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbPatId);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(22, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 35);
            this.panel2.TabIndex = 0;
            // 
            // tbPatId
            // 
            this.tbPatId.Location = new System.Drawing.Point(94, 6);
            this.tbPatId.Name = "tbPatId";
            this.tbPatId.ReadOnly = true;
            this.tbPatId.Size = new System.Drawing.Size(102, 25);
            this.tbPatId.TabIndex = 1;
            this.tbPatId.TabStop = false;
            this.tbPatId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "PatientID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(45, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 53);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Patient Name / ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 24);
            this.textBox1.TabIndex = 0;
            // 
            // ViewPatientForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1080, 598);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewPatientForm";
            this.Text = "ViewPatientForm";
            this.tabControl1.ResumeLayout(false);
            this.PatientList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.PatientDetails.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
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

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PatientList;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TabPage PatientDetails;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox tbBill;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox tbDoctorDiagnosis;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox comboDoctorAssigned;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox tbRoomNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DateTimePicker datepickDateDischarged;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DateTimePicker datepickDateAdmitted;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DateTimePicker datepickBirthDay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbfullName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboOperation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbPatId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}