using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twitchBot
{
    class twitchBot
    {
        public void run()
        {
            // password from www.twitchapps.com/tmi/
            // include the "oauth:" portion
            IrcClient irc = new IrcClient("irc.twitch.tv", 6667, "nad314", "oauth:bz0v7a75t3ro2o6ogggkrirkyre9on");
            irc.joinRoom("nad314");
            while (true)
            {
                string message = irc.readMessage();
                if (message.Contains("!hello"))
                {
                    irc.sendChatMessage("Yo yo");
                    return;
                }
            }
        }
    }
}
