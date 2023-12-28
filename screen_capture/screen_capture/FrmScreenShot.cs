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

namespace screen_capture
{
    public partial class FrmScreenShot : Form
    {
        public Image img;
        public FrmScreenShot()
        {
            InitializeComponent();
        }

        private void FrmCapture_Load(object sender, EventArgs e)
        {
            picScreenShot.Image = img;
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sFD = new SaveFileDialog();
            sFD.Filter = "Png File (*.png)|*.png|" +
                "Jpg File (*.jpg)|*.jpg|" +
                "Bmp File (*.bmp)|*.bmp|" +
                "Gif file (*.gif)|*.gif";
            sFD.FileName = "Capture";

            if (sFD.ShowDialog() == DialogResult.Cancel)
                return;

            try
            {
                if (picScreenShot.Image != null)
                    picScreenShot.Image.Save(sFD.FileName);
                MessageBox.Show(this, "Lưu ảnh thành công", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lưu ảnh không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
