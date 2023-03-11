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
    public partial class Wallet : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        string connection_string = @"Data Source=KHANHDINH; " +
                                    "Initial Catalog=Data_Account; " +
                                    "Integrated Security=True";


        string _username = "";
        string _fullname = "";
        public Wallet(String fullname, string username)
        {
            InitializeComponent();
            _username = username;
            _fullname = fullname;
            lb_welcome.Text += fullname;
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            this.Close();
            History history = new History(_fullname, _username);
            history.Show();
        }

        private void btn_booking_Click(object sender, EventArgs e)
        {
            this.Close();
            BookingForCustomer booking = new BookingForCustomer(_fullname, _username);
            booking.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home(_fullname, _username);
            home.Show();
        }

        private void Wallet_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(connection_string);
            cn.Open();

            // Lấy kích thước của Form
            int formWidth = this.panel1.Width;
            int formHeight = this.panel1.Height;

            // Lấy kích thước của Label
            int labelWidth = label1.Size.Width;
            int labelHeight = label1.Size.Height;

            // Tính toán vị trí căn giữa
            int x = (formWidth - labelWidth) / 2;
            int y = (formHeight - labelHeight) / 2;

            // Đặt vị trí cho Label
            label1.SetBounds(x, y, labelWidth, labelHeight);

            string sql_query = "SELECT balance " +
                                "FROM Customers " +
                                "WHERE username = '" + _username + "'";
            cmd = new SqlCommand(sql_query, cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                double value = dr.GetDouble(0);
                string formatted_x = value.ToString("N0");
                formatted_x = formatted_x.Replace(",", ".");
                lb_balance.Text += formatted_x + " vnđ";

            }
            dr.Close();
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            Deposit deposit = new Deposit(_fullname, _username);
            deposit.ShowDialog();
        }

        private void btn_withdraw_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            Withdraw withdraw = new Withdraw(_fullname, _username);
            withdraw.ShowDialog();
        }

        private void Wallet_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
