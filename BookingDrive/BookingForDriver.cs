using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Newtonsoft.Json;
using System.IO;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace BookingDrive
{
    public partial class BookingForDriver : Form
    {
        public class location
        {
            public string Address { get; set; }
            public double Longitude { get; set; }
            public double Latitude { get; set; }
        }

        private List<PointLatLng> _point;

        public BookingForDriver()
        {
            InitializeComponent();

            tb_mylocation.Enabled = false;

            _point = new List<PointLatLng>();
            
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            gmap.ShowCenter = false;
            gmap.DragButton = MouseButtons.Left;
            gmap.MapProvider = GMapProviders.GoogleMap;
            gmap.Position = new PointLatLng(21.007546886760228, 105.82475186042338); // Tọa độ Đh thuỷ lợi
            gmap.MinZoom = 1;
            gmap.MaxZoom = 20;
            gmap.Zoom = 10;

            GMapOverlay markersOverlay = new GMapOverlay("markers");
            gmap.Overlays.Add(markersOverlay);

            // Khởi tạo đánh dấu của bạn
            GMapMarker marker = new GMarkerGoogle(gmap.Position, GMarkerGoogleType.red_dot);

            // Thêm đánh dấu vào lớp GMapOverlay
            markersOverlay.Markers.Add(marker);

            string json = File.ReadAllText(@"C:\Users\KhanhDinh\Desktop\BookingDrive\BookingDrive\location.json");
            JObject data = JObject.Parse(json);

            List<string> addresses = data["location"].Select(x => (string)x["Address"]).ToList();
            cb_destination.Items.AddRange(addresses.ToArray());
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            /*
            if (cb_destination.Text )
            {

            }*/
        }

        private void cb_destination_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
