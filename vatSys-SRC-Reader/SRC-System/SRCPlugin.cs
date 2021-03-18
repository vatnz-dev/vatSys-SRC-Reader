using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vatsys.Plugin;
using System.ComponentModel;
using System.ComponentModel.Composition;
using vatsys;
using System.Windows.Forms;

namespace SRC_System
{
    [Export(typeof(IPlugin))]
    public class SRCPlugin : IPlugin
    {
        public string Name { get => "Standard Route Tool"; }

        private static SRCWindow srcWindow;
        private CustomToolStripMenuItem SRCWindowMenu;
        public SRCPlugin()
        {
            SRCWindowMenu = new CustomToolStripMenuItem(CustomToolStripMenuItemWindowType.Main, CustomToolStripMenuItemCategory.Tools, new ToolStripMenuItem("SRC Plugin"));
            SRCWindowMenu.Item.Click += SetupWindowMenu_Click;
            MMI.AddCustomMenuItem(SRCWindowMenu);
        }
        private void SetupWindowMenu_Click(object sender, EventArgs e)
        {
            DoShowSRCWindow();
        }
        public CustomLabelItem GetCustomLabelItem(string itemType, Track track, FDP2.FDR flightDataRecord, RDP.RadarTrack radarTrack)
        {
            return null;
        }

        public void OnFDRUpdate(FDP2.FDR updated)
        {
        }

        public void OnRadarTrackUpdate(RDP.RadarTrack updated)
        {
        }

        public CustomColour SelectASDTrackColour(Track track)
        {
            return null;
        }

        public CustomColour SelectGroundTrackColour(Track track)
        {
            return null;
        }

        public static void ShowSRCWindow()
        {
            MMI.InvokeOnGUI((System.Windows.Forms.MethodInvoker)delegate () { DoShowSRCWindow(); });
        }

        private static void DoShowSRCWindow()
        {
            if (srcWindow == null || srcWindow.IsDisposed)
                srcWindow = new SRCWindow();
            else if (srcWindow.Visible)
                return;
            srcWindow.Show(Application.OpenForms[0]);
        }
    }
}
