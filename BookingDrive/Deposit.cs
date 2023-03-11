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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookingDrive
{
    public partial class Deposit : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataAdapter da;
        SqlDataReader dr;

        string connection_string = @"Data Source=KHANHDINH; " +
                                    "Initial Catalog=Data_Account; " +
                                    "Integrated Security=True";

        string _username = "";
        string _fullname = "";
        double value = 0;
        public Deposit(string fullname, string username)
        {
            InitializeComponent();
            _username = username;
            _fullname = fullname;
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
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

            cn = new SqlConnection(connection_string);
            cn.Open();

            string sql_query = "SELECT balance " +
                                "FROM Customers " +
                                "WHERE username = '" + _username + "'";
            cmd = new SqlCommand(sql_query, cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                value = dr.GetDouble(0);

            }
            dr.Close();
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            double new_balance = value + Convert.ToDouble(tb_money.Text);
            string sql_update = "UPDATE Customers " +
                                "SET balance = " + new_balance + " " +
                                "WHERE username='" + _username + "' ";
            cmd = new SqlCommand(sql_update, cn);
            dr = cmd.ExecuteReader();
            dr.Close();
            DialogResult dialogResult = MessageBox.Show("Nạp tiền thành công!", "Thông báo", MessageBoxButtons.OK);
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            this.Close();
            Wallet wallet = new Wallet(_fullname, _username);
            wallet.Show();
        }

        private void tb_money_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Deposit_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
