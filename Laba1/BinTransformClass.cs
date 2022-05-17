using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Laba1
{
    internal class BinTransformClass
    {
        static public int[,] Toarray(Bitmap Transforming_Pic)
        {
            int[,] pic = new int[Transforming_Pic.Width, Transforming_Pic.Height];

            for (int i = 0; i < Transforming_Pic.Width; i++)
                for (int j = 0; j < Transforming_Pic.Height; j++)
                {
                    System.Drawing.Color col = Transforming_Pic.GetPixel(i, j);
                    double R = col.R;
                    double G = col.G;
                    double B = col.B;
                    int monochromValue = (int)(0.213 * R + 0.715 * G + 0.072 * B);
                    pic[i, j] = monochromValue;
                }
            return pic;
        }
        static public Bitmap Gavrilov(Bitmap Transforming_Pic)
        {
            //int factor = 10;
            //for (int i = 0; i < Transforming_Pic.Height; i++)
            //{
            //    for (int j = 0; j < Transforming_Pic.Width; j++)
            //    {
            //        var pix = Transforming_Pic.GetPixel(j, i);
            //        int red = pix.R;
            //        int green = pix.G;
            //        int blue = pix.B;
            //        int S = red + green + blue;
            //        if (S > (((255 + factor) / 2) * 3))
            //        {
            //            red = 255;
            //            green = 255;
            //            blue = 255;
            //        }
            //        else
            //        {
            //            red = 0;
            //            green = 0;
            //            blue = 0;
            //        }
            //        pix = System.Drawing.Color.FromArgb(red, green, blue);
            //        Transforming_Pic.SetPixel(j, i, pix);
            //    }
            //}
            int Level = 125;
            int[,] pic = Toarray(Transforming_Pic);

            for (int i = 0; i < pic.GetLength(0); i++)
            {
                for (int j = 0; j < pic.GetLength(1); j++)
                {
                    pic[i, j] = pic[i, j] < Level ? 0 : 255;
                }
            }
            return CreateBitmapFromArray(pic);
        }
        static public Bitmap CreateBitmapFromArray(int[,] pic)
        {
            Bitmap bitmap = new Bitmap(pic.GetLength(0), pic.GetLength(1));
            for (int i = 0; i < pic.GetLength(0); i++)
            {
                for (int j = 0; j < pic.GetLength(1); j++)
                {
                    bitmap.SetPixel(i, j, System.Drawing.Color.FromArgb(pic[i, j], pic[i, j], pic[i, j]));
                }
            }
            return bitmap;
        }
        static public Bitmap Otsu(Bitmap Transforming_Pic)
        {
            double Level=0;
            int[,] pic = Toarray(Transforming_Pic);

            double[] gist = new double[256];
            double size = pic.GetLength(0) * pic.GetLength(1);

            for (int i = 0; i < pic.GetLength(0); i++)
            {
                for (int j = 0; j < pic.GetLength(1); j++)
                {
                    double Br = pic[i, j];
                    gist[(int)Br] += Br / size;
                }
            }
            double sigma = double.MinValue;

            for (int i = 0; i < 256; i++)
            {
                double omega1 = 0;
                double omega2 = 0;
                double mu1 = 0;
                double muT = 0;
                double mu2 = 0;
                double new_sigma = 0;
                for (int j = 0; j <= i; j++)
                {
                    omega1 += gist[j];
                }
                omega2 = 1 - omega1;
                for (int j = 0; j <= i; j++)
                {
                    mu1 += j * gist[j] / omega1;
                }
                for (int j = 0; j <= i; j++)
                {
                    muT += j * gist[j];
                }
                mu2 = (muT - mu1 * omega1) / omega2;
                new_sigma = omega1 * omega2 * Math.Pow(mu1 - mu2, 2);
                if (sigma < new_sigma)
                {

                    sigma = new_sigma;
                    Level = i;
                }
            }

            for (int i = 0; i < pic.GetLength(0); i++)
            {
                for (int j = 0; j < pic.GetLength(1); j++)
                {
                    pic[i, j] = pic[i, j] < Level ? 0 : 255;
                }
            }
            

            return CreateBitmapFromArray(pic);
        }
        static public List<double> power(List<double> val)
        {
            List<double> ret = new List<double>();
            foreach (double v in val)
                ret.Add(v * v);
            return ret;
        }
        static public List<double> GetValuesLocal(int i, int j, int size, int[,] pic)
        {
            List<double> values = new List<double>();
            int start_i = i - (size - 1) / 2;
            int start_j = j - (size - 1) / 2;
            int end_i = start_i + size;
            int end_j = start_j + size;

            if (start_i < 0)
                start_i = 0;
            if (end_i > pic.GetLength(0))
                end_i = pic.GetLength(0);
            if (start_j < 0)
                start_j = 0;
            if (end_j > pic.GetLength(1))
                end_j = pic.GetLength(1);

            for (int i1 = start_i; i1 < end_i; i1++)
                for (int j1 = start_j; j1 < end_j; j1++)
                {
                    try
                    {
                        values.Add(pic[i1, j1]);
                    }
                    catch
                    {

                    }

                }

            return values;
    }
        static public Bitmap Niblec(Bitmap Transforming_Pic, int Size, double K = -0.2)
        {
            double k;
            int size;
            int[,] pic = Toarray(Transforming_Pic);

            int[,] new_pic = new int[pic.GetLength(0), pic.GetLength(1)];
            size = Size;
            k = K;

            for (int i = 0; i < pic.GetLength(0); i++)
            {
                for (int j = 0; j < pic.GetLength(1); j++)
                {
                    double math_ex = 0;
                    double math_ex2 = 0;
                    double dispersion = 0;
                    List<double> values = GetValuesLocal(i, j, size,pic);
                    math_ex = values.Sum() / values.Count;
                    math_ex2 = power(values).Sum() / values.Count;
                    dispersion = math_ex2 - math_ex * math_ex;
                    double locLevel = math_ex + k * Math.Sqrt(dispersion);
                    new_pic[i, j] = pic[i, j] <= locLevel ? 0 : 255;
                }
            }
            pic = new_pic;

            return CreateBitmapFromArray(pic);
        }
        static public Bitmap Sauv(Bitmap Transforming_Pic, int Size, double K = 0.2)
        {
            double k;
            int size;
            int[,] new_pic;
            int[,] pic = Toarray(Transforming_Pic);

            new_pic = new int[pic.GetLength(0), pic.GetLength(1)];
            size = Size;
            k = K;

            for (int i = 0; i < pic.GetLength(0); i++)
            {
                for (int j = 0; j < pic.GetLength(1); j++)
                {
                    double math_ex = 0;
                    double math_ex2 = 0;
                    double dispersion = 0;
                    List<double> values = GetValuesLocal(i, j,size,pic);
                    math_ex = values.Sum() / values.Count;
                    math_ex2 = power(values).Sum() / values.Count;
                    dispersion = math_ex2 - math_ex * math_ex;
                    double locLevel = math_ex * (1 + k * (Math.Sqrt(dispersion) / 128 - 1));
                    new_pic[i, j] = pic[i, j] <= locLevel ? 0 : 255;

                }
            }

            pic = new_pic;
            return CreateBitmapFromArray(pic);
        }
    }
}
