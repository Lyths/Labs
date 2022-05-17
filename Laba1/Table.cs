using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.ComponentModel;



namespace Laba1
{
    internal class Table
    {
        public int Num { get; set; }
        public string Name { get; }
        public string Regime { get; }
        public bool Red { get; }
        public bool Green { get; }
        public bool Blue { get; }
        public string Path { get; }

        public Table(int Num, string Name, string Regime , bool Red, bool Green, bool Blue, string Path)
        {
            this.Num = Num;
            this.Regime = Regime;
            this.Red = Red;
            this.Green = Green;
            this.Blue = Blue;
            this.Name = Name;
            this.Path = Path;
        }
        public static Bitmap ResizeBitmap(Bitmap bmp, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }

            return result;
        }
        public static T Clamp<T>(T val, T min, T max) where T : IComparable<T>
        {
            if (val.CompareTo(min) < 0) return min;
            else if (val.CompareTo(max) > 0) return max;
            else return val;
        }

        public static void W_and_H(ref Bitmap image_out, ref Bitmap bitmap_from_list)
        {
            if (image_out.Width > bitmap_from_list.Width)
            {
                bitmap_from_list = ResizeBitmap(bitmap_from_list, image_out.Width, bitmap_from_list.Height);
            }
            else
            {
                image_out = ResizeBitmap(image_out, bitmap_from_list.Width, image_out.Height);
            }

            if (image_out.Height > bitmap_from_list.Height)
            {
                bitmap_from_list = ResizeBitmap(bitmap_from_list, bitmap_from_list.Width, image_out.Height);
            }
            else
            {
                image_out = ResizeBitmap(image_out, image_out.Width, bitmap_from_list.Height);
            }
        }

