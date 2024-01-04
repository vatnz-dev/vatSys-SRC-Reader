using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;
using System.Xml;
using System.Net;
namespace RouteUtil
{
    public static class RouteUtil
    {
        public static void LoadRoutes(Form form, OpenFileDialog openFileDialog1)
        {
            if (routes.Count > 0)
                return;

            routes.Clear();

            string LocalExecutablePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string LocalDir = LocalExecutablePath.Substring(0, LocalExecutablePath.Length - System.Reflection.Assembly.GetExecutingAssembly().GetName().Name.Length - 4);
            string LocalSRCSystemDir = LocalDir + "/SRC-System";
            string LocalRoutesPath = LocalSRCSystemDir + "/Routes.xml";
            string RemoteRoutesURL = "https://raw.githubusercontent.com/vatnz-dev/vatSys-SRC-Reader/dev/Routes/Routes.xml";

            XmlDocument LocalRoutesXMLDoc = new XmlDocument();
            XmlDocument RemoteRoutesXMLDoc = new XmlDocument();

            WebClient RemoteRoutesClient = new WebClient();

            // check for local directory
            if (!Directory.Exists(LocalSRCSystemDir)) {
                // if it doesn't exist, create it
                Directory.CreateDirectory(LocalSRCSystemDir);
            }

            // check for local routes file
            if (!File.Exists(LocalSRCSystemDir)) {
                // if it doesn't exist, download the remote routes file to the local routes file
                RemoteRoutesClient.DownloadFile(RemoteRoutesURL, LocalRoutesPath);
            }

            // load the localnd remote routes files for parsing
            LocalRoutesXMLDoc.Load(LocalRoutesPath);
            RemoteRoutesXMLDoc.Load(RemoteRoutesURL);

            // parse remote routes file for versions
            if (RemoteRoutesXMLDoc.ChildNodes[0].Attributes.GetNamedItem("CycleVersion") != null && LocalRoutesXMLDoc.ChildNodes[0].Attributes.GetNamedItem("CycleVersion") != null) {
                // check if remote routes version is greater than local routes version
                if (int.Parse(RemoteRoutesXMLDoc.ChildNodes[0].Attributes.GetNamedItem("CycleVersion").Value) > int.Parse(LocalRoutesXMLDoc.ChildNodes[0].Attributes.GetNamedItem("CycleVersion").Value)) {
                    // if it is, download it to the local routes file
                    RemoteRoutesClient.DownloadFile(RemoteRoutesURL, LocalRoutesPath);
                }
            }

            // load final, known good copy of local routes file for parsing
            LocalRoutesXMLDoc.Load(LocalRoutesPath);

            foreach (XmlNode x in LocalRoutesXMLDoc.ChildNodes[0].ChildNodes) {
                foreach (XmlNode i in x.ChildNodes) {
                    // add routes into application
                    routes.Add(new StandardRoute(i.Attributes.GetNamedItem("ID").Value, i.InnerText, i.Attributes.GetNamedItem("Remarks").Value));
                }
            }
        }
        public static List<StandardRoute> routes = new List<StandardRoute>();
        public static void RouteDesignator_Change(TextBox routeDesignatorInput, Label routing, RichTextBox routeRemarks, TextBox fromInput, TextBox toInput)
        {
            //Remove Any Extra Whitespace at Start of Text Box, Also Removes ability to add spaces to Route Designator  
            routeDesignatorInput.Text = routeDesignatorInput.Text.Trim();
            string selectedDesignator = routeDesignatorInput.Text;
            if (routes.Select(x => x.Designator).Contains(selectedDesignator))
            {
                var routeObj = routes.Find(x => x.Designator == selectedDesignator);
                routing.Text = "Route: " + routeObj.Routing;
                if (routeObj.Remarks == "")
                    routeRemarks.Text = "";
                else
                {
                    routeRemarks.Text = routeObj.Remarks;
                    routeRemarks.Text = routeRemarks.Text.Replace(";", "\n");
                }
                fromInput.Text = routeObj.Designator.Substring(0, 2);
                toInput.Text = routeObj.Designator.Substring(2, 2);
            }
            else
            {
                routing.Text = "Route: NONE";
                routeRemarks.Text = ""; 
                fromInput.Text = "";
                toInput.Text = "";
            }
        }
        public static void Routing_Change(TextBox routingInput, Label routeDesignator, RichTextBox routeRemarks, TextBox fromInput, TextBox toInput)
        {
            
            int spaces = routingInput.SelectionStart; 

            if (spaces == 0)
            {
                routingInput.SelectionStart = routingInput.Text.Length;
            }

            else

            {
                routingInput.SelectionStart = spaces;
            }
                
            //routingInput.Text = routingInput.Text.Trim();
            string selectedDesignator = routingInput.Text.Trim();
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
                    routeRemarks.Text = "";
                else
                {
                    routeRemarks.Text = foundRoute.Remarks;
                    routeRemarks.Text = routeRemarks.Text.Replace(";", "\n\n");
                }
                fromInput.Text = foundRoute.Designator.Substring(0, 2);
                toInput.Text = foundRoute.Designator.Substring(2, 2);
            }
            else
            {            
                routeDesignator.Text = "Designator: NONE";
                routeRemarks.Text = "";
                fromInput.Text = "";
                toInput.Text = "";
            }
        }
        public static void FromTo_Change(TextBox fromInput, TextBox toInput, Form form, TextBox routeDesignatorInput, TextBox routingInput )
        {
            string options = "";
            string from = "    ";
            string to = "    ";
            if (fromInput.Text.Length == 2 || fromInput.Text.Length == 4)
            {
                from = fromInput.Text.Substring(fromInput.Text.Length - 2, 2);
            }
            if (toInput.Text.Length == 2 || toInput.Text.Length == 4)
            {
                to = toInput.Text.Substring(toInput.Text.Length - 2, 2);
            }

            foreach (var x in routes.Where(d => d.Designator.Substring(0, 2) == from.Substring(0, 2)).Where(a => a.Designator.Substring(2, 2) == to.Substring(0, 2)))
            {
                options += x.Designator + " | " + x.Routing + '\n';
            }
            if (options.Length > 0)
                options = options.Remove(options.Length - 1, 1);
            foreach(var i in (form.Controls.Find("SRCPanel", true)[0] as FlowLayoutPanel).Controls.Find("SRCOption", true))
            {
                (form.Controls.Find("SRCPanel", true)[0] as FlowLayoutPanel).Controls.Remove(i);
            }
            lastLabel = null;
            for (int i = 0; i < options.Split('\n').Length; i++)
            {
                Label label = new Label
                {
                    MaximumSize = new System.Drawing.Size(275, 1000),
                    MinimumSize = new System.Drawing.Size(275, 0),
                    Font = new System.Drawing.Font("Terminus (TTF)", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel),
                    ForeColor = System.Drawing.SystemColors.ControlDarkDark,
                    AutoSize = true,
                    Name = "SRCOption",
                    TextAlign = System.Drawing.ContentAlignment.TopCenter,
                    Text = options.Split('\n')[i],
                    Margin = new Padding(0, 0, 0, 15)
                };  
                label.Click += (sender, e) => SRC_Click(sender, e, label, routeDesignatorInput, routingInput);
                (form.Controls.Find("SRCPanel", true)[0] as FlowLayoutPanel).Controls.Add(label);                
            }
        }

