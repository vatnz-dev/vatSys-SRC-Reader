using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Linq;
namespace SRCXmlTool
{
    public partial class Form1 : Form
    {
        string XMLFileLocation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                XMLFileLocation = openFileDialog1.FileName;
                label1.Text = "XML File: " + XMLFileLocation;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(XMLFileLocation);
            var mainNode = doc.DocumentElement;
            foreach(XmlElement x in mainNode.ChildNodes)
            {
                bool breaking = false;
                foreach(XmlAttribute i in x.Attributes)
                {
                    if (i.Name == "Name")
                    {
                        if (i.Value == textBox1.Text)
                        {
                            richTextBox1.Text += "Found " + textBox1.Text;
                            mainNode.RemoveChild(x);
                            breaking = true;
                            break;
                        }
                    }
                }
                if (breaking) break;
            }
            XmlNode newNode = doc.CreateNode("element", "Airport", "");
            ((XmlElement)newNode).SetAttribute("Name", textBox1.Text);
            mainNode.AppendChild(newNode);
                
            string[] routeStings = richTextBox1.Text.Split('\n');
            foreach(string x in routeStings)
            {                
                XmlElement newElem = doc.CreateElement("Route");
                newElem.SetAttribute("ID", x.Substring(0, 5));
                if (x.Contains('('))
                {
                    string remark = x.Split('(')[1];
                    remark = remark.Substring(0, remark.Length - 1);
                    newElem.SetAttribute("Remarks", remark);

                    string routing = x.Split('(')[0];
                    routing = routing.Substring(6, routing.Length - 7);
                    newElem.InnerText = routing;
                }
                else
                {
                    newElem.SetAttribute("Remarks", "");
                    newElem.InnerText = x.Substring(6, x.Length - 6);
                }
                newNode.AppendChild(newElem);
            }
            doc.Save(XMLFileLocation);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
