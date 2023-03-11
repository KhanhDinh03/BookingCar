using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingDrive
{
    public partial class History : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataAdapter da;

        string connection_string = @"Data Source=KHANHDINH; " +
                                    "Initial Catalog=Data_Account; " +
                                    "Integrated Security=True";

        string _username = "";
        string _fullname = "";

        public History(String fullname, string username)
        {
            InitializeComponent();
            _username = username;
            _fullname = fullname;
        }

        private void Historycs_Load(object sender, EventArgs e)
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


            string sql_query = "SELECT time, departure, destination, typecar, price " +
                                "FROM HistoryForCustomers " +
                                "WHERE username = '" + _username + "'";
            
            DataSet ds = new DataSet();

            da = new SqlDataAdapter(sql_query, cn);
            da.Fill(ds);

            dataGridView.DataSource = ds.Tables[0];

            dataGridView.Columns[0].HeaderText = "Thời gian";
            dataGridView.Columns[1].HeaderText = "Điểm đi";
            dataGridView.Columns[2].HeaderText = "Điểm đến";
            dataGridView.Columns[3].HeaderText = "Loại xe";
            dataGridView.Columns[4].HeaderText = "Giá";
        }
        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home(_fullname, _username);
            home.ShowDialog();
        }
        private void btn_booking_Click(object sender, EventArgs e)
        {
            this.Close();
            BookingForCustomer bookingDrive = new BookingForCustomer(_fullname, _username);
            bookingDrive.Show();
        }

        private void btn_wallet_Click(object sender, EventArgs e)
        {
            this.Close();
            Wallet wallet = new Wallet(_fullname, _username);
            wallet.ShowDialog();
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4) // Chỉ định cột cần định dạng
            {
                if (e.Value != null)
                {
                    int value = Convert.ToInt32(e.Value);
                    e.Value = value.ToString("N0").Replace(",", ".");
                }
            }
        }

        private void History_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
