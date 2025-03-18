using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSystem.Doctors
{
    public partial class AddDoctor : Form
    {
        public AddDoctor(UserLoginForm.Staff staff)
        {
            InitializeComponent();
            button3.Region = System.Drawing.Region.FromHrgn(dll.CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 50, 50));
        }
    }
}
