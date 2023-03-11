namespace BookingDrive
{
    partial class Wallet
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_wallet = new System.Windows.Forms.Button();
            this.btn_history = new System.Windows.Forms.Button();
            this.btn_booking = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_balance = new System.Windows.Forms.Label();
            this.btn_deposit = new System.Windows.Forms.Button();
            this.btn_withdraw = new System.Windows.Forms.Button();
            this.lb_welcome = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn_home, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_wallet, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_history, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_booking, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 608);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 53);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btn_home
            // 
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_home.Location = new System.Drawing.Point(3, 3);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(190, 47);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "Trang chủ";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_wallet
            // 
            this.btn_wallet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_wallet.Location = new System.Drawing.Point(591, 3);
            this.btn_wallet.Name = "btn_wallet";
            this.btn_wallet.Size = new System.Drawing.Size(190, 47);
            this.btn_wallet.TabIndex = 1;
            this.btn_wallet.Text = "Ví";
            this.btn_wallet.UseVisualStyleBackColor = true;
            // 
            // btn_history
            // 
            this.btn_history.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_history.Location = new System.Drawing.Point(395, 3);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(190, 47);
            this.btn_history.TabIndex = 2;
            this.btn_history.Text = "Lịch sử";
            this.btn_history.UseVisualStyleBackColor = true;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // btn_booking
            // 
            this.btn_booking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_booking.Location = new System.Drawing.Point(199, 3);
            this.btn_booking.Name = "btn_booking";
            this.btn_booking.Size = new System.Drawing.Size(190, 47);
            this.btn_booking.TabIndex = 3;
            this.btn_booking.Text = "Đặt xe";
            this.btn_booking.UseVisualStyleBackColor = true;
            this.btn_booking.Click += new System.EventHandler(this.btn_booking_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 100);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ví";
            // 
            // lb_balance
            // 
            this.lb_balance.AutoSize = true;
            this.lb_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_balance.Location = new System.Drawing.Point(23, 215);
            this.lb_balance.Name = "lb_balance";
            this.lb_balance.Size = new System.Drawing.Size(99, 31);
            this.lb_balance.TabIndex = 1;
            this.lb_balance.Text = "Số dư: ";
            // 
            // btn_deposit
            // 
            this.btn_deposit.Location = new System.Drawing.Point(47, 408);
            this.btn_deposit.Name = "btn_deposit";
            this.btn_deposit.Size = new System.Drawing.Size(190, 50);
            this.btn_deposit.TabIndex = 6;
            this.btn_deposit.Text = "Nạp tiền";
            this.btn_deposit.UseVisualStyleBackColor = true;
            this.btn_deposit.Click += new System.EventHandler(this.btn_deposit_Click);
            // 
            // btn_withdraw
            // 
            this.btn_withdraw.Location = new System.Drawing.Point(529, 408);
            this.btn_withdraw.Name = "btn_withdraw";
            this.btn_withdraw.Size = new System.Drawing.Size(190, 50);
            this.btn_withdraw.TabIndex = 7;
            this.btn_withdraw.Text = "Rút tiền";
            this.btn_withdraw.UseVisualStyleBackColor = true;
            this.btn_withdraw.Click += new System.EventHandler(this.btn_withdraw_Click);
            // 
            // lb_welcome
            // 
            this.lb_welcome.AutoSize = true;
            this.lb_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_welcome.Location = new System.Drawing.Point(23, 145);
            this.lb_welcome.Name = "lb_welcome";
            this.lb_welcome.Size = new System.Drawing.Size(141, 31);
            this.lb_welcome.TabIndex = 8;
            this.lb_welcome.Text = "Xin chào,  ";
            // 
            // Wallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.lb_welcome);
            this.Controls.Add(this.btn_withdraw);
            this.Controls.Add(this.btn_deposit);
            this.Controls.Add(this.lb_balance);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Wallet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wallet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Wallet_FormClosing);
            this.Load += new System.EventHandler(this.Wallet_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_wallet;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.Button btn_booking;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_balance;
        private System.Windows.Forms.Button btn_deposit;
        private System.Windows.Forms.Button btn_withdraw;
        private System.Windows.Forms.Label lb_welcome;
    }
}