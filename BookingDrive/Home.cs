using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingDrive
{
    public partial class Home : Form
    {
        string _username = "";
        string _fullname = "";
        public Home(string fullname, string username)
        {
            InitializeComponent();
            lb_welcome.Text += fullname;
            _username = username;
            _fullname = fullname;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Threading.Thread login = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLoginForm));
            login.Start();
        }

        public static void OpenLoginForm()
        {
            Application.Run(new Login());
        }

        private void btn_booking_Click(object sender, EventArgs e)
        {
            this.Close();
            Booking booking = new Booking(_fullname, _username);
            booking.ShowDialog();
        }
        private void btn_history_Click(object sender, EventArgs e)
        {
            this.Close();
            History history = new History(_fullname, _username);
            history.ShowDialog();
        }
        private void btn_wallet_Click(object sender, EventArgs e)
        {
            this.Close();
            Wallet wallet = new Wallet(_fullname, _username);
            wallet.ShowDialog();
        }
    }
}
