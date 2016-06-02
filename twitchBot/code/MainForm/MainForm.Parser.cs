using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twitchBot {
    public partial class MainForm {
        private void parseMessage(string msg) {
            string command = String.Copy(msg);
            string cmdParams = "";
            int n = command.IndexOf(" ");
            if (n > 0) {
                if (n < command.Length)
                    cmdParams = command.Substring(n + 1);
                command = command.Remove(n, command.Length - n);
            }

            switch (command) {
                case "!pleblist": parsePleblistCommand(cmdParams); break;
                case "!song": sendCurrentSongMessage(); break;
                default: break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (globalSettings.offlineMode) {
                if (isOnline) {
                    label.Text = "Offline";
                    streamURI.Text = "Local";
                }
                isOnline = false;
                return;
            }
            if (irc==null||!irc.Client.Connected||!isOnline)
                reconnect();
            isOnline = true;

            var cli = irc.Client;
            var reader = irc.Reader;

            while (cli.Available > 0 || reader.Peek() >= 0) {
                var message = reader.ReadLine();
                if (message.StartsWith(":tmi.twitch.tv"))
                    continue;
                if (!message.Contains("!"))
                    continue;
                int index = message.IndexOf('#');
                string chatMessage = message.Substring(0 < index ? index : 1);
                int index2 = chatMessage.IndexOf(':') + 1;
                int index3 = message.IndexOf("!") - 1;
                string chatterName = message.Substring(1);
                chatterName = chatterName.Remove(0 < index3 ? index3 : 1, chatterName.Length - index3);
                string displayMessage = chatMessage.Substring(0 < index2 ? index2 : 1);
                chatDisplay.AppendText($"\r\n{chatterName + ": " + displayMessage}");
                parseMessage(displayMessage);
            }

        }

        public string getRandomTwitchEmote() {
            return emotes[rand.Next() % emotes.Length];
        }

        private async Task<bool> idToPlaylist(string id) {
            bool result = false;
            //result = await Task<bool>.Run(()=> { return yt.addToPleblist(id); });
            result = await Task.FromResult<bool>(yt.addToPleblist(id));
            return result;
        }

        private void parsePleblistCommand(string par) {
            if (!par.Contains("?v=")) {
                if (par.StartsWith("length"))
                    sendPleblistLengthMessage();
                return;
            }
            string id = par.Substring(par.IndexOf("?v=") + 3);
            try {
                int end = id.IndexOf("&");
                if (end > 0)
                    id = id.Remove(end, id.Length - end);
            }
            catch { chatDisplay.AppendText($"\r\nSYSTEM: Something went wrong with link parsing."); }
            try {
                int end = id.IndexOf("#");
                if (end > 0)
                    id = id.Remove(end, id.Length - end);
            }
            catch { chatDisplay.AppendText($"\r\nSYSTEM: Something went wrong with link parsing."); }


            try {
                string vname = yt.getVideoName(id);
                //bool res = await idToPlaylist(id);
                bool res = yt.addToPleblist(id);
                if (res) {
                    statusBarText.Text = "Added '" + vname + "' to pleblist.";
                    sendChatMessage("Added '" + vname + "' to pleblist. " + getRandomTwitchEmote());
                    if (player != null && player.Visible == true)
                        player.OnPleblistUpdated();
                }
            }
            catch { chatDisplay.AppendText($"\r\nSYSTEM: Couldn't add the video to pleblist.\n"); }
        }

        private void sendCurrentSongMessage() {
            string song;
            if (player == null || (song = player.getSongName()) == "")
                sendChatMessage("No song currently playing. FeelsBadMan");
            else
                player.sendCurrentSongMessage();
        }

        private void sendPleblistLengthMessage() {
            if (!yt.fetchPleblist()) {
                chatDisplay.AppendText($"\r\nSYSTEM: Couldn't Fetch Pleblist.");
                return;
            }
            int count = (int)yt.getPlaylist().ContentDetails.ItemCount - ((player == null) ? 0 : player.getIndex() + 1);
            sendChatMessage($"Remaining items on pleblist: {count.ToString()}. {getRandomTwitchEmote()}");
        }

    }
}
