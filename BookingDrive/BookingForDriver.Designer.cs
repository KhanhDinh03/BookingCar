namespace BookingDrive
{
    partial class BookingForDriver
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
            this.btn_notification = new System.Windows.Forms.Button();
            this.btn_booking = new System.Windows.Forms.Button();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_destination = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_mylocation = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.Controls.Add(this.btn_notification, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_booking, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 608);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 53);
            this.tableLayoutPanel1.TabIndex = 6;
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
            // btn_notification
            // 
            this.btn_notification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_notification.Location = new System.Drawing.Point(395, 3);
            this.btn_notification.Name = "btn_notification";
            this.btn_notification.Size = new System.Drawing.Size(190, 47);
            this.btn_notification.TabIndex = 2;
            this.btn_notification.Text = "Thông báo";
            this.btn_notification.UseVisualStyleBackColor = true;
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
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemory = 5;
            this.gmap.Location = new System.Drawing.Point(0, 0);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 2;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(784, 608);
            this.gmap.TabIndex = 8;
            this.gmap.Zoom = 0D;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_destination);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cb_type);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_mylocation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 147);
            this.panel1.TabIndex = 11;
            // 
            // cb_destination
            // 
            this.cb_destination.FormattingEnabled = true;
            this.cb_destination.Location = new System.Drawing.Point(492, 39);
            this.cb_destination.Name = "cb_destination";
            this.cb_destination.Size = new System.Drawing.Size(152, 21);
            this.cb_destination.TabIndex = 9;
            this.cb_destination.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_destination_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lựa chọn loại xe";
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(124, 109);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(152, 21);
            this.cb_type.TabIndex = 6;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(523, 107);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(90, 23);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Tìm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vị trí hiện tại của bạn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vị trí bạn muốn tới";
            // 
            // tb_mylocation
            // 
            this.tb_mylocation.Location = new System.Drawing.Point(124, 39);
            this.tb_mylocation.Name = "tb_mylocation";
            this.tb_mylocation.Size = new System.Drawing.Size(152, 20);
            this.tb_mylocation.TabIndex = 1;
            this.tb_mylocation.Text = "Đại học Thuỷ Lợi";
            this.tb_mylocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BookingForDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gmap);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BookingForDriver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt xe";
            this.Load += new System.EventHandler(this.Booking_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_wallet;
        private System.Windows.Forms.Button btn_notification;
        private System.Windows.Forms.Button btn_booking;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_mylocation;
        private System.Windows.Forms.ComboBox cb_destination;
    }
}