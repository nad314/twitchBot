using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace twitchBot {
    public class globalSettings {
        public static bool preferDisplay;
        public static int preferredDisplay;
        public static bool offlineMode;
        public static string scriptUrl = "";

        public static void load() {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "vunjobot\\");
            if (!Directory.Exists(path))
                return;
            path = Path.Combine(path, "global.cfg");
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read); ;
            StreamReader reader;
            try {
                reader = new StreamReader(fs);
                preferDisplay = Boolean.Parse(reader.ReadLine());
                preferredDisplay = Int32.Parse(reader.ReadLine());
                offlineMode = Boolean.Parse(reader.ReadLine());
                scriptUrl = reader.ReadLine();
                reader.Close();
            }
            finally { fs.Close(); }
        }

        public static void save(object sender, EventArgs e) {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "vunjobot\\");
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            path = Path.Combine(path, "global.cfg");
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write); ;
            StreamWriter writer;
            try {
                writer = new StreamWriter(fs);
                writer.WriteLine(preferDisplay);
                writer.WriteLine(preferredDisplay);
                writer.WriteLine(offlineMode);
                writer.WriteLine(scriptUrl);
                writer.Close();
            } finally { fs.Close(); }
        }

    }
}
