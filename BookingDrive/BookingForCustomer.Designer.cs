namespace BookingDrive
{
    partial class BookingForCustomer
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
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_mylocation = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_wallet = new System.Windows.Forms.Button();
            this.btn_history = new System.Windows.Forms.Button();
            this.btn_booking = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.cb_destination = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.gmap.Location = new System.Drawing.Point(0, 147);
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
            this.gmap.Size = new System.Drawing.Size(784, 461);
            this.gmap.TabIndex = 11;
            this.gmap.Zoom = 0D;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(446, 107);
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
            this.tb_mylocation.Enabled = false;
            this.tb_mylocation.Location = new System.Drawing.Point(124, 39);
            this.tb_mylocation.Name = "tb_mylocation";
            this.tb_mylocation.Size = new System.Drawing.Size(152, 20);
            this.tb_mylocation.TabIndex = 1;
            this.tb_mylocation.Text = "Đại học Thuỷ Lợi";
            this.tb_mylocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 53);
            this.tableLayoutPanel1.TabIndex = 9;
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
            this.btn_wallet.Click += new System.EventHandler(this.btn_wallet_Click);
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
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_refresh);
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
            this.panel1.TabIndex = 10;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(574, 107);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(90, 23);
            this.btn_refresh.TabIndex = 9;
            this.btn_refresh.Text = "Làm mới";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // cb_destination
            // 
            this.cb_destination.FormattingEnabled = true;
            this.cb_destination.Location = new System.Drawing.Point(492, 39);
            this.cb_destination.Name = "cb_destination";
            this.cb_destination.Size = new System.Drawing.Size(152, 21);
            this.cb_destination.TabIndex = 8;
            this.cb_destination.SelectedIndexChanged += new System.EventHandler(this.cb_destination_SelectedIndexChanged);
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
            this.cb_type.Items.AddRange(new object[] {
            "Xe 4 chỗ",
            "Xe 7 chỗ"});
            this.cb_type.Location = new System.Drawing.Point(124, 109);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(152, 21);
            this.cb_type.TabIndex = 6;
            this.cb_type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_type_KeyPress);
            // 
            // BookingForCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.gmap);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BookingForCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt xe";
            this.Load += new System.EventHandler(this.BookingForCustomer_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_mylocation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_wallet;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.Button btn_booking;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.ComboBox cb_destination;
        private System.Windows.Forms.Button btn_refresh;
    }
}