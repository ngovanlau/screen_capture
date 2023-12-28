using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Threading;

namespace screen_capture
{
    public partial class FrmMain : Form
    {
        private static Bitmap bmpScreenshot;
        private static Graphics gfxScreenshot;
        

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btFullScreen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thread.Sleep(1000);
            bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
            gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
            FrmScreenShot fScreenShot = new FrmScreenShot();
            fScreenShot.img = bmpScreenshot;
            fScreenShot.ShowDialog();
            this.Show();
        }

        private void btSelectScreen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thread.Sleep(1000);
            FrmCapture fCapture = new FrmCapture();
            fCapture.ShowDialog();
            FrmScreenShot fScreenShot = new FrmScreenShot();
            fScreenShot.img = fCapture.img;
            fScreenShot.ShowDialog();
            this.Show();
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
                btSelectScreen.PerformClick();
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.F)
                btFullScreen.PerformClick();
        }
    }
}
