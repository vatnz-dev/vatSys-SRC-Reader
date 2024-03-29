﻿using System;
using System.Collections.Generic;
using vatsys;
using System.Linq;
using System.Xml;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace SRC_System
{
    public partial class SRCWindow : BaseForm
    {
        public SRCWindow()
        {
            InitializeComponent();
            RouteUtil.RouteUtil.LoadRoutes(this, openFileDialog1);
        }
        private void RouteDesignator_Change(object sender, EventArgs e)
        {
            RouteUtil.RouteUtil.RouteDesignator_Change(routeDesignatorInput, routing, routeRemarks, fromInput, toInput);
        }
        private void Routing_Change(object sender, EventArgs e)
        {
            RouteUtil.RouteUtil.Routing_Change(routingInput, routeDesignator, routeRemarks, fromInput, toInput);
        }
        private void FromTo_Change(object sender, EventArgs e)
        {
            RouteUtil.RouteUtil.FromTo_Change(fromInput, toInput, this, routeDesignatorInput, routingInput);
        }
        private void routing_Click(object sender, EventArgs e)
        {
            RouteUtil.RouteUtil.routing_Click(routing);
        }
        private void routeDesignator_Click(object sender, EventArgs e)
        {
            RouteUtil.RouteUtil.routeDesignator_Click(routeDesignator);
        }
        private void routeRemarks_Click(object sender, EventArgs e)
        {
            RouteUtil.RouteUtil.routeRemarks_Click(routeRemarks, this);
        }

        private void SRCWindow_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
