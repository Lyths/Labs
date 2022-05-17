using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Numerics;  
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Complex = System.Numerics.Complex;
using AForge.Imaging;
using AForge.Math;

namespace Laba1
{
    internal class Fifth_LabClass
    {
        public static int Size { get; set; }
        static public void Convert2GrayScaleFast(Bitmap bmp)
        {
            BitmapData bmData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            unsafe
            {
                byte* p = (byte*)(void*)bmData.Scan0.ToPointer();
                int stopAddress = (int)p + bmData.Stride * bmData.Height;
                while ((int)p != stopAddress)
                {
                    p[0] = (byte)(.299 * p[2] + .587 * p[1] + .114 * p[0]);
                    p[1] = p[0];
                    p[2] = p[0];
                    p += 3;
                }
            }

            bmp.UnlockBits(bmData);
        }
        
    }
}
