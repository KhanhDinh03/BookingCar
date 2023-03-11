namespace BookingDrive
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.btn_register = new System.Windows.Forms.Button();
            this.linklb_login = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_confirmpassword = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_fullname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_hidepassword = new System.Windows.Forms.Button();
            this.btn_hidecfpassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(176, 405);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(113, 28);
            this.btn_register.TabIndex = 9;
            this.btn_register.Text = "Đăng kí";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // linklb_login
            // 
            this.linklb_login.AutoSize = true;
            this.linklb_login.Location = new System.Drawing.Point(141, 450);
            this.linklb_login.Name = "linklb_login";
            this.linklb_login.Size = new System.Drawing.Size(201, 13);
            this.linklb_login.TabIndex = 10;
            this.linklb_login.TabStop = true;
            this.linklb_login.Text = "Bạn đã có tài khoản? Đăng nhập tại đây";
            this.linklb_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklb_login_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(170, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Đăng kí";
            // 
            // tb_confirmpassword
            // 
            this.tb_confirmpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_confirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_confirmpassword.Location = new System.Drawing.Point(204, 213);
            this.tb_confirmpassword.Name = "tb_confirmpassword";
            this.tb_confirmpassword.Size = new System.Drawing.Size(238, 22);
            this.tb_confirmpassword.TabIndex = 4;
            // 
            // tb_password
            // 
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(204, 170);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(238, 22);
            this.tb_password.TabIndex = 3;
            // 
            // tb_username
            // 
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(204, 127);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(238, 22);
            this.tb_username.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên đăng nhập";
            // 
            // tb_phone
            // 
            this.tb_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_phone.Location = new System.Drawing.Point(204, 304);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(238, 22);
            this.tb_phone.TabIndex = 6;
            this.tb_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_phone_KeyPress);
            // 
            // tb_fullname
            // 
            this.tb_fullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fullname.Location = new System.Drawing.Point(204, 261);
            this.tb_fullname.Name = "tb_fullname";
            this.tb_fullname.Size = new System.Drawing.Size(238, 22);
            this.tb_fullname.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Số điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Họ và tên";
            // 
            // btn_hidepassword
            // 
            this.btn_hidepassword.Image = ((System.Drawing.Image)(resources.GetObject("btn_hidepassword.Image")));
            this.btn_hidepassword.Location = new System.Drawing.Point(454, 172);
            this.btn_hidepassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_hidepassword.Name = "btn_hidepassword";
            this.btn_hidepassword.Size = new System.Drawing.Size(20, 19);
            this.btn_hidepassword.TabIndex = 22;
            this.btn_hidepassword.UseVisualStyleBackColor = true;
            this.btn_hidepassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_hidepassword_MouseDown);
            this.btn_hidepassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_hidepassword_MouseUp);
            // 
            // btn_hidecfpassword
            // 
            this.btn_hidecfpassword.Image = ((System.Drawing.Image)(resources.GetObject("btn_hidecfpassword.Image")));
            this.btn_hidecfpassword.Location = new System.Drawing.Point(454, 215);
            this.btn_hidecfpassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_hidecfpassword.Name = "btn_hidecfpassword";
            this.btn_hidecfpassword.Size = new System.Drawing.Size(20, 19);
            this.btn_hidecfpassword.TabIndex = 23;
            this.btn_hidecfpassword.UseVisualStyleBackColor = true;
            this.btn_hidecfpassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_hidecfpassword_MouseDown);
            this.btn_hidecfpassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_hidecfpassword_MouseUp);
            // 
            // Register
            // 
            this.AcceptButton = this.btn_register;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 482);
            this.Controls.Add(this.btn_hidecfpassword);
            this.Controls.Add(this.btn_hidepassword);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.tb_fullname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_confirmpassword);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linklb_login);
            this.Controls.Add(this.btn_register);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng kí";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.LinkLabel linklb_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_confirmpassword;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_fullname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_hidepassword;
        private System.Windows.Forms.Button btn_hidecfpassword;
    }
}