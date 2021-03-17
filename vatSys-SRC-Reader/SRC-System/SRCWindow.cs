using System;
using System.Collections.Generic;
using vatsys;
using System.Linq;
using System.Xml;
using AISTools;
namespace SRC_System
{
    public partial class SRCWindow : BaseForm
    {
        public SRCWindow()
        {
            InitializeComponent();
            LoadRoutes();
        }
        void LoadRoutes()
        {
            XmlDocument xmlDoc = new XmlDocument();     
            xmlDoc.Load(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/Documents/vatSys Files/Profiles/New Zealand/Plugins/SRC-System/Routes.xml"); 
            foreach(XmlNode x in xmlDoc.ChildNodes)
            {
                foreach(XmlNode i in x.ChildNodes)
                {
                    routes.Add(new StandardRoute(i.Attributes.GetNamedItem("ID").Value, i.InnerText, i.Attributes.GetNamedItem("Remarks").Value));
                }
            }
        }
        public List<StandardRoute> routes = new List<StandardRoute>();
        private void RouteDesignator_Change(object sender, EventArgs e)
        {
            if (sender == this)
                return;
            string selectedDesignator = routeDesignatorInput.Text;
            if (routes.Select(x => x.Designator).Contains(selectedDesignator))
            {
                var routeObj = routes.Find(x => x.Designator == selectedDesignator);
                routing.Text = "Route: " + routeObj.Routing;
                if (routeObj.Remarks == "")
                    routeRemarks.Text = "Remarks: NONE ";
                else
                    routeRemarks.Text = "Remarks: " + routeObj.Remarks;
            }
            else
            {
                routing.Text = "Route: NONE";
                routeRemarks.Text = "Remarks: NONE";
            }
        }
        private void Routing_Change(object sender, EventArgs e)
        {
            if (sender == this)
                return;
            string selectedRouting = routingInput.Text;
            bool routeExists = false;
            StandardRoute foundRoute = new StandardRoute();
            foreach (var x in routes)
            {
                if (x.Routing.Contains(selectedRouting))
                {
                    routeExists = true;
                    foundRoute = x;
                    break;
                }
            }
            if (routeExists)
            {
                routeDesignator.Text = "Route: " + foundRoute.Designator;
                if (foundRoute.Remarks == "")
                    routeRemarks.Text = "Remarks: NONE ";
                else
                    routeRemarks.Text = "Remarks: " + foundRoute.Remarks;
            }
            else
            {
                routeDesignator.Text = "Designator: NONE";
                routeRemarks.Text = "Remarks: NONE";
            }
        }
    }
    public struct StandardRoute
    {
        public string Designator;
        public string Routing;
        public string Remarks;
        public StandardRoute(string designator, string routing, string remarks)
        {
            Designator = designator;
            Routing = routing;
            Remarks = remarks;
        }
    }
}
