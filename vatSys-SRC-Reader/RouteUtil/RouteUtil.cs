using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Xml;

namespace RouteUtil
{
    public static class RouteUtil
    {
        public static void LoadRoutes(Form form, OpenFileDialog openFileDialog1)
        {
            routes.Clear();
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
                            form.Close();
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
        public static List<StandardRoute> routes = new List<StandardRoute>();
        public static void RouteDesignator_Change(TextBox routeDesignatorInput, Label routing, RichTextBox routeRemarks, TextBox fromInput, TextBox toInput)
        {
            if(routeDesignatorInput.Text.Length > 0)
                if (routeDesignatorInput.Text[0] == ' ')
                    routeDesignatorInput.Text = routeDesignatorInput.Text.Remove(0, 1); 
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
            if (routingInput.Text.Length > 0)
                if (routingInput.Text[0] == ' ')
                routingInput.Text = routingInput.Text.Remove(0, 1);
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
                    routeRemarks.Text = routeRemarks.Text.Replace(";", "\n");
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
        public static void FromTo_Change(TextBox fromInput, TextBox toInput, Label SRCOptions)
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
                options += "\n\n";
            }

            SRCOptions.Text = options;
        }

        public static async void routing_Click(Label routing)
        {
            if (routing.Text == "Route: NONE")
                return;
            System.Windows.Forms.Clipboard.SetText(routing.Text.Substring(6, routing.Text.Length - 6));
            string preText = routing.Text;
            routing.Text = "COPIED";
            await Task.Delay(1000);
            routing.Text = preText;
        }
        public static async void routeDesignator_Click(Label routeDesignator)
        {
            if (routeDesignator.Text == "Designator: NONE")
                return;
            System.Windows.Forms.Clipboard.SetText(routeDesignator.Text.Substring(12, routeDesignator.Text.Length - 12));
            string preText = routeDesignator.Text;
            routeDesignator.Text = "COPIED";
            await Task.Delay(1000);
            routeDesignator.Text = preText;
        }
        public static async void routeRemarks_Click(RichTextBox routeRemarks, Form form)
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

