using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace twitchBot {
    public class winforms {
        public static int WM_NCLBUTTONDOWN = 0xA1;
        public static int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public static void centerToMainScreen(Form form) {
            if (!globalSettings.preferDisplay)
                return;
            try {
                Screen scr = Screen.AllScreens[globalSettings.preferredDisplay];
                form.StartPosition = FormStartPosition.Manual;
                form.SetBounds(scr.WorkingArea.X + scr.WorkingArea.Width / 2 - form.Width / 2,
                               scr.WorkingArea.Y + scr.WorkingArea.Height / 2 - form.Height / 2,
                               form.Width, form.Height);
            }
            catch { Console.WriteLine("Couldn't center to screen 0"); }
        }

        [DllImport("User32.dll")]
        public static extern bool EnumDisplayDevices(
             string lpDevice, int iDevNum,
             ref DISPLAY_DEVICE lpDisplayDevice, int dwFlags);

        [StructLayout(LayoutKind.Sequential)]
        public struct DISPLAY_DEVICE {
            public int cb;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string DeviceName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string DeviceString;
            public int StateFlags;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string DeviceID;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string DeviceKey;

            public DISPLAY_DEVICE(int flags) {
                cb = 0;
                StateFlags = flags;
                DeviceName = new string((char)32, 32);
                DeviceString = new string((char)32, 128);
                DeviceID = new string((char)32, 128);
                DeviceKey = new string((char)32, 128);
                cb = Marshal.SizeOf(this);
            }
        }

        public static void goHome() {
            Directory.SetCurrentDirectory(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location));
        }
    }
}
