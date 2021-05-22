using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorConvertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "GrayScale Bitmap(*.bmp)|*.bmp";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                string src_file = dlg.FileName;
                Bitmap src_bmp = new Bitmap(src_file);
                this.Text = "Processing - " + src_file;
                //if(src_bmp.PixelFormat != System.Drawing.Imaging.PixelFormat.)
                Bitmap dst_bmp = BitmapConverter.cvtGray2Color(src_bmp);

                this.Text = "Color Mapped - " + src_file;

                boxSrc.Image = src_bmp;
                boxDst.Image = dst_bmp;
                string dst_file = src_file.Replace(".bmp", "_colored.bmp");
                dst_bmp.Save(dst_file);
            }

        }
    }
}
