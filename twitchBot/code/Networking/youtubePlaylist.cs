using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Windows.Forms;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using Google.Apis.Util.Store;

namespace twitchBot
{
    public class youtubePlaylist
    {
        private UserCredential cred;
        private YouTubeService youtubeService;
        Playlist pl;
        public youtubePlaylist() { }
        public void yell() { Console.WriteLine("Ayy lemayo!"); }

        public string getPleblistId() { return pl.Id; }

        public void auth()
        { 
            using (FileStream fs = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                cred = GoogleWebAuthorizationBroker.AuthorizeAsync(
                   GoogleClientSecrets.Load(fs).Secrets,
                    new[] { YouTubeService.Scope.Youtube, YouTubeService.Scope.YoutubeUpload },
                    "borna314",
                    CancellationToken.None,
                    new FileDataStore("YouTube.Auth.Store")).Result;
            }

            youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = cred,
                ApplicationName = "Vunjo Pleblist"
            });            
        }

        public bool findPleblist()
        {
            /*
            var channelListRequest = youtubeService.Channels.List("contentDetails");
            channelListRequest.Mine = true;*/
            var pll = youtubeService.Playlists.List("snippet");
            pll.PageToken = "";
            pll.MaxResults = 50;
            pll.Mine = true;
            PlaylistListResponse resp = pll.Execute();
            foreach (var p in resp.Items)
                if (p.Snippet.Title == "pleblist")
                {
                    pl = p;
                    return true;
                }
            return false;
        }

        public void createPleblist()
        {
            pl = new Playlist();
            pl.Snippet = new PlaylistSnippet();
            pl.Snippet.Title = "pleblist";

            var playlistCreationRequest = youtubeService.Playlists.Insert(pl, "snippet");
            playlistCreationRequest.Execute();
        }

        public bool addToPleblist(string songID)
        {
            var pli = new PlaylistItem();
            pli.Snippet = new PlaylistItemSnippet();
            pli.Snippet.PlaylistId = pl.Id;
            pli.Snippet.ResourceId = new ResourceId();
            pli.Snippet.ResourceId.Kind = "youtube#video";
            pli.Snippet.ResourceId.VideoId = songID;

            try { youtubeService.PlaylistItems.Insert(pli, "snippet").Execute(); }
            catch { return false; }
            return true;
        }

        public void clearPleblist()
        {
            var nextPageToken = "";
            PlaylistItemsResource.ListRequest req = youtubeService.PlaylistItems.List("contentDetails");
            while (nextPageToken != null)
            {
                req.MaxResults = 50;
                req.PlaylistId = pl.Id;
                req.PageToken = nextPageToken;
                var res = req.Execute();

                foreach (var i in res.Items)
                {
                    youtubeService.PlaylistItems.Delete(i.Id).Execute();
                }

                nextPageToken = res.NextPageToken;
            }

        }

        public string getPleblistString()
        {
            var nextPageToken = "";
            PlaylistItemsResource.ListRequest req = youtubeService.PlaylistItems.List("contentDetails");
            req.MaxResults = 50;
            req.PlaylistId = pl.Id;
            req.PageToken = nextPageToken;
            var res = req.Execute();
            return "https://www.youtube.com/v/" + res.Items[0].ContentDetails.VideoId + "?list=" + pl.Id;
        }

        public string getVideoName(string v_id)
        {
            var req = youtubeService.Videos.List("snippet");
            req.Id = v_id;
            var res = req.Execute();
            return res.Items[0].Snippet.Title;
        }

        public string getVideoID(int index) {
            var pli = new PlaylistItem();
            pli.Snippet = new PlaylistItemSnippet();
            pli.Snippet.Position = index;
            pli.Snippet.PlaylistId = pl.Id;
            var listRequest = youtubeService.PlaylistItems.List("snippet, contentDetails");
            listRequest.PlaylistId = pl.Id;
            listRequest.MaxResults = 50;
            listRequest.PageToken = "";
            while (listRequest.PageToken != null) {
                var items = listRequest.Execute();
                foreach (var i in items.Items)
                    if (i.Snippet.Position == index)
                        return i.ContentDetails.VideoId;
                listRequest.PageToken = items.NextPageToken;
            }
            return "";
        }

        public bool fetchPleblist() {
            try {
                var req = youtubeService.Playlists.List("snippet, contentDetails");
                req.Id = pl.Id;
                pl = req.Execute().Items[0];
                return true;
            } catch { return false; }
        }

        public void fetch()
        {
            YouTubeService youtube = new YouTubeService(new BaseClientService.Initializer()
            {
                ApplicationName = "Vunjo Pleblist",
                ApiKey = "AIzaSyDkOLlIf7GC75k7MaoxewmeQa31PNuXO3M",
            });
            SearchResource.ListRequest listRequest = youtube.Search.List("snippet");
            listRequest.Q = "Loeb Pikes Peak";
            listRequest.MaxResults = 5;
            listRequest.Type = "video";
            SearchListResponse resp = listRequest.Execute();
            foreach (SearchResult result in resp.Items)
            {
                Console.WriteLine(result.Snippet.Title);
            }
        }
        
        public Playlist getPlaylist() { return pl; }

    }
}
