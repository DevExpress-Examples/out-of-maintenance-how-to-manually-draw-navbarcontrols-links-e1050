using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraNavBar.ViewInfo;
using DevExpress.Utils.Drawing;
using DevExpress.XtraNavBar;

namespace CustomDrawLinkSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void navBarControl1_CustomDrawLink(object sender, CustomDrawNavBarElementEventArgs e) {
            SizeF textSize = e.Cache.CalcTextSize(e.Caption, e.Appearance.Font, StringFormat.GenericDefault, e.RealBounds.Width);
            NavLinkInfoArgs args = (NavLinkInfoArgs)e.ObjectInfo;
            Rectangle newCaptionRectangle = args.RealCaptionRectangle;
            newCaptionRectangle.Width = Convert.ToInt32(textSize.Width);
            args.CaptionRectangle = newCaptionRectangle;
        }
    }
}