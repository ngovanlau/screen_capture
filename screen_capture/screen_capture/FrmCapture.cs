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
using System.Drawing.Drawing2D;

namespace screen_capture
{
    public partial class FrmCapture : Form
    {
        public Image img;
        private static Bitmap bmpScreenshot;
        private static Graphics gfxScreenshot;
        int X, Y, width, height;
        private Pen pen;

        public FrmCapture()
        {
            InitializeComponent();
        }
                
        private void FrmCapture_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.Top = 0;
            this.Left = 0;
            this.Hide();
            bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
            gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
            picCapture.Image = bmpScreenshot;
            picCapture.Size = new Size(this.Width, this.Height);
            this.Show();
            Cursor = Cursors.Cross;
        }

        private void picCapture_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                X = e.X;
                Y = e.Y;
                pen = new Pen(Color.Red, 2);
                pen.DashStyle = DashStyle.Solid;
            }
        }
        private void picCapture_MouseMove(object sender, MouseEventArgs e)
        {
            try {
                if (e.Button == MouseButtons.Left)
                {
                    picCapture.Refresh();

                    width = e.X - X;
                    height = e.Y - Y;

                    if (width > 0 && height > 0)
                        picCapture.CreateGraphics().DrawRectangle(pen, X, Y, width, height);
                    else if (width < 0 && height > 0)
                        picCapture.CreateGraphics().DrawRectangle(pen, e.X, Y, Math.Abs(width), height);
                    else if (width > 0 && height < 0)
                        picCapture.CreateGraphics().DrawRectangle(pen, X, e.Y, width, Math.Abs(height));
                    else
                        picCapture.CreateGraphics().DrawRectangle(pen, e.X, e.Y, Math.Abs(width), Math.Abs(height));
                }
            } catch { }
            
        }

        private void picCapture_MouseUp(object sender, MouseEventArgs e)
        {
            try { 
                if (e.Button == MouseButtons.Left)
                {
                    picCapture.Refresh();

                    Rectangle rec;

                    if (width > 0 && height > 0)
                        rec = new Rectangle(X, Y, width, height);
                    else if (width < 0 && height > 0)
                        rec = new Rectangle(e.X, Y, Math.Abs(width), height);
                    else if (width > 0 && height < 0)
                        rec = new Rectangle(X, e.Y, width, Math.Abs(height));
                    else
                        rec = new Rectangle(e.X, e.Y, Math.Abs(width), Math.Abs(height));

                    bmpScreenshot = new Bitmap(rec.Width, rec.Height);
                    gfxScreenshot = Graphics.FromImage(bmpScreenshot);
                    gfxScreenshot.CopyFromScreen(rec.X, rec.Y, 0, 0, rec.Size, CopyPixelOperation.SourceCopy);
                    img = bmpScreenshot;
                    this.Close();
                }
            } catch(ArgumentException) {
                MessageBox.Show("Chưa chọn hình ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
