using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace twitchBot {
    public partial class globalSettingsForm : Form {
        bool active;
        public globalSettingsForm() {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            windowIcon.MouseDoubleClick += xbox_Click;
            windowTitle.MouseDown += DragWindow;
            groupBoxNetworking.Paint += paintNetworkingControlBorders;
            this.Paint += paintControlBorders;
            winforms.centerToMainScreen(this);
            SetStyle();
            getSettings();
        }

        private void quit() { this.Close(); }
        private void xbox_Click(object sender, EventArgs e) {quit();}

        private void DragWindow(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                winforms.ReleaseCapture();
                winforms.SendMessage(Handle, winforms.WM_NCLBUTTONDOWN, winforms.HT_CAPTION, 0);
            }
        }

        private void getSettings() {
            displayCheckbox.CheckState = globalSettings.preferDisplay?CheckState.Checked:CheckState.Unchecked;
            var device = new winforms.DISPLAY_DEVICE();
            device.cb = Marshal.SizeOf(device);
            foreach (var s in Screen.AllScreens) {
                winforms.EnumDisplayDevices(s.DeviceName, 0, ref device, 0);
                displayComboBox.Items.Add(device.DeviceString);
            }
            displayComboBox.SelectedItem = displayComboBox.Items[globalSettings.preferredDisplay];
            offlineCheckbox.CheckState = globalSettings.offlineMode ? CheckState.Checked : CheckState.Unchecked;
            controlUrlBox.Text = string.Copy(globalSettings.scriptUrl);
        }

        private void apply() {
            globalSettings.preferDisplay = displayCheckbox.CheckState == CheckState.Checked ? true : false;
            int it = 0;
            foreach (var i in displayComboBox.Items) {
                if (i == displayComboBox.SelectedItem)
                    globalSettings.preferredDisplay = it;
                ++it;
            }
            globalSettings.offlineMode = offlineCheckbox.CheckState == CheckState.Checked ? true : false;
            globalSettings.scriptUrl = string.Copy(controlUrlBox.Text);
        }

        private void SetStyle() {
            theme.setFormColors(this);
            theme.setGroupColors(groupBoxDisplay);
            theme.setGroupColors(groupBoxNetworking);
            theme.setGroupColors(displayCheckbox);
            theme.setControlColors(displayComboBox);
            displayComboBox.FlatStyle = FlatStyle.Flat;
            theme.setControlColors(controlUrlBox);
            theme.setButtonStyle(okButton);
            theme.setButtonStyle(cancelButton);
        }

        private void paintControlBorders(object sender, PaintEventArgs e) {
            Pen p = new Pen(active ? Color.LightSlateGray : Color.Gray);         
            theme.drawRectangle(okButton, e.Graphics, p);
            theme.drawRectangle(cancelButton, e.Graphics, p);
        }

        private void paintNetworkingControlBorders(object sender, PaintEventArgs e) {
            Pen p = new Pen(active ? Color.LightSlateGray : Color.Gray);
            theme.drawRectangleWide(controlUrlBox, e.Graphics, p);
        }

        protected override void OnActivated(EventArgs e) {
            base.OnActivated(e);
            active = true;
            this.Refresh();
        }

        protected override void OnDeactivate(EventArgs e) {
            base.OnDeactivate(e);
            active = false;
            this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            Pen p = active ? Pens.LightSlateGray : Pens.Gray;
            e.Graphics.DrawRectangle(p, Rectangle.FromLTRB(0, 0, this.Width - 1, this.Height - 1));
        }

        private void cancelButton_Click(object sender, EventArgs e) {quit();}
        private void okButton_Click(object sender, EventArgs e) {apply(); this.Close(); }


    }
}
