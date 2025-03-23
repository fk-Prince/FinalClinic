using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ClinicSystem.UserLoginForm;

namespace ClinicSystem
{
    public partial class OperationForm : Form
    {
        private List<Operation> operationlist;
        private DataBaseOperation db = new DataBaseOperation();
        private Staff staff;
        private bool isAddOperationShowing = false;
        public OperationForm(Staff staff)
        {
            this.staff = staff;
            InitializeComponent();
            operationlist = db.getOperations();
            displayOperations(operationlist);
            button1.Region = System.Drawing.Region.FromHrgn(dll.CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 10, 10));
            button2.Region = System.Drawing.Region.FromHrgn(dll.CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 10, 10));
            button3.Region = System.Drawing.Region.FromHrgn(dll.CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 10, 10));
            addOperationPanel.Region= System.Drawing.Region.FromHrgn(dll.CreateRoundRectRgn(0, 0, addOperationPanel.Width, addOperationPanel.Height, 50, 50));
        }




        private void displayOperations(List<Operation> operationlist)
        {
            flowLayout.Controls.Clear();

            foreach (Operation operation in operationlist)
            {
                Panel panel = new Panel();
                panel.Size = new Size(300, 250);
                panel.Location = new Point(50, 100);    
                panel.Margin = new Padding(30, 10, 10, 10);
                panel.BackColor = Color.FromArgb(60, 141, 188);
                panel.Region = Region.FromHrgn(dll.CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 50, 50));


                Label label = createLabel("Operation Code", operation.OperationCode, 10, 5);
                panel.Controls.Add(label);

                label = createLabel("Operation Name", operation.OperationName, 10, 25);
                panel.Controls.Add(label);

                label = createLabel(
                    "Date-Added",
                    operation.DateAdded.ToString("yyyy-MM-dd"),
                    10,
                    45
                );
                panel.Controls.Add(label);

                label = createLabel("Price", operation.Price.ToString(), 10, 65);
                panel.Controls.Add(label);

                label = createLabel("Duration", operation.Duration.ToString(), 10, 85);
                panel.Controls.Add(label);

                label = new Label();
                label.Text = "Description";
                label.MaximumSize = new Size(200, 0);
                label.AutoSize = true;
                label.Location = new Point(15, 105);
                panel.Controls.Add(label);

                TextBox tb = new TextBox();
                tb.Multiline = true;
                tb.Text = operation.Description;
                tb.Location = new Point(15, 125);
                tb.Size = new Size(270, 60);
                tb.ReadOnly = true;
                panel.Controls.Add(tb);

                Panel panelLine = new Panel();
                panelLine.Size = new Size(300, 1);
                panelLine.BackColor = Color.Gray;
                panelLine.Location = new Point(0, 195);
                panel.Controls.Add(panelLine);

                label = new Label();
                label.Text = "Doctor Assigned";
                label.MaximumSize = new Size(200, 0);
                label.AutoSize = true;
                label.Location = new Point(15, 215);
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
                combo.Location = new Point(138, 212);
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
            if (isAddOperationShowing)
            {
                return;
            }
            isAddOperationShowing = !isAddOperationShowing;
            timerin.Start();
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
                MessagePromp.MainShowMessage(this, "Please fill up all fields", MessageBoxIcon.Error);
                //MessageBox.Show("Please fill up all fields", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool duplicateCode = operationlist.Any(operation => operation.OperationCode.Equals(opCode, StringComparison.OrdinalIgnoreCase));
            if (duplicateCode)
            {
                MessagePromp.MainShowMessage(this, "Duplicate Operation Code", MessageBoxIcon.Error);
                //MessageBox.Show("Duplicate Operation Code", "Duplicate Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double price;
            if (!double.TryParse(opPrice.Text, out price))
            {
                MessagePromp.MainShowMessage(this, "Invalid Price", MessageBoxIcon.Error);
               // MessageBox.Show("Invalid Price", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            price = double.Parse(price.ToString("F2"));

            if (price >= 1000000000)
            {
                MessagePromp.MainShowMessage(this, "Price is too big.", MessageBoxIcon.Error);
                // MessageBox.Show("Price is too big.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TimeSpan duration;
            if (!TimeSpan.TryParseExact(opDuration.Text, @"hh\:mm\:ss", null, out duration))
            {
                MessagePromp.MainShowMessage(this, "Invalid Duration", MessageBoxIcon.Error);
               // MessageBox.Show("Invalid Duration", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (duration == TimeSpan.Zero)
            {
                MessagePromp.MainShowMessage(this, "Invalid Duration", MessageBoxIcon.Error);
               // MessageBox.Show("Invalid Duration", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool success = db.insert(staff.StaffId, new Operation(opCode.ToUpper(), Capitalize(opName), DateTime.Now, opDescription, price, duration));
            if (success)
            {
                MessagePromp.MainShowMessage(this, "Operation Added Successfully", MessageBoxIcon.Error);
               // MessageBox.Show("Operation Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
            }
            else
            {
                MessagePromp.MainShowMessage(this, "Operation Failed to Add", MessageBoxIcon.Error);
                //MessageBox.Show("Operation Failed to Add");
            }
        }
        public string Capitalize(string name)
        {
            if (string.IsNullOrEmpty(name))
                return name;

            return char.ToUpper(name[0]) + name.Substring(1).ToLower();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            isAddOperationShowing = !isAddOperationShowing;
            reset();
            timerout.Start();
        }

        public void reset()
        {
            opCode.Text = "";
            opName.Text = "";
            opDescription.Text = "";
            opPrice.Text = "";
            opDuration.Text = "";
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
                if (op)
                {
                   op = double.Parse(opPrice.Text) <= 1000000000;
                }
                picturePrice.Image = op ? Properties.Resources.check : Properties.Resources.error;
            }
            else
            {
                picturePrice.Image = null;
            }
        }

        private void TextOnly(object sender, KeyPressEventArgs e)
        {
             if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
             {
                e.Handled = true;
             }
        }

        private void NumberOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private int x = -457;
        private void timer1_Tick(object sender, EventArgs e)
        {
            x += 20;
            addOperationPanel.Location = new Point(x, 131);
            if (x >= 320)
            {
                timerin.Stop();
            }
        }

       
        private void timerout_Tick(object sender, EventArgs e)
        {
            x -= 20;
            addOperationPanel.Location = new Point(x, 131);
            if (x <= -457)
            {
                timerout.Stop();
                addOperationPanel.Visible = false;
                flowLayout.Visible = true;
            }
        }
    }
}
