using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace twitchBot {
    public partial class MainForm : Form {
        private IrcClient irc;

        private string[] emotes = { "Kappa", "Keepo", "PogChamp", "LUL", "KKona", "DansGame",
                                    "FeelsGoodMan", "FeelsBadMan", "VapeNation", "4Head", "EleGiggle",
                                    "ResidentSleeper", "haHAA" };
        private Random rand;
        private string room;
        private LoginWindow lw;
        private loginInfo li;
        private PlayerWindow player;
        private bool isOnline;

        public MainForm(LoginWindow lWnd, loginInfo lI) {
            InitializeComponent();
            initStyles();
            isOnline = false;
            this.FormClosed += MainForm_FormClosed;
            lw = lWnd;
            li = lI;

            winforms.centerToMainScreen(this);

            // youtube part
            yt = new youtubePlaylist();
            yt.auth();
            if (yt.findPleblist()) {
                statusBarText.Text = "Pleblist found.";
                chatDisplay.AppendText("SYSTEM: Pleblist found.");
            }
            else {
                yt.createPleblist();
                statusBarText.Text = "Pleblist created.";
                chatDisplay.AppendText("SYSTEM: Pleblist created.");
            }

            //twitch part
            label.Text = "Offline";
            streamURI.Text = "Local";
            reconnect();
            timer1.Start();
            rand = new Random();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            if (this.Visible)
                Application.Exit();
        }

        private void reconnect() {
            // password from www.twitchapps.com/tmi/
            // include the "oauth:" portion
            if (globalSettings.offlineMode)
                 return;
            room = li.channel;
            string username = li.username;
            irc = new IrcClient("irc.twitch.tv", 6667, username, li.password);
            irc.joinRoom(room);
            label.Text = $" @{username}";
            streamURI.Text = "twitch.tv/" + room;
            statusBarText.Text = "Connected.";
            chatDisplay.AppendText("\r\nSYSTEM: Connected to Twitch.");
            timer2.Start();
            isOnline = true;
        }

        private void streamURI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (globalSettings.offlineMode)
                MessageBox.Show("Bot is in offline mode", "Info");
            else
                System.Diagnostics.Process.Start("http://www.twitch.tv/" + room);
        }

        private void quit() {
            //this.Close();
            if (player!=null)
                player.Close();
            lw.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e) {
            base.OnFormClosing(e);
            quit();
        }

        private void timer2_Tick(object sender, EventArgs e) {
            if (globalSettings.offlineMode || irc==null || !irc.Client.Connected) return;
            try { irc.sendChatMessage("Use !pleblist + URL to add a youtube song to playlist!"); }
            catch { chatDisplay.AppendText($"\r\nSYSTEM: Couldn't send tip message."); }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void xbox_Click(object sender, EventArgs e) {
            this.Close();
            Application.Exit();
        }

        private void minimizeBox_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=" + yt.getPleblistId());
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e) {
            yt.clearPleblist();
            if (player != null)
                player.OnPleblistUpdated();
            sendChatMessage("Pleblist cleared. FeelsBadMan");
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Hide();
            this.Close();
            lw.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=tPZw9xqsePM");
        }

        private void chatButton_Click(object sender, EventArgs e) {
            sendChatBoxMessage();
        }

        public void sendChatMessage(string message) {
            if (!globalSettings.offlineMode)
                try {
                    irc.sendChatMessage(message);
                }
                catch { chatDisplay.AppendText($"\r\nSYSTEM: Failed to deliver message."); }
            chatDisplay.AppendText($"\r\n" + message);
            parseMessage(message);
        }

        private void sendChatBoxMessage() {
            sendChatMessage(String.Copy(chatBox.Text));
            chatBox.Text = "";
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.Return)
                this.sendChatBoxMessage();
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void openPlayer() {
            if (player != null && player.Visible)
                return;
            player = new PlayerWindow(yt, this);
            player.Show();
        }

        private void playerToolStripMenuItem_Click(object sender, EventArgs e) {
            openPlayer();
        }

        private void reconnectToolStripMenuItem_Click(object sender, EventArgs e) {
            reconnect();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e) {
            new globalSettingsForm().ShowDialog();
        }
    }
}
