﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Image = System.Drawing.Image;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicSystem.PatientForm;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Google.Protobuf.WellKnownTypes;

namespace ClinicSystem.DoctorClinic
{
    public partial class PrintDoctorReceipt : Form
    {
        private Image image = Properties.Resources.Logo;
        private List<Appointment> app;
        private Patient patient;

        private string patientFullName;
        private string doctorFullName;
        private Patient selectedPatient;
        private Doctor selectedDoctor;

        private int page = 1;
        private static int lastRead = 0;
        private static bool isLoad = false;
        private float tempX;

        private int newLine = 35;
        private float x = 20;
        private float y = 500;
        private float rowHeight = 30f;
        private float col0 = 170f;
        private float col1 = 270f;
        private float col2 = 150f;
        private float col3 = 220f;
        public PrintDoctorReceipt(List<Appointment> app)
        {
            InitializeComponent();
            foreach (Appointment a in app)
            {
                selectedPatient = a.Patient;
                selectedDoctor = a.Doctor;
                patientFullName = Capitalized(a.Patient.Firstname) + "  " + Capitalized(a.Patient.Middlename) + "  " + Capitalized(a.Patient.Lastname);
                doctorFullName = Capitalized(a.Doctor.DoctorFirstName) + "  " + Capitalized(a.Doctor.DoctorMiddleName) + "  " + Capitalized(a.Doctor.DoctorLastName);
                break;
            }
            this.app = app;

        }

        private string Capitalized(string firstname)
        {
            return firstname.Substring(0, 1).ToUpper() + firstname.Substring(1).ToLower();
        }

        internal void print()
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.WindowState = FormWindowState.Maximized;
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (page == 1)
            {
                drawHeader(e);
            }

            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font rowFont = new Font("Arial", 10);
            Brush brush = Brushes.Black;
            string[] headers1 = { "      Operation", "                 Diagnosis", "    Operation", "        Duration Time" };
            string[] headers = { "       Name", "", "     Date", "       Start  |  End" };
            if (page != 1)
            {
                 x = 20;
                 y = 100;
                 rowHeight = 30f;
            }
            for (int i = 0; i < headers.Length; i++)
            {
                float colWidth = 0;
                if (i == 0) colWidth = col0;
                else if (i == 1) colWidth = col1;
                else if (i == 2) colWidth = col2;
                else if (i == 3) colWidth = col3;
                e.Graphics.FillRectangle(Brushes.Aqua, x, y, colWidth, y);
                e.Graphics.DrawRectangle(Pens.Black, x, y, colWidth, y);
                //e.Graphics.DrawLine(Pens.Black, x, y + (rowHeight + 25), x + colWidth, y + (rowHeight + 25));
                e.Graphics.DrawString(headers[i], headerFont, brush, x + 30, y + 30);
                e.Graphics.DrawString(headers1[i], headerFont, brush, x + 15, y + 5);
                x += colWidth;
            }

            rowHeight += 25;
            y += rowHeight;
            int rows = 0;
            int maxRow = (page == 1) ? 3 : 5;



            if (app.Count > 3) e.Graphics.DrawString($"Page {page}", new Font("Sans-serif", 9), Brushes.Black, 10, 1070);

            StringBuilder sb;
            for (int i = lastRead; i < app.Count(); i++)
            {
                Appointment a = app[i];
                x = 20;

                for (int col = 0; col < headers.Length; col++)
                {
                    float colWidth = columnWidth(col);
                    string data = columnData(col, a);

                    Brush bg = (rows % 2 == 0) ? Brushes.White : Brushes.Gainsboro;
                    e.Graphics.FillRectangle(bg, x, y, colWidth, 150);
                    e.Graphics.DrawRectangle(Pens.Black, x, y, colWidth, 150);

                    if (col == 1)
                    {
                        sb = checkDiagnosisLength(data);
                        e.Graphics.DrawString(sb.ToString(), new Font("Arial", 11), brush, x + 5, y + 5);
                    }
                    else
                    {
                        e.Graphics.DrawString("  " + data, new Font("Arial", 12), brush, x + 5, y + 25);
                    }


                    x += colWidth;
                }
                rows++;
                y += 150;

                if (rows == maxRow)
                {
                    e.HasMorePages = true;
                    lastRead = i + 1;
                    y = 100;
                    page++;
                    x = 20;
                    return;
                }
            }
        }


        private StringBuilder checkDiagnosisLength(string diagnosis)
        {
            StringBuilder sb = new StringBuilder();
            int textIndex = 0;
            for (int i = 0; i < diagnosis.Length; i++)
            {
                sb.Append(diagnosis[i]);
                textIndex++;

                if (textIndex == newLine)
                {
                    sb.Append(Environment.NewLine);
                    textIndex = 0;
                }
            }
            return sb;
        }

        private void drawHeader(PrintPageEventArgs e)
        {

            e.Graphics.DrawImage(image, 20, 20, 140, 140);
            e.Graphics.DrawString("Quantum Care", new Font("Impact", 36, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline), Brushes.Aqua, 140, 25);
            e.Graphics.DrawString("506 J.P. Laurel Ave,", new Font("Sans-serif", 12, FontStyle.Regular), Brushes.Black, 145, 85);
            e.Graphics.DrawString("Poblacion District, Davao City", new Font("Sans-serif", 12, FontStyle.Regular), Brushes.Black, 145, 105);


            e.Graphics.DrawString("Diagnosis", new Font("Impact", 20, FontStyle.Bold), Brushes.Black, 685, 60);
            e.Graphics.DrawString("Details", new Font("Impact", 20, FontStyle.Bold), Brushes.Black, 720, 95);


            e.Graphics.DrawString($"Patient Name  : {patientFullName}", new Font("Sans-serif", 12, FontStyle.Bold), Brushes.Black, 30, 250);
            e.Graphics.DrawString($"Age  : {selectedPatient.Age}", new Font("Sans-serif", 12), Brushes.Black, 30, 280);
            e.Graphics.DrawString($"Gender  : {selectedPatient.Gender}", new Font("Sans-serif", 12), Brushes.Black, 30, 310);
            e.Graphics.DrawString($"Contact No.  : {selectedPatient.ContactNumber}", new Font("Sans-serif", 12), Brushes.Black, 30, 340);

            e.Graphics.DrawString($"Attending Doctor  : {doctorFullName}", new Font("Sans-serif", 12, FontStyle.Bold), Brushes.Black, 30, 390);
            e.Graphics.DrawString($"Dr. Contact No.  : {selectedDoctor.DoctorContactNumber}", new Font("Sans-serif", 12), Brushes.Black, 30, 420);
        }
        private float columnWidth(int col)
        {

            switch (col)
            {
                case 0: return col0;
                case 1: return col1;
                case 2: return col2;
                case 3: return col3;
                default: return col0;
            }
        }

        private string columnData(int col, Appointment a)
        {
            DateTime startdate = DateTime.Now + a.StartTime;
            DateTime enddate = DateTime.Now + a.EndTime;
            switch (col)
            {
                case 0: return a.Operation.OperationName;
                case 1: return a.Diagnosis;
                case 2: return a.DateSchedule.ToString("yyyy-MM-dd");
                case 3: return startdate.ToString("hh:mm:dd tt") + " | " + enddate.ToString("hh:mm:dd tt");
                default: return "";
            }
        }
    }
}
