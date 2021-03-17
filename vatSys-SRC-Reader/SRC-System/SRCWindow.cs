using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vatsys;

namespace SRC_System
{
    public partial class SRCWindow : BaseForm
    {
        public SRCWindow()
        {
            InitializeComponent();
            Console.WriteLine("SRC System Available");
        }
        private void RouteDesignator_Change(object sender, EventArgs e)
        {
            if (sender == this)
                return;
            if (routingInput.Text == "AACH1")
                routing.Text = "H384 NP H252 NS Y288";
            else
                routing.Text = "SRC Unavailable";
        }
        private void Routing_Change(object sender, EventArgs e)
        {
            if (sender == this)
                return;
            if (routingInput.Text == "H384 NP H252 NS Y288")
                routeDesignator.Text = "AACH1";

        }
    }
}
