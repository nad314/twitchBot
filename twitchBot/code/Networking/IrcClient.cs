using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace twitchBot
{
    class IrcClient
    {
        private string userName;
        private string channelName;

        private TcpClient tcpCli;
        private StreamReader inputStream;
        private StreamWriter outputStream;

        public TcpClient Client {
            get {
                return tcpCli;
            } 
            set {
                tcpCli = value;
            }
        }

        public StreamReader Reader {
            get {
                return inputStream;
            }
            set {
                inputStream = value;
            }
        }

        public StreamWriter Writer {
            get {
                return outputStream;
            }
            set {
                outputStream = value;
            }
        }

        public IrcClient(string ip, int port, string username, string password)
        {
            userName = username;

            tcpCli = new TcpClient(ip, port);
            inputStream = new StreamReader(tcpCli.GetStream());
            outputStream = new StreamWriter(tcpCli.GetStream());

            outputStream.WriteLine("PASS " + password);
            outputStream.WriteLine("NICK " + username);
            outputStream.WriteLine("USER " + username + " 8 * :" + username);
            outputStream.Flush();
        }

        public bool joinRoom(string channel)
        {
            try {
                channelName = channel;
                outputStream.WriteLine("JOIN #" + channel);
                outputStream.Flush();
                return true;
            } catch { return false; }
        }

        public bool sendIrcMessage(string message)
        {
            try {
                outputStream.WriteLine(message);
                outputStream.Flush();
                return true;
            } catch { return false; }
        }

        public void sendChatMessage(string message)
        {
            sendIrcMessage(":" + userName + "!" + userName + "@" + userName + ".tmi.twitch.tv PRIVMSG #" + channelName + " :" + message);
        }

        public string readMessage()
        {
            string message = inputStream.ReadLine();
            return message;
        }

    }
}