        public static Bitmap Con( BindingList<Table> images) 
        {
            Bitmap return_image_out = null;

            foreach (var im_from_list in images)
            {
                Bitmap bitmap_from_list = new Bitmap(im_from_list.Path);

                Bitmap image_out = new Bitmap(bitmap_from_list.Width, bitmap_from_list.Height);

                switch (im_from_list.Regime)
                {
                    case "Основа":
                        {
                            for (int i = 0; i < bitmap_from_list.Height; ++i)
                            {
                                for (int j = 0; j < bitmap_from_list.Width; ++j)
                                {
                                    var pix_from_list = bitmap_from_list.GetPixel(j, i);

                                    int Red = pix_from_list.R;
                                    int Green = pix_from_list.G;
                                    int Blue = pix_from_list.B;

                                    pix_from_list = Color.FromArgb(Red, Green, Blue);
                                    image_out.SetPixel(j, i, pix_from_list);
                                }
                            }
                        }
                        break;

                    case "Нет":
                        {
                            image_out = return_image_out;
                            W_and_H(ref image_out, ref bitmap_from_list);

                            for (int i = 0; i < bitmap_from_list.Height; ++i)
                            {
                                for (int j = 0; j < bitmap_from_list.Width; ++j)
                                {
                                    var pix_from_list = bitmap_from_list.GetPixel(j, i);
                                    var pix_from_image_out = image_out.GetPixel(j, i);

                                    int Red_from_list = pix_from_list.R;
                                    int Red_from_image_out = pix_from_image_out.R;

                                    int Green_from_list = pix_from_list.G;
                                    int Green_from_image_out = pix_from_image_out.G;

                                    int Blue_from_list = pix_from_list.B;
                                    int Blue_from_image_out = pix_from_image_out.B;

                                    if (Red_from_list != 0 || Green_from_list != 0 || Blue_from_list != 0)
                                    {
                                        pix_from_image_out = Color.FromArgb(Red_from_list, Green_from_list, Blue_from_list);
                                        image_out.SetPixel(j, i, pix_from_image_out);
                                    }
                                }
                            }
                        }
                        break;

                    case "Умножение":
                        {
                            image_out = return_image_out;
                            W_and_H(ref image_out, ref bitmap_from_list);

                            for (int i = 0; i < bitmap_from_list.Height; ++i)
                            {
                                for (int j = 0; j < bitmap_from_list.Width; ++j)
                                {
                                    var pix_from_list = bitmap_from_list.GetPixel(j, i);
                                    var pix_from_image_out = image_out.GetPixel(j, i);

                                    int Red_from_list = new int();
                                    int Red_from_image_out;

                                    int Green_from_list = new int();
                                    int Green_from_image_out;

                                    int Blue_from_list = new int();
                                    int Blue_from_image_out;

                                    if (im_from_list.Red == true)
                                    {
                                        Red_from_list = pix_from_list.R;
                                        Red_from_image_out = pix_from_image_out.R;
                                        Red_from_list = (int)Clamp(Red_from_list * Red_from_image_out / 255, 0, 255);
                                    }
                                    if (im_from_list.Green == true)
                                    {
                                        Green_from_list = pix_from_list.G;
                                        Green_from_image_out = pix_from_image_out.G;
                                        Green_from_list = (int)Clamp(Green_from_list * Green_from_image_out / 255, 0, 255);
                                    }
                                    if (im_from_list.Blue == true)
                                    {
                                        Blue_from_list = pix_from_list.B;
                                        Blue_from_image_out = pix_from_image_out.B;
                                        Blue_from_list = (int)Clamp(Blue_from_list * Blue_from_image_out / 255, 0, 255);
                                    }

                                    if (Red_from_list != 0 || Green_from_list != 0 || Blue_from_list != 0)
                                    {
                                        pix_from_image_out = Color.FromArgb(Red_from_list, Green_from_list, Blue_from_list);
                                        image_out.SetPixel(j, i, pix_from_image_out);
                                    }
                                }
                            }
                        }
                        break;

                    case "Сумма":
                        {
                            image_out = return_image_out;
                            W_and_H(ref image_out, ref bitmap_from_list);

                            for (int i = 0; i < bitmap_from_list.Height; ++i)
                            {
                                for (int j = 0; j < bitmap_from_list.Width; ++j)
                                {
                                    var pix_from_list = bitmap_from_list.GetPixel(j, i);
                                    var pix_from_image_out = image_out.GetPixel(j, i);

                                    int Red_from_list = new int();
                                    int Red_from_image_out;

                                    int Green_from_list = new int();
                                    int Green_from_image_out;

                                    int Blue_from_list = new int();
                                    int Blue_from_image_out;

                                    if (im_from_list.Red == true)
                                    {
                                        Red_from_list = pix_from_list.R;
                                        Red_from_image_out = pix_from_image_out.R;
                                        if (Red_from_list != 0)
                                        {
                                            Red_from_list = (int)Clamp(Red_from_list + Red_from_image_out, 0, 255);
                                        }
                                    }
                                    if (im_from_list.Green == true)
                                    {
                                        Green_from_list = pix_from_list.G;
                                        Green_from_image_out = pix_from_image_out.G;
                                        if (Green_from_list != 0)
                                        {
                                            Green_from_list = (int)Clamp(Green_from_list + Green_from_image_out, 0, 255);
                                        }
                                    }
                                    if (im_from_list.Blue == true)
                                    {
                                        Blue_from_list = pix_from_list.B;
                                        Blue_from_image_out = pix_from_image_out.B;
                                        if (Blue_from_list != 0)
                                        {
                                            Blue_from_list = (int)Clamp(Blue_from_list + Blue_from_image_out, 0, 255);
                                        }
                                    }

                                    if (Red_from_list != 0 || Green_from_list != 0 || Blue_from_list != 0)
                                    {
                                        pix_from_image_out = Color.FromArgb(Red_from_list, Green_from_list, Blue_from_list);
                                        image_out.SetPixel(j, i, pix_from_image_out);
                                    }
                                }
                            }
                        }
                        break;

                    case "Разность":
                        {
                            image_out = return_image_out;
                            W_and_H(ref image_out, ref bitmap_from_list);

                            for (int i = 0; i < bitmap_from_list.Height; ++i)
                            {
                                for (int j = 0; j < bitmap_from_list.Width; ++j)    
                                {
                                    var pix_from_list = bitmap_from_list.GetPixel(j, i);
                                    var pix_from_image_out = image_out.GetPixel(j, i);

                                    int Red_from_list = new int();
                                    int Red_from_image_out;

                                    int Green_from_list = new int();
                                    int Green_from_image_out;

                                    int Blue_from_list = new int();
                                    int Blue_from_image_out;

                                    if (im_from_list.Red == true)
                                    {
                                        Red_from_list = pix_from_list.R;
                                        Red_from_image_out = pix_from_image_out.R;
                                        if (Red_from_list !=0)
                                        {
                                            Red_from_list = (int)Clamp(Red_from_image_out - Red_from_list, 0, 255);
                                        }
                                        
                                    }
                                    if (im_from_list.Green == true)
                                    {
                                        Green_from_list = pix_from_list.G;
                                        Green_from_image_out = pix_from_image_out.G;
                                        if (Green_from_list != 0)
                                        {
                                            Green_from_list = (int)Clamp(Green_from_image_out - Green_from_list, 0, 255);
                                        }
                                        
                                    }
                                    if (im_from_list.Blue == true)
                                    {
                                        Blue_from_list = pix_from_list.B;
                                        Blue_from_image_out = pix_from_image_out.B;
                                        if (Blue_from_list != 0)
                                        {
                                            Blue_from_list = (int)Clamp(Blue_from_image_out - Blue_from_list, 0, 255);
                                        }
                                        
                                    }

                                    if (Red_from_list != 0 || Green_from_list != 0 || Blue_from_list != 0)
                                    {
                                        pix_from_image_out = Color.FromArgb(Red_from_list, Green_from_list, Blue_from_list);
                                        image_out.SetPixel(j, i, pix_from_image_out);
                                    }
                                }
                            }
                        }
                        break;

                    case "Минимум":
                        {
                            image_out = return_image_out;
                            W_and_H(ref image_out, ref bitmap_from_list);

                            for (int i = 0; i < bitmap_from_list.Height; ++i)
                            {
                                for (int j = 0; j < bitmap_from_list.Width; ++j)
                                {
                                    var pix_from_list = bitmap_from_list.GetPixel(j, i);
                                    var pix_from_image_out = image_out.GetPixel(j, i);

                                    int Red_from_list = new int();
                                    int Red_from_image_out;

                                    int Green_from_list = new int();
                                    int Green_from_image_out;

                                    int Blue_from_list = new int();
                                    int Blue_from_image_out;

                                    if (im_from_list.Red == true)
                                    {
                                        Red_from_list = pix_from_list.R;
                                        Red_from_image_out = pix_from_image_out.R;
                                        if (Red_from_list <= Red_from_image_out)
                                        {
                                            Red_from_list = (int)Clamp(Red_from_list, 0, 255);
                                        }
                                        else
                                        {
                                            Red_from_list = (int)Clamp(Red_from_image_out, 0, 255);
                                        }
                                        
                                    }
                                    if (im_from_list.Green == true)
                                    {
                                        Green_from_list = pix_from_list.G;
                                        Green_from_image_out = pix_from_image_out.G;
                                        if (Green_from_list <= Green_from_image_out)
                                        {
                                            Green_from_list = (int)Clamp(Green_from_list, 0, 255);
                                        }
                                        else
                                        {
                                            Green_from_list = (int)Clamp(Green_from_image_out, 0, 255);
                                        }
                                    }
                                    if (im_from_list.Blue == true)
                                    {
                                        Blue_from_list = pix_from_list.B;
                                        Blue_from_image_out = pix_from_image_out.B;
                                        if (Blue_from_list <= Blue_from_image_out)
                                        {
                                            Blue_from_list = (int)Clamp(Blue_from_list, 0, 255);
                                        }
                                        else
                                        {
                                            Blue_from_list = (int)Clamp(Blue_from_image_out, 0, 255);
                                        }
                                    }

                                    if (Red_from_list != 0 || Green_from_list != 0 || Blue_from_list != 0)
                                    {
                                        pix_from_image_out = Color.FromArgb(Red_from_list, Green_from_list, Blue_from_list);
                                        image_out.SetPixel(j, i, pix_from_image_out);
                                    }
                                }
                            }
                        }
                        break;

                    case "Максимум":
                        {
                            image_out = return_image_out;
                            W_and_H(ref image_out, ref bitmap_from_list);

                            for (int i = 0; i < bitmap_from_list.Height; ++i)
                            {
                                for (int j = 0; j < bitmap_from_list.Width; ++j)
                                {
                                    var pix_from_list = bitmap_from_list.GetPixel(j, i);
                                    var pix_from_image_out = image_out.GetPixel(j, i);

                                    int Red_from_list = new int();
                                    int Red_from_image_out;

                                    int Green_from_list = new int();
                                    int Green_from_image_out;

                                    int Blue_from_list = new int();
                                    int Blue_from_image_out;

                                    if (im_from_list.Red == true)
                                    {
                                        Red_from_list = pix_from_list.R;
                                        Red_from_image_out = pix_from_image_out.R;
                                        if (Red_from_list != 0)
                                        {
                                            if (Red_from_list >= Red_from_image_out)
                                            {
                                                Red_from_list = (int)Clamp(Red_from_list, 0, 255);
                                            }
                                            else
                                            {
                                                Red_from_list = (int)Clamp(Red_from_image_out, 0, 255);
                                            }
                                        }
                                    }
                                    if (im_from_list.Green == true)
                                    {
                                        Green_from_list = pix_from_list.G;
                                        Green_from_image_out = pix_from_image_out.G;
                                        if (Green_from_list !=0)
                                        {
                                            if (Green_from_list >= Green_from_image_out)
                                            {
                                                Green_from_list = (int)Clamp(Green_from_list, 0, 255);
                                            }
                                            else
                                            {
                                                Green_from_list = (int)Clamp(Green_from_image_out, 0, 255);
                                            }
                                        }
                                    }
                                    if (im_from_list.Blue == true)
                                    {
                                        Blue_from_list = pix_from_list.B;
                                        Blue_from_image_out = pix_from_image_out.B;
                                        if (Blue_from_list !=0)
                                        {
                                            if (Blue_from_list >= Blue_from_image_out)
                                            {
                                                Blue_from_list = (int)Clamp(Blue_from_list, 0, 255);
                                            }
                                            else
                                            {
                                                Blue_from_list = (int)Clamp(Blue_from_image_out, 0, 255);
                                            }
                                        }
                                    }

                                    if (Red_from_list != 0 || Green_from_list != 0 || Blue_from_list != 0)
                                    {
                                        pix_from_image_out = Color.FromArgb(Red_from_list, Green_from_list, Blue_from_list);
                                        image_out.SetPixel(j, i, pix_from_image_out);
                                    }
                                }
                            }
                        }
                        break;
                }
                return_image_out = image_out;
            }
            return return_image_out; 
        }
    }
}
