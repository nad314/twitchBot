using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace twitchBot {
    public class darkMenuStyle: ProfessionalColorTable {
        public override Color MenuItemSelected {
            get { return Color.FromArgb(100, 96, 98); }
        }

        public override Color ToolStripDropDownBackground {
            get { return Color.FromArgb(51, 51, 54); }
        }

        public override Color ImageMarginGradientBegin {
            get { return theme.darkColor(); }
        }

        public override Color ImageMarginGradientEnd {
            get { return theme.darkColor(); }
        }

        public override Color ImageMarginGradientMiddle {
            get { return theme.darkColor(); }
        }

        public override Color MenuItemSelectedGradientBegin {
            get { return Color.FromArgb(100, 96, 98); }
        }
        public override Color MenuItemSelectedGradientEnd {
            get { return Color.FromArgb(100, 96, 98); }
        }

        public override Color MenuItemPressedGradientBegin {
            get { return Color.FromArgb(51, 51, 54); }
        }

        public override Color MenuItemPressedGradientMiddle {
            get { return Color.FromArgb(51, 51, 54); }
        }

        public override Color MenuItemPressedGradientEnd {
            get { return Color.FromArgb(51, 51, 54); }
        }

        public override Color MenuItemBorder {
            get { return Color.FromArgb(36, 36, 36); }

        }
    }
}
