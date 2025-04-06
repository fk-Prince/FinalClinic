using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Image = System.Drawing.Image;
using System.Drawing.Printing;
using System.Security.Policy;
using ClinicSystem.PatientForm;

namespace ClinicSystem
{
    public partial class PrintAppointmentReceipt : Form
    {
        private Image image = Properties.Resources.Logo;
        private List<Appointment> app;
        private Patient patient;
        private int age;
        private string fullname;
        private string dateAp = DateTime.Now.ToString("yyyy-MM-dd");
        private string timeAp = DateTime.Now.ToString("hh:mm:ss tt");


        private float x = 20;
        private float y = 430;
        private float rowHeight = 30f;
        private float col0 = 90f;
        private float col2 = 170f;
        private float col345 = 100f;
        private float col6 = 100f;
        private float defaultCol = 150f;

        private string type;
        public PrintAppointmentReceipt(Patient patient, List<Appointment> app, string type)
        {
            InitializeComponent();
            this.app = app;
            this.type = type;
            this.patient = patient;


        }

        internal void print()
        {
            printPreviewDialog1.Document = printDocument;
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.ShowDialog();

            //if (printDialog.ShowDialog() == DialogResult.OK)
            //{
            //    printDocument.Print();
            //}
        }

        private static bool isLoad = false;
        private static int lastRead = 0;

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (!isLoad)
            {
                drawHeader(e);
            }
            // TABLE HEADER
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font rowFont = new Font("Arial", 10);
            Brush brush = Brushes.Black;
            string[] headers = { "RoomNo", "Operation Name", "Doctor Name", "Date", "Start-Time", "End-Time", "Ammount" };
            for (int i = 0; i < headers.Length; i++)
            {
                float colWidth;
                if (i == 0) colWidth = col0;
                else if (i == 2) colWidth = col2;
                else if (i == 3 || i == 4 || i == 5) colWidth = col345;
                else if (i == 6) colWidth = col6;
                else colWidth = defaultCol;

                e.Graphics.FillRectangle(Brushes.Aqua, x, y, colWidth, rowHeight);
                e.Graphics.DrawLine(Pens.Black, x, y, x + colWidth, y);
                e.Graphics.DrawLine(Pens.Black, x, y + rowHeight, x + colWidth, y + rowHeight);
                e.Graphics.DrawString(headers[i], headerFont, brush, x + 5, y + 5);
                x += colWidth;
            }
            y += rowHeight;

            int rows = 0;
            int maxRow = 16;

            if (app.Count > 16)
            {
                e.Graphics.DrawString($"Page {page}", new Font("Sans-serif", 9), Brushes.Black, 10, 1070);
                page++;
            }

            for (int i = lastRead; i < app.Count(); i++)
            {
                Appointment a = app[i];
                x = 20;

                for (int col = 0; col < headers.Length; col++)
                {
                    float colWidth = columnWidth(col);
                    string data = columnData(col, a);


                    if (rows % 2 == 0) e.Graphics.FillRectangle(Brushes.White, x, y, colWidth, rowHeight);
                    else e.Graphics.FillRectangle(Brushes.LightGray, x, y, colWidth, rowHeight);

                    e.Graphics.DrawLine(Pens.Black, x, y, x + colWidth, y);
                    e.Graphics.DrawLine(Pens.Black, x, y + rowHeight, x + colWidth, y + rowHeight);
                    e.Graphics.DrawString(data, rowFont, brush, x + 5, y + 5);
                    x += colWidth;
                }

                rows++;
                y += rowHeight;

                if (rows == maxRow)
                {
                    e.HasMorePages = true;
                    lastRead = i + 1;
                    isLoad = !isLoad;
                    y = 100;
                    x = 20;
                    return;
                }
            }


            y += 100;
            drawTotal(e, y);
        }
        private static int page = 1;

