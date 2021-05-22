using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace ColorConvertor
{
    class BitmapConverter
    {
        static Color[] color_table = {  Color.FromArgb(255, 255,64,0),//max
                                        Color.FromArgb(255, 255,128,0),//7/8
                                        Color.FromArgb(255, 255,255,0),//6/8
                                        Color.FromArgb(255, 64,255,0),//5/8
                                        Color.FromArgb(255, 0,255,64),//4/8
                                        Color.FromArgb(255, 0,255,255), //3/8
                                        Color.FromArgb(255, 0,128,255), // 2/8
                                        Color.FromArgb(255, 0,64,255)}; //0
        public static int getBright(Color rgb)
        {
            int sum = rgb.R + rgb.G + rgb.B;
            return sum / 3;
        }
        public static Bitmap cvtGray2Color(Bitmap src_bmp)
        {
            Bitmap dst_bmp = new Bitmap(src_bmp.Width, src_bmp.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            for(int x = 0; x < src_bmp.Width; x++)
            {
                for(int y = 0; y < src_bmp.Height; y++)
                {
                    int equ = 7 - getBright(src_bmp.GetPixel(x, y)) / 32;
                    dst_bmp.SetPixel(x,y, BitmapConverter.color_table[equ]);
                }
            }
            return dst_bmp;
        }
    }
}
