using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    internal class BinTransformClass
    {
        static public byte[] ToArray(Bitmap img)
        {
            byte[] bytes = new byte[img.Width * img.Height * 3];  
            var data = img.LockBits(new Rectangle(0, 0, img.Width, img.Height),  ImageLockMode.ReadOnly, img.PixelFormat);
            Marshal.Copy(data.Scan0, bytes, 0, bytes.Length);
            img.UnlockBits(data);
            return bytes;
        }
        static public void ToBitmap(Bitmap img, byte[] bytes)
        {
            var data = img.LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.WriteOnly, img.PixelFormat);
            Marshal.Copy(bytes, 0, data.Scan0, bytes.Length); 
            img.UnlockBits(data);  
        }
        static public List<double> Values(int i, int j, int size, int[,] Img)
        {
            List<double> Values = new List<double>();
            int starting_height_of_pixel = i - (size - 1) / 2;
            int starting_width_of_pixel = j - (size - 1) / 2;
            int ending_height_of_pixel = starting_height_of_pixel + size;
            int ending_width_of_pixel = starting_width_of_pixel + size;

            if (starting_height_of_pixel < 0)
            {
                starting_height_of_pixel = 0;
            }
            if (starting_width_of_pixel < 0) 
            {
                starting_width_of_pixel = 0;
            }
            if (ending_height_of_pixel > Img.GetLength(0))
            {
                ending_height_of_pixel = Img.GetLength(0);
            }
            if (ending_width_of_pixel > Img.GetLength(1))
            {
                ending_width_of_pixel = Img.GetLength(1);
            }

            for (int start_height = starting_height_of_pixel; start_height < ending_height_of_pixel; start_height++)
            {
                for (int start_width = starting_width_of_pixel; start_width < ending_width_of_pixel; start_width++)
                {
                    Values.Add(Img[start_height, start_width]);
                }
            }
            return Values;
        }
        static public Bitmap Gavrilov(Bitmap Transforming_Pic)
        {
            double t=0;
            int width = Transforming_Pic.Width;
            int height = Transforming_Pic.Height;  
            byte[] ImgBytes = new byte[0];

            using (Bitmap _tmp = new Bitmap(width, height, PixelFormat.Format24bppRgb))
            {
               _tmp.SetResolution(Transforming_Pic.HorizontalResolution, Transforming_Pic.VerticalResolution);
                using (var g = Graphics.FromImage(_tmp))
                {
                    g.DrawImageUnscaled(Transforming_Pic, 0, 0);
                }
                ImgBytes = ToArray(_tmp);
            }

            for (int i = 0; i < ImgBytes.Length; i += 3)
            {
                t = t + (0.0721 * ImgBytes[i] + 0.7154 * ImgBytes[i + 1] + 0.2125 * ImgBytes[i + 2]) / (width * height);
            }

            for (int i = 0; i < ImgBytes.Length; i += 3)
            {
                if (t>=(0.0721 * ImgBytes[i]+ 0.7154 * ImgBytes[i+1]+ 0.2125 * ImgBytes[i+2]))
                {
                    ImgBytes[i] = 0;
                    ImgBytes[i + 1] = 0;
                    ImgBytes[i + 2] = 0;
                }
                else
                {
                    ImgBytes[i] = 255;
                    ImgBytes[i + 1] = 255;
                    ImgBytes[i + 2] = 255;
                }
            }

            Bitmap img_ret = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            img_ret.SetResolution(Transforming_Pic.HorizontalResolution, Transforming_Pic.VerticalResolution);
            ToBitmap(img_ret, ImgBytes);
            return img_ret;
        }
        static public Bitmap Otsu(Bitmap Transforming_Pic)
        {
            double[] N = new double[256];
            double c;
            int width = Transforming_Pic.Width;
            int height = Transforming_Pic.Height;
            byte[] ImgBytes = new byte[0];
            int[,] Img = new int[height, width];

            using (Bitmap _tmp = new Bitmap(width, height, PixelFormat.Format24bppRgb))
            {
                _tmp.SetResolution(Transforming_Pic.HorizontalResolution, Transforming_Pic.VerticalResolution);
                using (var g = Graphics.FromImage(_tmp))
                {
                    g.DrawImageUnscaled(Transforming_Pic, 0, 0);
                }
                ImgBytes = ToArray(_tmp);
            }

            for (int i = 0; i < ImgBytes.Length; i += 3)
            {
                ImgBytes[i] = (byte)(0.0721 * ImgBytes[i]);
                ImgBytes[i + 1] = (byte)(0.7154 * ImgBytes[i + 1]);
                ImgBytes[i + 2] = (byte)(0.2125 * ImgBytes[i + 2]);
            }
            int t = 0;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Img[i, j] = ImgBytes[t] + ImgBytes[t + 1] + ImgBytes[t + 2];
                    t += 3;
                }
            }

            for (int i = 0; i < Img.GetLength(0); i++)
            {
                for (int j = 0; j < Img.GetLength(1); j++)
                {
                    c = Img[i,j];
                    N[Img[i,j]] += c / width / height;
                }
                
            }

            int TheBestTreshold = 0;
            double TheBestSigma = 0;

            for (int Threshold = 0; Threshold < 256; Threshold++)
            {
                double omega1 = 0;
                double mu1 = 0;
                double muT = 0;
                for (int i = 0; i < Threshold; i++)
                {
                    omega1 += N[i];
                }
                double omega2 = 1 - omega1;
                for (int i = 0; i < Threshold; i++)
                {
                    mu1 += i * N[i] / omega1;
                }
                for (int i = 0; i <= 255; i++)
                {
                    muT += i * N[i];
                }
                double mu2 = (muT - mu1 * omega1) / omega2;
                double Sigma = omega1 * omega2 * Math.Pow(mu1 - mu2, 2);
                if (Sigma > TheBestSigma)
                {
                    TheBestSigma = Sigma;
                    TheBestTreshold = Threshold;
                }
            }

            for (int i = 0; i < ImgBytes.GetLength(0); i += 3)
            {
                if (TheBestTreshold >= (0.0721 * ImgBytes[i] + 0.7154 * ImgBytes[i + 1] + 0.2125 * ImgBytes[i + 2])) 
                {
                    ImgBytes[i] = 0;
                    ImgBytes[i + 1] = 0;
                    ImgBytes[i + 2] = 0;
                }
                else
                {
                    ImgBytes[i] = 255;
                    ImgBytes[i + 1] = 255;
                    ImgBytes[i + 2] = 255;
                }
            }

            Bitmap img_ret = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            img_ret.SetResolution(Transforming_Pic.HorizontalResolution, Transforming_Pic.VerticalResolution);
            ToBitmap(img_ret, ImgBytes);
            return img_ret;
        }
        //static public Bitmap Niblec(Bitmap Transforming_Pic, int Size, double K = -0.2)
        //{
        //    int width = Transforming_Pic.Width;
        //    int height = Transforming_Pic.Height;
        //    byte[] ImgBytes = new byte[0];
        //    int size = Size * Size;

        //    using (Bitmap _tmp = new Bitmap(width, height, PixelFormat.Format24bppRgb))
        //    {
        //        _tmp.SetResolution(Transforming_Pic.HorizontalResolution, Transforming_Pic.VerticalResolution);
        //        using (var g = Graphics.FromImage(_tmp))
        //        {
        //            g.DrawImageUnscaled(Transforming_Pic, 0, 0);
        //        }
        //        ImgBytes = ToArray(_tmp);
        //    }

        //    for (int i = 0; i < ImgBytes.Length; i+=3)
        //    {
        //        List<double> Pixels_in_zone = new List<double>();
        //        for (int j = i; j <= i + size * 3 && j < ImgBytes.Length; j += 3) 
        //        {
        //            Pixels_in_zone.Add(0.0721 * ImgBytes[j] + 0.7154 * ImgBytes[j + 1] + 0.2125 * ImgBytes[j + 2]);
        //            if (j == i + size * 3) 
        //            {
        //                double Math_expect = 0;
        //                double Dispertion = 0;
        //                double Math_expect2 = 0;
        //                Math_expect = Pixels_in_zone.Sum() / Pixels_in_zone.Count;
        //                Math_expect2 = Pixels_in_zone.Select(x => x * x).Sum() / Pixels_in_zone.Count;
        //                Dispertion = Math_expect2 - Math_expect * Math_expect;
        //                double Threshold = (Math_expect + K * Math.Sqrt(Dispertion));
        //                if (Threshold >= (0.0721 * ImgBytes[i] + 0.7154 * ImgBytes[i + 1] + 0.2125 * ImgBytes[i + 2]))
        //                {
        //                    ImgBytes[i] = 0;
        //                    ImgBytes[i + 1] = 0;
        //                    ImgBytes[i + 2] = 0;
        //                }
        //                else
        //                {
        //                    ImgBytes[i] = 255;
        //                    ImgBytes[i + 1] = 255;
        //                    ImgBytes[i + 2] = 255;
        //                }
        //                Pixels_in_zone.Clear();
        //            }
        //        }
                
        //    }

        //    Bitmap img_ret = new Bitmap(width, height, PixelFormat.Format24bppRgb);
        //    img_ret.SetResolution(Transforming_Pic.HorizontalResolution, Transforming_Pic.VerticalResolution);
        //    ToBitmap(img_ret, ImgBytes);
        //    return img_ret;
        //}
        static public Bitmap Niblec(Bitmap Transforming_Pic, int Size, double K)
        {
            int width = Transforming_Pic.Width;
            int height = Transforming_Pic.Height;
            byte[] ImgBytes = new byte[0];
            int[,] Img = new int[height,width];

            using (Bitmap _tmp = new Bitmap(width, height, PixelFormat.Format24bppRgb))
            {
                _tmp.SetResolution(Transforming_Pic.HorizontalResolution, Transforming_Pic.VerticalResolution);
                using (var g = Graphics.FromImage(_tmp))
                {
                    g.DrawImageUnscaled(Transforming_Pic, 0, 0);
                }
                ImgBytes = ToArray(_tmp);
            }

            for (int i = 0; i < ImgBytes.Length; i+=3)
            {
                ImgBytes[i] = (byte)(0.0721 * ImgBytes[i]);
                ImgBytes[i + 1] = (byte)(0.7154 * ImgBytes[i + 1]);
                ImgBytes[i + 2] = (byte)(0.2125 * ImgBytes[i + 2]);
            }
            int t = 0;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Img[i, j] = ImgBytes[t]+ ImgBytes[t+1]+ ImgBytes[t+2];
                    t+=3;
                }
            }

            List<double> Thresholds = new List<double>();
            for (int i = 0; i < Img.GetLength(0); i++)
            {
                for (int j = 0; j < Img.GetLength(1); j++)
                {
                    double Math_expect = 0;
                    double Dispertion = 0;
                    double Math_expect2 = 0;
                    List<double> Values = BinTransformClass.Values(i, j, Size, Img);
                    Math_expect = Values.Average();
                    Math_expect2 = Values.Select(x => x * x).Average();
                    Dispertion = Math_expect2 - Math_expect * Math_expect;
                    double Sigma = Math.Sqrt(Dispertion);
                    double Threshold = (Math_expect + K * Sigma);
                    Thresholds.Add(Threshold);
                    //if (Threshold >= Img[i,j])
                    //{
                    //    Img[i, j] = 0;
                    //}
                    //else
                    //{
                    //    Img[i, j] = 255;
                    //}
                }
            }

            //t = 0;
            //byte[] Temp = new byte[width * height];
            //for (int i = 0; i < Img.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Img.GetLength(1); j++)
            //    {
            //        Temp[t] = (byte)Img[i, j];
            //        t++;
            //    }
            //}

            t = 0;
            for (int i = 0; i < ImgBytes.Length; i += 3)
            {
                if (Thresholds[t] >= (ImgBytes[i] + ImgBytes[i + 1] + ImgBytes[i + 2]))
                {
                    ImgBytes[i] = 0;
                    ImgBytes[i + 1] = 0;
                    ImgBytes[i + 2] = 0;
                    t++;
                }
                else
                {
                    ImgBytes[i] = 255;
                    ImgBytes[i + 1] = 255;
                    ImgBytes[i + 2] = 255;
                    t++;
                }
            }

            Bitmap img_ret = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            img_ret.SetResolution(Transforming_Pic.HorizontalResolution, Transforming_Pic.VerticalResolution);
            ToBitmap(img_ret, ImgBytes);
            return img_ret;
        }
        static public Bitmap Sauvol(Bitmap Transforming_Pic, int Size, double K)
        {
            int width = Transforming_Pic.Width;
            int height = Transforming_Pic.Height;
            byte[] ImgBytes = new byte[0];
            int[,] Img = new int[height, width];

            using (Bitmap _tmp = new Bitmap(width, height, PixelFormat.Format24bppRgb))
            {
                _tmp.SetResolution(Transforming_Pic.HorizontalResolution, Transforming_Pic.VerticalResolution);
                using (var g = Graphics.FromImage(_tmp))
                {
                    g.DrawImageUnscaled(Transforming_Pic, 0, 0);
                }
                ImgBytes = ToArray(_tmp);
            }

            for (int i = 0; i < ImgBytes.Length; i += 3)
            {
                ImgBytes[i] = (byte)(0.0721 * ImgBytes[i]);
                ImgBytes[i + 1] = (byte)(0.7154 * ImgBytes[i + 1]);
                ImgBytes[i + 2] = (byte)(0.2125 * ImgBytes[i + 2]);
            }
            int t = 0;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Img[i, j] = ImgBytes[t] + ImgBytes[t + 1] + ImgBytes[t + 2];
                    t += 3;
                }
            }
            List<double> Thresholds = new List<double>();
            for (int i = 0; i < Img.GetLength(0); i++)
            {
                for (int j = 0; j < Img.GetLength(1); j++)
                {
                    double Math_expect = 0;
                    double Dispertion = 0;
                    double Math_expect2 = 0;
                    List<double> Values = BinTransformClass.Values(i, j, Size, Img);
                    Math_expect = Values.Average();
                    Math_expect2 = Values.Select(x => x * x).Average();
                    Dispertion = Math_expect2 - Math_expect * Math_expect;
                    double Sigma = Math.Sqrt(Dispertion);
                    double Threshold = Math_expect * (1 + K * (Sigma / 128 - 1)); ;
                    Thresholds.Add(Threshold);
                }
            }
            t = 0;
            for (int i = 0; i < ImgBytes.Length; i += 3)
            {
                if (Thresholds[t] >= (ImgBytes[i] + ImgBytes[i + 1] + ImgBytes[i + 2]))
                {
                    ImgBytes[i] = 0;
                    ImgBytes[i + 1] = 0;
                    ImgBytes[i + 2] = 0;
                    t++;
                }
                else
                {
                    ImgBytes[i] = 255;
                    ImgBytes[i + 1] = 255;
                    ImgBytes[i + 2] = 255;
                    t++;
                }
            }

            Bitmap img_ret = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            img_ret.SetResolution(Transforming_Pic.HorizontalResolution, Transforming_Pic.VerticalResolution);
            ToBitmap(img_ret, ImgBytes);
            return img_ret;
        }
    }
}
