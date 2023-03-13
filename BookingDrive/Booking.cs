using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using GMap.NET;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Xamarin.Forms.GoogleMaps;
using System.Diagnostics;

namespace BookingDrive
{
    public partial class Booking : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        string connection_string = @"Data Source=KHANHDINH; " +
                                    "Initial Catalog=Data_Account; " +
                                    "Integrated Security=True";
        double lat, lng;
        string _username = "";
        string _fullname = "";

        bool check = false;

        private List<PointLatLng> _points;
        public Booking(string fullname, string username)
        {
            InitializeComponent();
            tb_mylocation.Enabled = false;
            _points = new List<PointLatLng>();
            _username = username;
            _fullname = fullname;
        }

        private void BookingForCustomer_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(connection_string);
            cn.Open();
            gmap.ShowCenter = false;
            gmap.DragButton = MouseButtons.Left;
            gmap.MapProvider = GMapProviders.GoogleMap;
            gmap.Position = new PointLatLng(21.007818087264067, 105.8237949069307); // Tọa độ Đh thuỷ lợi
            _points.Add(gmap.Position);
            gmap.MinZoom = 1;
            gmap.MaxZoom = 18;
            gmap.Zoom = 15;

            GMapOverlay markersOverlay = new GMapOverlay("markers");
            gmap.Overlays.Add(markersOverlay);

            // Khởi tạo đánh dấu của bạn
            GMapMarker marker = new GMarkerGoogle(gmap.Position, GMarkerGoogleType.red_dot);

            // Thêm đánh dấu vào lớp GMapOverlay
            markersOverlay.Markers.Add(marker);

            string sql_query = "SELECT address FROM Locations";

