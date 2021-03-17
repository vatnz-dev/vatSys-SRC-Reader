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
            string location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            location = location.Substring(0, location.Length - System.Reflection.Assembly.GetExecutingAssembly().GetName().Name.Length-4) + "/SRC-System/Routes.xml";
            xmlDoc.Load(location); 
            
            
            foreach(XmlNode x in xmlDoc.ChildNodes[0].ChildNodes)
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
                if (x.Routing == selectedRouting)
                {
                    routeExists = true;
                    foundRoute = x;
                    break;
                }
            }
            if (routeExists)
            {
                routeDesignator.Text = "Designator: " + foundRoute.Designator;
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
        private void FromTo_Change(object sender, EventArgs e)
        {
            string options = "";
            if (fromInput.Text.Length > 3 && toInput.Text.Length > 3)
            {
                foreach (var x in routes.Where(d => d.Designator.Substring(0, 2) == fromInput.Text.Substring(2, 2)).Where(a => a.Designator.Substring(2, 2) == toInput.Text.Substring(2, 2)))
                {
                    options += x.Designator + " | " + x.Routing;
                    if (x.Remarks != "")
                        options += " | " + x.Remarks;
                    options += "\n";
                }
            }
            SRCOptions.Text = options;
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
