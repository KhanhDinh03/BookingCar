﻿namespace BookingDrive
{
    partial class Deposit
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
            this.btn_deposit = new System.Windows.Forms.Button();
            this.btn_forward = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_money = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_deposit
            // 
            this.btn_deposit.Location = new System.Drawing.Point(272, 333);
            this.btn_deposit.Name = "btn_deposit";
            this.btn_deposit.Size = new System.Drawing.Size(109, 38);
            this.btn_deposit.TabIndex = 0;
            this.btn_deposit.Text = "Nạp";
            this.btn_deposit.UseVisualStyleBackColor = true;
            this.btn_deposit.Click += new System.EventHandler(this.btn_deposit_Click);
            // 
            // btn_forward
            // 
            this.btn_forward.Location = new System.Drawing.Point(22, 37);
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Size = new System.Drawing.Size(75, 23);
            this.btn_forward.TabIndex = 1;
            this.btn_forward.Text = "Trở lại";
            this.btn_forward.UseVisualStyleBackColor = true;
            this.btn_forward.Click += new System.EventHandler(this.btn_forward_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_forward);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 100);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nạp tiền";
            // 
            // tb_money
            // 
            this.tb_money.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_money.Location = new System.Drawing.Point(183, 255);
            this.tb_money.Name = "tb_money";
            this.tb_money.Size = new System.Drawing.Size(286, 20);
            this.tb_money.TabIndex = 6;
            this.tb_money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_money_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhập số tiền muốn nạp";
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_money);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_deposit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Deposit_FormClosing);
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_deposit;
        private System.Windows.Forms.Button btn_forward;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_money;
        private System.Windows.Forms.Label label2;
    }
}