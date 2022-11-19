using NotEnoughNotifications.Config;
using System;
using System.Windows.Forms;

namespace NotEnoughNotifications
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.metroSetControlBox2 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.styleManager1 = new MetroSet_UI.Components.StyleManager();
            this.metroSetContextMenuStrip1 = new MetroSet_UI.Controls.MetroSetContextMenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.metroSetSetTabPage2 = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.metroSetButton1 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetSetTabPage1 = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.LoadAddonText = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetTabControl1 = new MetroSet_UI.Controls.MetroSetTabControl();
            this.metroSetContextMenuStrip1.SuspendLayout();
            this.metroSetSetTabPage2.SuspendLayout();
            this.metroSetSetTabPage1.SuspendLayout();
            this.metroSetTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSetControlBox2
            // 
            this.metroSetControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox2.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox2.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox2.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox2.DisabledForeColor = System.Drawing.Color.Silver;
            this.metroSetControlBox2.IsDerivedStyle = true;
            this.metroSetControlBox2.Location = new System.Drawing.Point(871, 10);
            this.metroSetControlBox2.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.metroSetControlBox2.MaximizeBox = true;
            this.metroSetControlBox2.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox2.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox2.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox2.MinimizeBox = true;
            this.metroSetControlBox2.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox2.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox2.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox2.Name = "metroSetControlBox2";
            this.metroSetControlBox2.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox2.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetControlBox2.StyleManager = this.styleManager1;
            this.metroSetControlBox2.TabIndex = 0;
            this.metroSetControlBox2.Text = "ControllerBox";
            this.metroSetControlBox2.ThemeAuthor = "Narwin";
            this.metroSetControlBox2.ThemeName = "MetroDark";
            // 
            // styleManager1
            //
            this.styleManager1.MetroForm = this;
            this.styleManager1.Style = MetroSet_UI.Enums.Style.Dark;
            this.styleManager1.ThemeAuthor = "Narwin";
            this.styleManager1.ThemeName = "MetroDark";
            // 
            // metroSetContextMenuStrip1
            // 
            this.metroSetContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.metroSetContextMenuStrip1.IsDerivedStyle = true;
            this.metroSetContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.openConfigToolStripMenuItem});
            this.metroSetContextMenuStrip1.Name = "metroSetContextMenuStrip1";
            this.metroSetContextMenuStrip1.Size = new System.Drawing.Size(163, 52);
            this.metroSetContextMenuStrip1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetContextMenuStrip1.StyleManager = null;
            this.metroSetContextMenuStrip1.ThemeAuthor = "Narwin";
            this.metroSetContextMenuStrip1.ThemeName = "MetroLite";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openConfigToolStripMenuItem
            // 
            this.openConfigToolStripMenuItem.Name = "openConfigToolStripMenuItem";
            this.openConfigToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.openConfigToolStripMenuItem.Text = "Open Config";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.metroSetContextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // metroSetSetTabPage2
            // 
            this.metroSetSetTabPage2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetSetTabPage2.Controls.Add(this.metroSetButton1);
            this.metroSetSetTabPage2.Font = null;
            this.metroSetSetTabPage2.ImageIndex = 0;
            this.metroSetSetTabPage2.ImageKey = null;
            this.metroSetSetTabPage2.IsDerivedStyle = true;
            this.metroSetSetTabPage2.Location = new System.Drawing.Point(4, 42);
            this.metroSetSetTabPage2.Name = "metroSetSetTabPage2";
            this.metroSetSetTabPage2.Size = new System.Drawing.Size(952, 427);
            this.metroSetSetTabPage2.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetSetTabPage2.StyleManager = this.styleManager1;
            this.metroSetSetTabPage2.TabIndex = 1;
            this.metroSetSetTabPage2.Text = "Sample";
            this.metroSetSetTabPage2.ThemeAuthor = "Narwin";
            this.metroSetSetTabPage2.ThemeName = "MetroDark";
            this.metroSetSetTabPage2.ToolTipText = null;
            // 
            // metroSetButton1
            // 
            this.metroSetButton1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton1.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton1.IsDerivedStyle = true;
            this.metroSetButton1.Location = new System.Drawing.Point(3, 26);
            this.metroSetButton1.Name = "metroSetButton1";
            this.metroSetButton1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton1.Size = new System.Drawing.Size(80, 30);
            this.metroSetButton1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetButton1.StyleManager = this.styleManager1;
            this.metroSetButton1.TabIndex = 1;
            this.metroSetButton1.Text = "Notify!";
            this.metroSetButton1.ThemeAuthor = "Narwin";
            this.metroSetButton1.ThemeName = "MetroDark";
            // 
            // metroSetSetTabPage1
            // 
            this.metroSetSetTabPage1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetSetTabPage1.Controls.Add(this.LoadAddonText);
            this.metroSetSetTabPage1.Font = null;
            this.metroSetSetTabPage1.ImageIndex = 0;
            this.metroSetSetTabPage1.ImageKey = null;
            this.metroSetSetTabPage1.IsDerivedStyle = true;
            this.metroSetSetTabPage1.Location = new System.Drawing.Point(4, 42);
            this.metroSetSetTabPage1.Name = "metroSetSetTabPage1";
            this.metroSetSetTabPage1.Size = new System.Drawing.Size(952, 427);
            this.metroSetSetTabPage1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetSetTabPage1.StyleManager = this.styleManager1;
            this.metroSetSetTabPage1.TabIndex = 0;
            this.metroSetSetTabPage1.Text = "Config";
            this.metroSetSetTabPage1.ThemeAuthor = "Narwin";
            this.metroSetSetTabPage1.ThemeName = "MetroDark";
            this.metroSetSetTabPage1.ToolTipText = null;
            // 
            // LoadAddonText
            // 
            this.LoadAddonText.AutoCompleteCustomSource = null;
            this.LoadAddonText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.LoadAddonText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.LoadAddonText.BorderColor = System.Drawing.Color.Transparent;
            this.LoadAddonText.CausesValidation = false;
            this.LoadAddonText.DisabledBackColor = System.Drawing.Color.Transparent;
            this.LoadAddonText.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.LoadAddonText.DisabledForeColor = System.Drawing.Color.Transparent;
            this.LoadAddonText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LoadAddonText.HoverColor = System.Drawing.Color.Transparent;
            this.LoadAddonText.Image = null;
            this.LoadAddonText.IsDerivedStyle = true;
            this.LoadAddonText.Lines = null;
            this.LoadAddonText.Location = new System.Drawing.Point(0, 28);
            this.LoadAddonText.MaxLength = 32767;
            this.LoadAddonText.Multiline = false;
            this.LoadAddonText.Name = "LoadAddonText";
            this.LoadAddonText.ReadOnly = true;
            this.LoadAddonText.Size = new System.Drawing.Size(180, 28);
            this.LoadAddonText.Style = MetroSet_UI.Enums.Style.Dark;
            this.LoadAddonText.StyleManager = this.styleManager1;
            this.LoadAddonText.TabIndex = 0;
            this.LoadAddonText.TabStop = false;
            this.LoadAddonText.Text = "No Addons Found";
            this.LoadAddonText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LoadAddonText.ThemeAuthor = "Narwin";
            this.LoadAddonText.ThemeName = "MetroDark";
            this.LoadAddonText.UseSystemPasswordChar = false;
            this.LoadAddonText.WatermarkText = "";
            // 
            // metroSetTabControl1
            // 
            this.metroSetTabControl1.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.metroSetTabControl1.AnimateTime = 200;
            this.metroSetTabControl1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetTabControl1.Controls.Add(this.metroSetSetTabPage1);
            this.metroSetTabControl1.Controls.Add(this.metroSetSetTabPage2);
            this.metroSetTabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroSetTabControl1.IsDerivedStyle = true;
            this.metroSetTabControl1.ItemSize = new System.Drawing.Size(100, 38);
            this.metroSetTabControl1.Location = new System.Drawing.Point(15, 123);
            this.metroSetTabControl1.Name = "metroSetTabControl1";
            this.metroSetTabControl1.SelectedIndex = 0;
            this.metroSetTabControl1.SelectedTextColor = System.Drawing.Color.White;
            this.metroSetTabControl1.Size = new System.Drawing.Size(960, 473);
            this.metroSetTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroSetTabControl1.Speed = 100;
            this.metroSetTabControl1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetTabControl1.StyleManager = this.styleManager1;
            this.metroSetTabControl1.TabIndex = 1;
            this.metroSetTabControl1.ThemeAuthor = "Narwin";
            this.metroSetTabControl1.ThemeName = "MetroDark";
            this.metroSetTabControl1.UnselectedTextColor = System.Drawing.Color.Gray;
            this.metroSetTabControl1.UseAnimation = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(990, 611);
            this.Controls.Add(this.metroSetTabControl1);
            this.Controls.Add(this.metroSetControlBox2);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.StyleManager = this.styleManager1;
            this.Text = "NEN - Not Enough Notifications";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.UseSlideAnimation = true;
            this.metroSetContextMenuStrip1.ResumeLayout(false);
            this.metroSetSetTabPage2.ResumeLayout(false);
            this.metroSetSetTabPage1.ResumeLayout(false);
            this.metroSetTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox2;
        private MetroSet_UI.Components.StyleManager styleManager1;
        private MetroSet_UI.Controls.MetroSetContextMenuStrip metroSetContextMenuStrip1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem openConfigToolStripMenuItem;
        private NotifyIcon notifyIcon1;
        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl1;
        private MetroSet_UI.Child.MetroSetSetTabPage metroSetSetTabPage1;
        private MetroSet_UI.Controls.MetroSetTextBox LoadAddonText;
        private MetroSet_UI.Child.MetroSetSetTabPage metroSetSetTabPage2;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton1;
    }
}

