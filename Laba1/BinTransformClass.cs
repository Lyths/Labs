using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laba1
{
    internal class BinTransformClass
    {
        static public Bitmap Gavrilov(Bitmap Transforming_Pic)
        {
            int factor = 10;
            for (int i = 0; i < Transforming_Pic.Height; i++)
            {
                for (int j = 0; j < Transforming_Pic.Width; j++)
                {
                    var pix = Transforming_Pic.GetPixel(j, i);
                    int red = pix.R;
                    int green = pix.G;
                    int blue = pix.B;
                    int S = red + green + blue;
                    if (S > (((255 + factor) / 2) * 3))
                    {
                        red = 255;
                        green = 255;
                        blue = 255;
                    }
                    else
                    {
                        red = 0;
                        green = 0;
                        blue = 0;
                    }
                    pix = Color.FromArgb(red, green, blue);
                    Transforming_Pic.SetPixel(j, i, pix);
                }
            }
            return Transforming_Pic;
        }

    }
}
