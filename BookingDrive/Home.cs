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

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {

        }
    }
}
