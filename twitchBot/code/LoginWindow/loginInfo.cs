using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace twitchBot {
    public class loginInfo {
        public string username;
        public string password;
        public string channel;
        public loginInfo(string u, string p, string c) {
            username = String.Copy(u);
            password = String.Copy(p);
            channel = String.Copy(c);
        }

        public void save() {
            Directory.SetCurrentDirectory(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location));
            FileStream fs = new FileStream("login_data.txt", FileMode.OpenOrCreate, FileAccess.Write);
            try {
                StreamWriter writer = new StreamWriter(fs);
                writer.WriteLine(username);
                writer.WriteLine(password);
                writer.WriteLine(channel);
                writer.Close();
            }
            finally {
                fs.Close();
            }
        }

        public bool load() {
            bool ret;
            Directory.SetCurrentDirectory(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location));
            FileStream fs = new FileStream("login_data.txt", FileMode.Open, FileAccess.Read);
            try {
                StreamReader reader = new StreamReader(fs);
                username = reader.ReadLine();
                password = reader.ReadLine();
                channel = reader.ReadLine();
                reader.Close();
                ret = true;
            } catch { ret = false; }
            finally {
                fs.Close();
            }
            return ret;
        }

    }
}