            cmd = new SqlCommand(sql_query, cn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string value = dr.GetString(0);
                cb_destination.Items.Add(value);

            }
            dr.Close();
        }

        private void cb_destination_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_type_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_destination_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql_query = "SELECT longtitude, latitude FROM Locations " +
                                "WHERE address=N'" + cb_destination.SelectedItem.ToString() + "'";
            
            cmd = new SqlCommand(sql_query, cn);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                lng = dr.GetDouble(0);
                lat = dr.GetDouble(1);
                dr.Close();
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home(_fullname, _username);
            home.ShowDialog();
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            this.Hide();
            History history = new History(_fullname, _username);
            history.ShowDialog();
        }

        private void btn_wallet_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wallet wallet = new Wallet(_fullname, _username);
            wallet.ShowDialog();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            
            if (check)
            {
                if (gmap.Overlays.Count > 2)
                {
                    gmap.Overlays.RemoveAt(0);
                    gmap.Overlays.RemoveAt(1);
                    gmap.Refresh();
                }
            }
            else
            {
                if (gmap.Overlays.Count > 2)
                {
                    gmap.Overlays.RemoveAt(0);
                    gmap.Overlays.RemoveAt(1);
                    gmap.Overlays.RemoveAt(0);
                    gmap.Refresh();
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cb_destination.SelectedIndex != -1 && cb_type.SelectedIndex != -1)
            {
                if (cb_type.SelectedItem.ToString() == "Xe 4 chỗ")
                {
                    _points.Add(new PointLatLng(lat, lng));
                    GMapOverlay markersOverlay = new GMapOverlay("markers");
                    GMapMarker marker = new GMarkerGoogle(_points[1], GMarkerGoogleType.red_dot);
                    markersOverlay.Markers.Add(marker);
                    gmap.Overlays.Add(markersOverlay);

                    MapRoute route = OpenCycleTransportMapProvider.Instance.GetRoute(_points[0], _points[1], false, false, 15);
                    GMapRoute r = new GMapRoute(route.Points, "Myroutes");
                    GMapOverlay routesOverlay = new GMapOverlay("Myroutes");
                    routesOverlay.Routes.Add(r);
                    gmap.Overlays.Add(routesOverlay);
                    r.Stroke.Width = 5;
                    r.Stroke.Color = Color.Red;

                    gmap.Refresh();

                    double distance = route.Distance;

                    // Giá 1 cây bằng 10.000 vnd
                    // Giá xe 4 chỗ là 30.000 vnd

                    double price = 10000 * distance + 30000;
                    string formatted_x = price.ToString("N0");
                    formatted_x = formatted_x.Replace(",", ".");
                    DialogResult dialogResult = MessageBox.Show("Quý khách muốn đi đến " + cb_destination.SelectedItem.ToString() + ".\nKhoảng cách là: " + distance + " Km.\nCước phí là: " + formatted_x + " VNĐ.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (dialogResult == DialogResult.Yes)
                    {
                        string sql_query =  "SELECT balance FROM Customers " +
                                            "WHERE username='" + _username + "'";

                        cmd = new SqlCommand(sql_query, cn);
                        dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            if (dr.GetDouble(0) >= price)
                            {
                                MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK);
                                check = true;
                                gmap.Position = _points[1];
                                gmap.Refresh();
                                double update_wallet = dr.GetDouble(0) - price;
                                dr.Close();

                                string sql_update_insert =  "UPDATE Customers " +
                                                            "SET balance = " + update_wallet + " " +
                                                            "WHERE username='" + _username + "' " +
                                                            "INSERT INTO HistoryForCustomers " +
                                                            "VALUES (N'" + tb_mylocation.Text + "', N'" + cb_destination.SelectedItem.ToString() + "', '" + _username + "', '" + Convert.ToDateTime(DateTime.Now.ToString("dd MMM yyyy, hh:mm:ss tt")) + "', N'" + cb_type.SelectedItem.ToString() + "', " + price + ")";

                                cmd = new SqlCommand(sql_update_insert, cn);
                                dr = cmd.ExecuteReader();
                                dr.Close();
                                tb_mylocation.Text = cb_destination.SelectedItem.ToString();
                                _points.RemoveAt(0);
                            }
                            else
                            {
                                dr.Close();
                                MessageBox.Show("Số dư trong tài khoản quý khách không đủ! Vui lòng nạp thêm", "Thông báo", MessageBoxButtons.OK);
                                check = false;
                                _points.RemoveAt(1);
                            }
                        }
                    }
                    else
                    {
                        _points.RemoveAt(1);
                        btn_refresh.PerformClick();
                    }
                }
                if (cb_type.SelectedItem.ToString() == "Xe 7 chỗ")
                {
                    _points.Add(new PointLatLng(lat, lng));
                    GMapOverlay markersOverlay = new GMapOverlay("markers");
                    GMapMarker marker = new GMarkerGoogle(_points[1], GMarkerGoogleType.red_dot);
                    markersOverlay.Markers.Add(marker);
                    gmap.Overlays.Add(markersOverlay);

                    MapRoute route = OpenCycleTransportMapProvider.Instance.GetRoute(_points[0], _points[1], false, false, 15);
                    GMapRoute r = new GMapRoute(route.Points, "Myroutes");
                    GMapOverlay routesOverlay = new GMapOverlay("Myroutes");
                    routesOverlay.Routes.Add(r);
                    gmap.Overlays.Add(routesOverlay);
                    r.Stroke.Width = 5;
                    r.Stroke.Color = Color.Red;

                    gmap.Refresh();

                    double distance = route.Distance;

                    // Giá 1 cây bằng 15.000 vnd
                    // Giá xe 7 chỗ là 50.000 vnd

                    double price = 15000 * distance + 50000;
                    string formatted_x = price.ToString("N0");
                    formatted_x = formatted_x.Replace(",", ".");
                    DialogResult dialogResult = MessageBox.Show("Quý khách muốn đi đến " + cb_destination.SelectedItem.ToString() + ".\nKhoảng cách là: " + distance + " Km.\nCước phí là: " + formatted_x + " VNĐ.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        string sql_query = "SELECT balance FROM Customers " +
                                            "WHERE username='" + _username + "'";

                        cmd = new SqlCommand(sql_query, cn);
                        dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            if (dr.GetDouble(0) >= price)
                            {
                                MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK);
                                check = true;
                                gmap.Position = _points[1];
                                gmap.Refresh();
                                double update_wallet = dr.GetDouble(0) - price;
                                dr.Close();

                                string sql_update_insert = "UPDATE Customers " +
                                                            "SET balance = " + update_wallet + " " +
                                                            "WHERE username='" + _username + "' " +
                                                            "INSERT INTO HistoryForCustomers " +
                                                            "VALUES (N'" + tb_mylocation.Text + "', N'" + cb_destination.SelectedItem.ToString() + "', '" + _username + "', '" + Convert.ToDateTime(DateTime.Now.ToString("dd MMM yyyy, hh:mm:ss tt")) + "', N'" + cb_type.SelectedItem.ToString() + "', " + price + ")";

                                cmd = new SqlCommand(sql_update_insert, cn);
                                dr = cmd.ExecuteReader();
                                dr.Close();
                                tb_mylocation.Text = cb_destination.SelectedItem.ToString();
                                _points.RemoveAt(0);
                            }
                            else
                            {
                                dr.Close();
                                MessageBox.Show("Số dư trong tài khoản quý khách không đủ! Vui lòng nạp thêm", "Thông báo", MessageBoxButtons.OK);
                                check = false;
                                _points.RemoveAt(1);
                            }
                        }
                    }
                    else
                    {
                        _points.RemoveAt(1);
                        btn_refresh.PerformClick();
                    }
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin chuyến đi!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
