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
    public partial class Register : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        string connection_string =  @"Data Source=KHANHDINH; " +
                                    "Initial Catalog=Data_Account; " +
                                    "Integrated Security=True";

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(connection_string);
            cn.Open();
            tb_password.PasswordChar = '*';
            tb_confirmpassword.PasswordChar = '*';
        }

        private void linklb_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (tb_confirmpassword.Text != string.Empty || tb_password.Text != string.Empty || tb_username.Text != string.Empty)
            {
                if (tb_password.Text == tb_confirmpassword.Text)
                {
                    string sql_query =  "SELECT * FROM LoginTable " +
                                        "WHERE username='" + tb_username.Text + "'";
                    cmd = new SqlCommand(sql_query, cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Tên người dùng đã tồn tại vui lòng thử tên khác!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string sql_insert = "INSERT INTO LoginTable " +
                                            "VALUES('" + tb_username.Text + "' ,'" + tb_password.Text + "')";
                        dr.Close();
                        cmd = new SqlCommand(sql_insert, cn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Tạo tài khoản thành công! Đăng nhập ngay bây giờ", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập cả hai mật khẩu giống nhau!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
