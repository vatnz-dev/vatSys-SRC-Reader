using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace SRC_System_Standalone
{
    public partial class SRCWindow : Form
    {
        public SRCWindow()
        {
            InitializeComponent();
            Form1_Resize(null, null);
            LoadRoutes();
        }
        void LoadRoutes()
        {          
            XmlDocument xmlDoc = new XmlDocument();
            string location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            location = location.Substring(0, location.Length - System.Reflection.Assembly.GetExecutingAssembly().GetName().Name.Length - 4) + "/SRC-System/Routes.xml";
            while (true)
            {
                try
                {
                    xmlDoc.Load(location);
                    break;
                }
                catch
                {
                    try
                    {
                        location = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "xmllocation"));
                        xmlDoc.Load(location);
                        break;
                    }
                    catch
                    {
                        DialogResult result = openFileDialog1.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            location = openFileDialog1.FileName;
                            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "xmllocation"), location);
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            Close();
                            break;
                        }
                    }
                }
            }

            foreach (XmlNode x in xmlDoc.ChildNodes[0].ChildNodes)
            {
                foreach (XmlNode i in x.ChildNodes)
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
                    routeRemarks.Text = "Remarks: NONE";
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
                    routeRemarks.Text = "Remarks: NONE";
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
                options += x.Designator + " | " + x.Routing;
                if (x.Remarks != "")
                    options += " | " + x.Remarks;
                options += "\n";
            }

            SRCOptions.Text = options;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            SRCOptions.Width = Convert.ToInt32(Width - 270);
        }

        private async void routing_Click(object sender, EventArgs e)
        {
            if (routing.Text == "Route: NONE")
                return;
            System.Windows.Forms.Clipboard.SetText(routing.Text.Substring(6, routing.Text.Length - 6));
            string preText = routing.Text;
            routing.Text = "COPIED";
            await Task.Delay(1000);
            routing.Text = preText;
        }
        private async void routeDesignator_Click(object sender, EventArgs e)
        {
            if(routeDesignator.Text == "Designator: NONE")
                return;
            System.Windows.Forms.Clipboard.SetText(routeDesignator.Text.Substring(12, routeDesignator.Text.Length - 12));
            string preText = routeDesignator.Text;
            routeDesignator.Text = "COPIED";
            await Task.Delay(1000);
            routeDesignator.Text = preText;
        }
        private async void routeRemarks_Click(object sender, EventArgs e)
        {
            if (routeRemarks.Text == "Remarks: NONE")
                return;
            System.Windows.Forms.Clipboard.SetText(routeRemarks.Text.Substring(9, routeRemarks.Text.Length - 9));
            string preText = routeRemarks.Text;
            routeRemarks.Text = "COPIED";
            await Task.Delay(1000);
            routeRemarks.Text = preText;
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
