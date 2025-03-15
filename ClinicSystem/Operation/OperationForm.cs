using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ClinicSystem.UserLoginForm;

namespace ClinicSystem
{
    public partial class OperationForm : Form
    {
        private List<Operation> operationlist;
        private DataBaseOperation db = new DataBaseOperation();
        private Staff staff;
        public OperationForm(Staff staff)
        {
            this.staff = staff;
            InitializeComponent();
            operationlist = db.getOperations();
            displayOperations(operationlist);

        }


        private void displayOperations(List<Operation> operationlist)
        {
            flowLayout.Controls.Clear();

            foreach (Operation operation in operationlist)
            {
                Panel panel = new Panel();
                panel.Size = new Size( 300,250);
                panel.Location = new Point(50, 100);
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Margin = new Padding(25, 10, 10, 10);
                panel.BackColor = Color.FromArgb(153, 180, 209);

                Label label = createLabel("Operation Code", operation.OperationCode, 10, 0);
                panel.Controls.Add(label);

                label = createLabel("Operation Name", operation.OperationName, 10, 20);
                panel.Controls.Add(label);

                label = createLabel(
                    "Date-Added",
                    operation.DateAdded.ToString("yyyy-MM-dd"),
                    10,
                    40
                );
                panel.Controls.Add(label);

                label = createLabel("Price", operation.Price.ToString(), 10, 60);
                panel.Controls.Add(label);

                label = createLabel("Duration", operation.Duration.ToString(), 10, 80);
                panel.Controls.Add(label);

                label = new Label();
                label.Text = "Description";
                label.MaximumSize = new Size(200, 0);
                label.AutoSize = true;
                label.Location = new Point(15, 100);
                panel.Controls.Add(label);

                TextBox tb = new TextBox();
                tb.Multiline = true;
                tb.Text = operation.Description;
                tb.Location = new Point(15, 120);
                tb.Size = new Size(270, 60);
                tb.ReadOnly = true;
                panel.Controls.Add(tb);

                Panel panelLine = new Panel();
                panelLine.Size = new Size(300, 1);
                panelLine.BackColor = Color.Gray;
                panelLine.Location = new Point(0, 190);
                panel.Controls.Add(panelLine);

                label = new Label();
                label.Text = "Doctor Assigned";
                label.MaximumSize = new Size(200, 0);
                label.AutoSize = true;
                label.Location = new Point(15, 210);
                panel.Controls.Add(label);

                ComboBox combo = new ComboBox();
                foreach (Doctor doctor in operation.Doctor)
                {
                    string fullname = doctor.DoctorLastName + ", " + doctor.DoctorFirstName + " " + doctor.DoctorMiddleName;
                    combo.Items.Add(fullname);
                }
                if (operation.Doctor.Count == 0)
                {
                    combo.Items.Add("No Doctor Assigned");
                }
                combo.Location = new Point(138, 207);
                combo.DropDownStyle = ComboBoxStyle.DropDownList;
                combo.Size = new Size(150, 40);
                panel.Controls.Add(combo);

                flowLayout.Controls.Add(panel);
            }

        }

        public Label createLabel(string title, string value, int x, int y)
        {
            Label label = new Label();
            label.Text = $"{title}:   {value}";
            label.MaximumSize = new Size(280, 30);
            label.AutoSize = true;
            label.Location = new Point(x, y);
            return label;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Operation> filteredOperationList = new List<Operation>();
            if (string.IsNullOrWhiteSpace(SearchBar.Text))
            {
                filteredOperationList = operationlist;
            }
            else
            {

                filteredOperationList = operationlist.Where(
                   operation =>
                   operation.OperationName.StartsWith(SearchBar.Text, StringComparison.OrdinalIgnoreCase) ||
                   operation.OperationCode.StartsWith(SearchBar.Text, StringComparison.OrdinalIgnoreCase)
               ).ToList();

            }
            displayOperations(filteredOperationList);   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addOperationPanel.Visible = true;
            flowLayout.Visible = false;
            SearchBar.Enabled = false;
            SearchBar.Text = "";
            DateTime dateTime = DateTime.Now;
            opDate.Text = dateTime.ToString("yyyy-MM-dd");
        }

        private void opCode_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(opCode.Text))
            {
                string opCode = this.opCode.Text;
                bool op = operationlist.Any(operation => operation.OperationCode.Equals(opCode, StringComparison.OrdinalIgnoreCase));
                pictureCode.Image = op ? Properties.Resources.error : Properties.Resources.check;
            }
            else
            {
                pictureCode.Image = null;
            }
        }

        private void opName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(opName.Text))
            {
                string opName = this.opName.Text;
                bool op = operationlist.Any(operation => operation.OperationName.Equals(opName, StringComparison.OrdinalIgnoreCase));
                pictureName.Image = op ? Properties.Resources.error : Properties.Resources.check;
            }
            else
            {
                pictureName.Image = null;
            }
        }

        private void opDuration_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(opDuration.Text))
            {
                TimeSpan duration;
                bool op = TimeSpan.TryParseExact(opDuration.Text, @"hh\:mm\:ss", null, out duration);
                if (op)
                {
                    op = duration != TimeSpan.Zero;
                }
                pictureDuration.Image = op ? Properties.Resources.check : Properties.Resources.error ;
            }
            else
            {
                pictureDuration.Image = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string opCode = this.opCode.Text;
            string opName = this.opName.Text;
            string opDescription = this.opDescription.Text;
            if (string.IsNullOrWhiteSpace(opCode) 
                || string.IsNullOrWhiteSpace(opName) 
                || string.IsNullOrWhiteSpace(opDescription) 
                || string.IsNullOrWhiteSpace(opPrice.Text) 
                || string.IsNullOrWhiteSpace(opDuration.Text))
            {
                MessageBox.Show("Please fill up all fields", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool duplicateCode = operationlist.Any(operation => operation.OperationCode.Equals(opCode, StringComparison.OrdinalIgnoreCase));
            if (duplicateCode)
            {
                MessageBox.Show("Duplicate Operation Code", "Duplicate Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double price;
            if (!double.TryParse(opPrice.Text, out price))
            {
                MessageBox.Show("Invalid Price", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            price = double.Parse(price.ToString("F2"));

            TimeSpan duration;
            if (!TimeSpan.TryParseExact(opDuration.Text, @"hh\:mm\:ss", null, out duration))
            {
                MessageBox.Show("Invalid Duration", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (duration == TimeSpan.Zero)
            {
                MessageBox.Show("Invalid Duration", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool success = db.insert(staff.StaffId, new Operation(opCode, opName, DateTime.Now, opDescription, price, duration));
            if (success)
            {
                MessageBox.Show("Operation Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
            }
            else
            {
                MessageBox.Show("Operation Failed to Add");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reset();
        }

        public void reset()
        {
            opCode.Text = "";
            opName.Text = "";
            opDescription.Text = "";
            opPrice.Text = "";
            opDuration.Text = "";
            addOperationPanel.Visible = false;
            flowLayout.Visible = true;
            operationlist = db.getOperations();
            displayOperations(operationlist);
            SearchBar.Text = "";
            SearchBar.Enabled = true;
        }

        private void opPrice_TextChanged(object sender, EventArgs e)
        {
         
            if (!string.IsNullOrWhiteSpace(opPrice.Text))
            {
                bool op = double.TryParse(opPrice.Text, out double price);
                picturePrice.Image = op ? Properties.Resources.check : Properties.Resources.error;
            }
            else
            {
                picturePrice.Image = null;
            }
        }
    }
}
