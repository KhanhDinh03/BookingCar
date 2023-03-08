using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingDrive
{
    public partial class Home : Form
    {
        public Home(String username)
        {
            InitializeComponent();
            lb_welcome.Text += username;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLoginForm));
            t.Start();
        }

        public static void OpenLoginForm()
        {
            Application.Run(new Login());
        }

        private void btn_booking_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookingForDriver booking = new BookingForDriver();
            booking.ShowDialog();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookingForCustomer bookingForCustomer = new BookingForCustomer();
            bookingForCustomer.ShowDialog();
        }
    }
}
