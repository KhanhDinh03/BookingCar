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
    public partial class Login : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        string fullname, username;

        string connection_string = @"Data Source=KHANHDINH; " +
                                    "Initial Catalog=Data_Account; " +
                                    "Integrated Security=True";

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(connection_string);
            cn.Open();
            tb_password.PasswordChar = '*';
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_username.Text != string.Empty || tb_password.Text != string.Empty)
            {  
                string sql_query = "SELECT * FROM Customers " +
                                    "WHERE username = '" + tb_username.Text + "' AND password = '" + tb_password.Text + "'";
                cmd = new SqlCommand(sql_query, cn);
                dr = cmd.ExecuteReader();
                    
                if (dr.Read())
                {
                    dr.Close();
                    string sql_query1 = "SELECT fullname, username FROM Customers " +
                                "WHERE username = '" + tb_username.Text + "'";
                    cmd = new SqlCommand(sql_query1, cn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        fullname = dr.GetString(0);
                        username = dr.GetString(1);
                    }
                    this.Hide();
                    Home home = new Home(fullname, username);                   
                    home.ShowDialog();
                }
                else
                {
                        
                    dr.Close();
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Bạn muốn thoát chương trình?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void linklb_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
        }

        private void btn_hidepassword_MouseDown(object sender, MouseEventArgs e)
        {
            tb_password.PasswordChar = '\0';
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_hidepassword_MouseUp(object sender, MouseEventArgs e)
        {
            tb_password.PasswordChar = '*';
        }
    }
}
