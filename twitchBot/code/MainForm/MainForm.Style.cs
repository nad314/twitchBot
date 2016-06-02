using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;

namespace twitchBot {

    public partial class MainForm {

        private bool active;
 
        private void initStyles() {
            this.MouseDown += Form1_MouseDown;
            mainMenu.MouseDown += Form1_MouseDown;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Paint += paintControlBorders;
            windowIcon.MouseDoubleClick += exitToolStripMenuItem_Click;
            streamURI.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;

            titleBar.Text = "Twitch Bot";
            titleBar.MouseDown += Form1_MouseDown;

            this.BackColor = Color.FromArgb(255, 51, 51, 54);
            streamURI.LinkColor = theme.destructoidColor();
            label.ForeColor = theme.destructoidColor();

            theme.setControlColors(chatDisplay);
            theme.setControlColors(mainMenu);
            theme.setControlColors(statusBar);
            statusBarText.ForeColor = theme.textColor();
            statusBarText.BackColor = theme.darkColor();

            theme.setControlColors(chatBox);

            mainMenu.Renderer = new ToolStripProfessionalRenderer(new darkMenuStyle());
            foreach (ToolStripMenuItem item in mainMenu.Items)
                theme.setItemColors(item);
            theme.setControlColors(titleBar);

            //chat button
            theme.setControlColors(chatButton);

            chatBox.BorderStyle = BorderStyle.None;
            chatButton.FlatStyle = FlatStyle.Flat;
            chatButton.FlatAppearance.BorderSize = 0;

            theme.setControlColors(xbox);
            theme.setControlColors(minimizeBox);
        }



        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        protected override void OnActivated(EventArgs e) {
            base.OnActivated(e);
            active = true;
            this.ActiveControl = chatBox;
            this.Refresh();
        }

        protected override void OnDeactivate(EventArgs e) {
            base.OnDeactivate(e);
            active = false;
            this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            Pen p = active?Pens.LightSlateGray:Pens.Gray;
            e.Graphics.DrawRectangle(p, Rectangle.FromLTRB(0,0,this.Width-1, this.Height-1));
        }

        private void paintControlBorders(object sender, PaintEventArgs e) {
            //chatBox.BorderStyle = BorderStyle.None;
            Pen p = new Pen(active?Color.LightSlateGray:Color.Gray);
            Graphics g = e.Graphics;
            int xv = 3;
            int yv = 3;
            g.DrawRectangle(p, new Rectangle(chatBox.Location.X - xv, chatBox.Location.Y - yv, chatBox.Width + xv, chatBox.Height + yv + 2));
            g.DrawRectangle(p, new Rectangle(chatButton.Location.X - 1, chatButton.Location.Y - 1, chatButton.Width + 1, chatButton.Height + 1));
        }

    }
}
