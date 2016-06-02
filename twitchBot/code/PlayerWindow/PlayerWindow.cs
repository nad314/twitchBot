using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;
using System.IO;
using System.Runtime.InteropServices;

namespace twitchBot {

    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class PlayerWindow : Form {

        private youtubePlaylist yt;
        private MainForm twitchForm;
        private bool active;
        
        public PlayerWindow(youtubePlaylist YPL, MainForm f1) {
            yt = YPL;
            twitchForm = f1;
            InitializeComponent();
            browser.AllowWebBrowserDrop = false;
            browser.IsWebBrowserContextMenuEnabled = false;
            browser.WebBrowserShortcutsEnabled = false;
            browser.ObjectForScripting = this;
            browser.ScriptErrorsSuppressed = true;

            //clear cache
            System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 8");
            printLine("Getting Website...");
            //browser.Navigate("http://localhost:3000/player");
            //browser.Navigate("http://pastebin.com/raw/CyXuvehY");
            browser.Navigate(globalSettings.scriptUrl);
            pleblistEnded = false;

            this.BackColor = theme.backColor();
            theme.setControlColors(statusStrip);
            statusLabel.BackColor = theme.darkColor();
            statusLabel.ForeColor = theme.textColor();
            theme.setControlColors(titleBar);
            titleBar.MouseDown += playerWindow_MouseDown;
            mainMenu.MouseDown += playerWindow_MouseDown;

            this.FormBorderStyle = FormBorderStyle.None;
            winforms.centerToMainScreen(this);
            windowIcon.MouseDoubleClick += quit;

            foreach (ToolStripMenuItem item in mainMenu.Items)
                theme.setItemColors(item);
            theme.setControlColors(mainMenu);
            mainMenu.Renderer = new ToolStripProfessionalRenderer(new darkMenuStyle());
            theme.setControlColors(xbox);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void playerWindow_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
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

        private void printLine(string s) {
            statusLabel.Text = s;
        }

        public void Message(string message) {
            printLine("JavaScript: " + message);
        }

        private void quit(object sender, MouseEventArgs e) {
            this.Close();
        }

        private void xbox_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void firstToolStripMenuItem_Click(object sender, EventArgs e) {
            loadInitialVideo();
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e) {
            loadNextVideo();
        }

        private void previousToolStripMenuItem_Click(object sender, EventArgs e) {
            videoIndex = videoIndex > 1 ? videoIndex - 2 : -1;
            loadNextVideo();
        }

        private void setWindowTitle() {
            if (songName=="")
                titleBar.Text = "Youtube Player";
            else
                titleBar.Text = "Youtube Player - " + songName;
        }

    }
}
