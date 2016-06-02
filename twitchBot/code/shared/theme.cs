using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace twitchBot {
    public class theme {
        public static Color darkColor() { return Color.FromArgb(255, 45, 45, 48); }
        public static Color textColor() { return Color.FromArgb(255, 255, 242, 230); }
        public static Color darkTextColor() { return Color.FromArgb(255, 205, 205, 225); }
        public static Color destructoidColor() { return Color.FromArgb(255, 0, 227, 42); }
        public static Color backColor() {return Color.FromArgb(255, 51, 51, 54); }
        public static void setControlColors(Control c) {
            c.ForeColor = Color.FromArgb(255, 255, 242, 230);
            c.BackColor = theme.darkColor();
        }

        public static void setItemColors(ToolStripMenuItem c) {
            c.ForeColor = Color.FromArgb(255, 255, 242, 230);
            if (c.DropDown != null)
                foreach (ToolStripMenuItem next in c.DropDown.Items)
                    setItemColors(next);
        }

        public static void setFormColors(Form c) {
            c.ForeColor = Color.FromArgb(255, 255, 242, 230);
            c.BackColor = theme.backColor();
        }

        public static void setGroupColors(Control c) {
            c.ForeColor = Color.FromArgb(255, 255, 242, 230);
            c.BackColor = theme.backColor();
        }

        public static void setButtonStyle(Button b) {
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            setControlColors(b);
        }

        public static void drawRectangleWide(Control c, Graphics g, Pen p) {
            int xv = 3;
            int yv = 3;
            g.DrawRectangle(p, new Rectangle(c.Location.X - xv, c.Location.Y - yv, c.Width + xv, c.Height + yv + 2));
        }

        public static void drawRectangle(Control c, Graphics g, Pen p) {
            int xv = 1;
            int yv = 1;
            g.DrawRectangle(p, new Rectangle(c.Location.X - xv, c.Location.Y - yv, c.Width + xv, c.Height + yv));
        }

    }
}
