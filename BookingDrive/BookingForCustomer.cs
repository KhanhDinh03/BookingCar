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

namespace BookingDrive
{
    public partial class BookingForCustomer : Form
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

        private List<PointLatLng> _points;
        public BookingForCustomer(string fullname, string username)
        {
            InitializeComponent();
            tb_mylocation.Enabled = false;
            _points = new List<PointLatLng>();
            _username = username;
            _fullname = fullname;
        }

        private void BookingForCustomer_Load(object sender, EventArgs e)
        {

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
            if (gmap.Overlays.Count > 0)
            {
                gmap.Overlays.RemoveAt(0);
                gmap.Overlays.RemoveAt(1);
            }
            gmap.Refresh();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cb_destination.SelectedIndex != -1 || cb_type.SelectedIndex != -1)
            {
                double distance = 0;

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

                distance = route.Distance;

                if (cb_type.SelectedItem.ToString() == "Xe 4 chỗ")
                {
                    // Giá 1 cây bằng 10.000 vnd
                    // Giá xe 4 chỗ là 30.000 vnd
                    double price = 0;

                    price = 10000 * distance + 30000;

                    DialogResult dialogResult = MessageBox.Show("Quý khách muốn đi đến " + cb_destination.SelectedItem.ToString() + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        string sql_query =  "SELECT balance FROM Customers " +
                                            "WHERE username='" + _username + "'";

                        cmd = new SqlCommand(sql_query, cn);
                        dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            if (dr.GetDouble(0) >= price)
                            {
                                MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK);
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
                                break;
                            }
                            else
                            {
                                dr.Close();
                                MessageBox.Show("Số dư trong tài khoản quý khách không đủ! Vui lòng nạp thêm", "Thông báo", MessageBoxButtons.OK);
                                break;
                            }
                        }
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