        public static async Task routing_Click(Label routing)
        {
            if (routing.Text == "Route: NONE")
                return;
            System.Windows.Forms.Clipboard.SetText(routing.Text.Substring(6, routing.Text.Length - 6));
            string preText = routing.Text;
            routing.Text = "COPIED";
            await Task.Delay(1000);
            routing.Text = preText;
        }
        public static async Task routeDesignator_Click(Label routeDesignator)
        {
            if (routeDesignator.Text == "Designator: NONE")
                return;
            System.Windows.Forms.Clipboard.SetText(routeDesignator.Text.Substring(12, routeDesignator.Text.Length - 12));
            string preText = routeDesignator.Text;
            routeDesignator.Text = "COPIED";
            await Task.Delay(1000);
            routeDesignator.Text = preText;
        }
        public static async Task routeRemarks_Click(RichTextBox routeRemarks, Form form)
        {
            if (routeRemarks.Text == "")
                return;
            form.ActiveControl = null;
            System.Windows.Forms.Clipboard.SetText(routeRemarks.Text.Substring(9, routeRemarks.Text.Length - 9));
            string preText = routeRemarks.Text;
            routeRemarks.Text = "COPIED";
            await Task.Delay(1000);
            routeRemarks.Text = preText;
        }
        public static Label lastLabel = null;
        public static void SRC_Click(object sender, EventArgs e, Label src, TextBox routeDesignatorInput, TextBox routingInput)
        {
            routeDesignatorInput.Text = src.Text.Substring(0, 5);
            var route = routes.Find(x => x.Designator == routeDesignatorInput.Text);
            routingInput.Text = route.Routing;
            if (lastLabel != null)
                lastLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            src.ForeColor = System.Drawing.SystemColors.ControlDark;
            lastLabel = src;
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

