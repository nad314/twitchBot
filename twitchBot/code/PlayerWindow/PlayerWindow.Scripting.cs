using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twitchBot {
    public partial class PlayerWindow : Form {
        private string songName;
        private string songId;
        private int videoIndex;
        private bool pleblistEnded;

        private string getState(int state) {
            switch (state) {
                case -1: return "unstarted";
                case 0: return "ended";
                case 1: return "playing";
                case 2: return "paused";
                case 3: return "buffering";
                case 5: return "cued";
                default: return "unknown";
            }
        }
        //youtube JS API
        public void OnAPILoaded() {
            printLine("Youtube API loaded.");
            loadInitialVideo();
        }

        public void OnPlayerReady() {
            printLine("Player ready!");
        }

        public void OnPlayerEnded() {
            printLine("Player ended.");
            songName = "";
            songId = "";
            setWindowTitle();
            loadNextVideo();
        }

        public void OnStateChange(string state) {
            printLine("State: " + state);
        }

        public void OnPleblistCleared() {
            printLine("Pleblist Cleared: going to the beginning.");
            videoIndex = -1;
            pleblistEnded = true;
        }

        public void OnPleblistUpdated() {
            if (pleblistEnded)
                loadNextVideo();
        }

        //youtube .NET API
        public void loadInitialVideo() {
            videoIndex = -1;
            songId = "";
            songName = "";
            loadNextVideo();
        }

        public void loadNextVideo() {
            string nextVideoID = yt.getVideoID(++videoIndex);
            if (nextVideoID != "") {
                browser.Document.InvokeScript("loadVideo", new string[] { nextVideoID });
                pleblistEnded = false;
                songId = nextVideoID;
                songName = yt.getVideoName(songId);
                setWindowTitle();
            }
            else {
                printLine("Reached the end of pleblist.");
                browser.Document.InvokeScript("stopVideo");
                --videoIndex;
                pleblistEnded = true;
            }
        }

        public string getSongName() { return string.Copy(songName); }
        public string getSongId() { return string.Copy(songId); }

        public void sendCurrentSongMessage() { browser.Document.InvokeScript("getVideoTime"); }
        public void OnVideoTime(string s) {
            twitchForm.sendChatMessage("Currently playing: " + songName + " (" + s + ") " + twitchForm.getRandomTwitchEmote());
        }

        public int getIndex() { return videoIndex; }

    }
}
