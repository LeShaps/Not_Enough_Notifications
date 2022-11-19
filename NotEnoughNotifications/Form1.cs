using MetroSet_UI.Child;
using MetroSet_UI.Controls;
using MetroSet_UI.Forms;
using NotEnoughNotifications.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotEnoughNotifications
{
    public partial class MainPage : MetroSetForm
    {
        public MainPage()
        {
            InitializeComponent();
            FinishInitialization();
        }

        private void FinishInitialization()
        {
            foreach (AddonConfig Addon in ConfigReader.Addons) {
                metroSetTabControl1.Controls.Add(CreateAddonPage(Addon));
            }

            UpdateAddonText();
        }

        public void UpdateAddonText()
        {
            if (ConfigReader.Addons.Count > 0) { 
                LoadAddonText.Text = $"{ConfigReader.Addons.Count} addons loaded";
            } else {
                LoadAddonText.Text = "No Addon Found";
            }
        }

        public MetroSetSetTabPage CreateAddonPage(AddonConfig Config)
        {
            return new MetroSetSetTabPage
            {
                Text = Config.Name,
                ToolTipText = Config.Description,
                Style = MetroSet_UI.Enums.Style.Dark,
                StyleManager = this.styleManager1,
            };
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Text = "Notify me!";
            notifyIcon1.Visible = true;

            notifyIcon1.ShowBalloonTip(500, "NeN is running in the background", "NeN is still running, double click on the icon to reopen it", ToolTipIcon.Info);
            notifyIcon1.DoubleClick += NotifyIcon1_DoubleClick;

            this.Hide();
        }

        private void NotifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