        private void drawHeader(PrintPageEventArgs e)
        {
            age = patient.Age;
            fullname = Capitalized(patient.Firstname) + "  " + Capitalized(patient.Middlename) + "  " + Capitalized(patient.Lastname);
            e.Graphics.DrawImage(image, 20, 20, 100, 100);
            e.Graphics.DrawString("Quantum Care", new Font("Impact", 36, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline), Brushes.Aqua, 120, 20);
            e.Graphics.DrawString("506 J.P. Laurel Ave,", new Font("Sans-serif", 12, FontStyle.Regular), Brushes.Black, 125, 80);
            e.Graphics.DrawString("Poblacion District, Davao City", new Font("Sans-serif", 12, FontStyle.Regular), Brushes.Black, 125, 100);

            if (type.Equals("Add"))
            {
                e.Graphics.DrawString("Appointment", new Font("Impact", 20, FontStyle.Bold), Brushes.Black, 650, 60);
                e.Graphics.DrawString("Details", new Font("Impact", 20, FontStyle.Bold), Brushes.Black, 720, 95);
                e.Graphics.DrawString($"Date of Scheduling: {dateAp}", new Font("Sans-serif", 12), Brushes.Black, 30, 310);
                e.Graphics.DrawString($"Time of Scheduling: {timeAp}", new Font("Sans-serif", 12), Brushes.Black, 30, 340);
            } else if (type.Equals("Reappointment"))
            {
                e.Graphics.DrawString("Reschedule", new Font("Impact", 20, FontStyle.Bold), Brushes.Black, 660, 60);
                e.Graphics.DrawString("Appointment", new Font("Impact", 20, FontStyle.Bold), Brushes.Black, 650, 95);
                e.Graphics.DrawString("Details", new Font("Impact", 20, FontStyle.Bold), Brushes.Black, 720, 130);
                e.Graphics.DrawString($"Date of Scheduling: {DateTime.Now.ToString("yyyy-MM-dd")}", new Font("Sans-serif", 12), Brushes.Black, 30, 310);
                e.Graphics.DrawString($"Time of Scheduling: {DateTime.Now.ToString("hh:mm:ss tt")}", new Font("Sans-serif", 12), Brushes.Black, 30, 340);
            }


            e.Graphics.DrawString($"Patient Name: {fullname}", new Font("Sans-serif", 12, FontStyle.Bold), Brushes.Black, 30, 250);
            e.Graphics.DrawString($"Age: {age}", new Font("Sans-serif", 12), Brushes.Black, 30, 280);
      
        }

        private void drawTotal(PrintPageEventArgs e, float y)
        {
            Graphics graphics = Graphics.FromHwnd(IntPtr.Zero);
            Font font = new Font("Sans-serif", 14, FontStyle.Regular);
            string stotal = app.Sum(a => a.Bill).ToString("F2");
            string subtotal = $"Subtotal: \t\t\t ₱  {stotal}";
            SizeF size1 = graphics.MeasureString(subtotal, font);
            e.Graphics.DrawString(subtotal, font, Brushes.Black, 820 - size1.Width, y);

            y += 30;
            string discount = $"Discounted:  \t\t\t ₱  {stotal}";
            SizeF size2 = graphics.MeasureString(discount, font);
            e.Graphics.DrawString(discount, font, Brushes.Black, 820 - size2.Width, y);

            y += 30;
            Font tfont = new Font("Sans-serif", 14, FontStyle.Bold);
            string total = app.Sum(a => a.Bill).ToString("F2");
            string totalAmount = $"Total Ammount: \t\t\t ₱ {total}";
            SizeF size3 = graphics.MeasureString(totalAmount, tfont);
            e.Graphics.DrawString(totalAmount, tfont, Brushes.Black, 820 - size3.Width, y);
        }

        private double getDiscount()
        {
            return 0;
        }
        private float columnWidth(int col)
        {

            switch (col)
            {
                case 0: return col0;
                case 1: return defaultCol;
                case 2: return col2;
                case 3: return col345;
                case 4: return col345;
                case 5: return col345;
                case 6: return col6;
                default: return defaultCol;
            }
        }

        private string columnData(int col, Appointment a)
        {
            DateTime startdate = DateTime.Now + a.StartTime;
            DateTime enddate = DateTime.Now + a.EndTime;
            switch (col)
            {
                case 0: return a.RoomNo.ToString();
                case 1: return a.Operation.OperationName;
                case 2: return a.Doctor.DoctorFirstName + " " + a.Doctor.DoctorLastName;
                case 3: return a.DateSchedule.ToString("yyyy-MM-dd");
                case 4: return startdate.ToString("hh:mm:ss tt");
                case 5: return enddate.ToString("hh:mm:ss tt");
                case 6: return a.Bill.ToString("F2");
                default: return "";
            }
        }

        private string Capitalized(string text)
        {
            return text.Substring(0, 1).ToUpper() + text.Substring(1);
        }
    }
}
