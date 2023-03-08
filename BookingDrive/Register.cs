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
                                    "Initial Catalog=DataBase_Account; " +
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
            if (cb_type.Text != string.Empty || tb_password.Text != string.Empty || tb_username.Text != string.Empty || tb_fullname.Text != string.Empty || tb_phone.Text != string.Empty)
            {
                if (tb_password.Text == tb_confirmpassword.Text)
                {
                    if (cb_type.Text == "Người dùng")
                    {
                        string sql_query = "SELECT * FROM Customers " +
                                        "WHERE username='" + tb_username.Text + "'";

                        cmd = new SqlCommand(sql_query, cn);
                        dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            dr.Close();
                            MessageBox.Show("Tên đăng nhập đã tồn tại vui lòng thử tên khác!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string sql_insert = "INSERT INTO Customers(username, password, phone, fullname) " +
                                         "VALUES('" + tb_username.Text + "' ,'" + tb_password.Text + "', '" + tb_phone.Text + "', N'" + tb_fullname.Text + "')";
                            dr.Close();
                            cmd = new SqlCommand(sql_insert, cn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Tạo tài khoản thành công! Đăng nhập ngay bây giờ", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    if (cb_type.Text == "Người lái xe")
                    {
                        string sql_query = "SELECT * FROM Drivers " +
                                        "WHERE username='" + tb_username.Text + "'";
                        cmd = new SqlCommand(sql_query, cn);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            MessageBox.Show("Tên đăng nhập đã tồn tại vui lòng thử tên khác!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string sql_insert = "INSERT INTO Drivers(username, password, phone, fullname) " +
                                                "VALUES('" + tb_username.Text + "' ,'" + tb_password.Text + "', '" + tb_phone.Text + "', N'" + tb_fullname.Text + "')";
                            dr.Close();
                            cmd = new SqlCommand(sql_insert, cn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Tạo tài khoản thành công! Đăng nhập ngay bây giờ", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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

        private void tb_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cb_type_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_type.SelectedIndex == 0)
            {
                ComboBox comboBox = new ComboBox();
                comboBox.Location = new Point(204, 354);
                comboBox.Name = "cb_typecar";
                comboBox.Size = new Size(238, 21);

                Label label = new Label();
                label.Location = new Point(22, 354);
                label.Text = "Loại xe";
                label.Size = new Size(75, 25);
                label.Font = new Font(label.Font.FontFamily, 15);

                this.Controls.Add(label);
                this.Controls.Add(comboBox);

                comboBox.Items.Add("Xe 4 chỗ");
                comboBox.Items.Add("Xe 7 chỗ");
            }
        }
    }
}
