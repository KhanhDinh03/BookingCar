using Newtonsoft.Json;
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

namespace BookingDrive
{
    public partial class BookingForCustomer : Form
    {
        public class location
        {
            public string Address { get; set; }
            public double Longitude {get; set; }
            public double Latitude { get; set; }
        }

        public BookingForCustomer()
        {
            InitializeComponent();
        }

        private void BookingForCustomer_Load(object sender, EventArgs e)
        {
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }
    }
}
