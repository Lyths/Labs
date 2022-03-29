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
    class Table
    {
        public int Num { get; }
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

        public static T Clamp<T>(T val, T min, T max) where T : IComparable<T>
        {
            if (val.CompareTo(min) < 0) return min;
            else if (val.CompareTo(max) > 0) return max;
            else return val;
        }

        public static Bitmap Con( BindingList<Table> images) 
        {
            Bitmap ret = null;
 
            foreach (var im in images)
            {
                Bitmap bitmap = new Bitmap(im.Path);

                var w = bitmap.Width;
                var h = bitmap.Height;

                Bitmap image_out = new Bitmap(w, h);

                switch (im.Regime)
                {
                    case "Основа":
                        for (int i = 0; i < h; ++i)
                        {
                            for (int j = 0; j < w; ++j)
                            {
                                var pix = bitmap.GetPixel(j, i);

                                int red = pix.R;
                                int green = pix.G;
                                int blue = pix.B;

                                pix = Color.FromArgb(red, green, blue);
                                image_out.SetPixel(j, i, pix);
                                ret = image_out;
                            }
                        }
                        break;

                    case "Умножение":
                        image_out = ret;
                        if (w > image_out.Width)
                        {
                            image_out = new Bitmap(image_out, w, ret.Height);
                        }
                        if (h > image_out.Height)
                        {
                            image_out = new Bitmap(image_out, ret.Width, h);
                        }
                        for (int i = 0; i < h; ++i)
                        {
                            for (int j = 0; j < w; ++j)
                            {
                                var pix = bitmap.GetPixel(j, i);
                                var pic = image_out.GetPixel(j, i);

                                int red;
                                int redc = new int();

                                int green;
                                int greenc = new int();

                                int blue;
                                int bluec = new int();

                                if (im.Red == true)
                                {
                                    red = pix.R;
                                    redc = pic.R;
                                    redc = (int)Clamp(redc * red / 255, 0, 255);
                                }
                                if (im.Green == true)
                                {
                                    green = pix.G;
                                    greenc = pic.G;
                                    greenc = (int)Clamp(greenc * green / 255, 0, 255);
                                }
                                if (im.Blue == true)
                                {
                                    blue = pix.B;
                                    bluec = pic.B;
                                    bluec = (int)Clamp(bluec * blue / 255, 0, 255);
                                }
                                if (redc != 0 || greenc != 0 || bluec != 0)
                                {
                                    
                                    pic = Color.FromArgb(redc, greenc, bluec);
                                    image_out.SetPixel(j, i, pic);
                                }
                            }
                        }
                        break;

                    case "Нет":
                        image_out = ret;
                        if (w > image_out.Width)
                        {
                            image_out = new Bitmap(image_out, w, ret.Height);
                        }
                        if (h > image_out.Height)
                        {
                            image_out = new Bitmap(image_out, ret.Width, h);
                        }
                        for (int i = 0; i < h; ++i)
                        {
                            for (int j = 0; j < w; ++j)
                            {
                                var pic = image_out.GetPixel(j, i);
                                var pix = bitmap.GetPixel(j, i);

                                int redc = pic.R;
                                int red = pix.R;

                                int greenc = pic.G;
                                int green = pix.G;

                                int bluec = pic.B;
                                int blue = pix.B;

                                if (red != 0 && green !=0 && blue !=0 )
                                {
                                    red = (int)Clamp(red, 0, 255);
                                    green = (int)Clamp(green, 0, 255);
                                    blue = (int)Clamp(blue, 0, 255);
                                    pic = Color.FromArgb(red, green, blue);
                                    image_out.SetPixel(j, i, pic);
                                }
                            }
                        }
                        break;

                    case "Сумма":
                        image_out = ret;
                        if (w > image_out.Width)
                        {
                            image_out = new Bitmap(image_out, w, ret.Height);
                        }
                        if (h > image_out.Height)
                        {
                            image_out = new Bitmap(image_out, ret.Width, h);
                        }
                        for (int i = 0; i < h; ++i)
                        {
                            for (int j = 0; j < w; ++j)
                            {
                                var pic = image_out.GetPixel(j, i);
                                var pix = bitmap.GetPixel(j, i);

                                int red = new int();
                                int redc;

                                int green = new int();
                                int greenc;

                                int blue = new int();
                                int bluec;

                                if (im.Red == true)
                                {
                                    red = pix.R;
                                    redc = pic.R;
                                    red = (int)Clamp(red + redc, 0, 255);
                                }

                                if (im.Green == true)
                                {
                                    green = pix.G;
                                    greenc = pic.G;
                                    green = (int)Clamp(green + greenc, 0, 255);
                                }

                                if (im.Blue == true)
                                {
                                    blue = pix.B;
                                    bluec = pic.B;
                                    blue = (int)Clamp(blue + bluec, 0, 255);
                                }

                                if (red != 0 || green != 0 || blue != 0)
                                {

                                    pic = Color.FromArgb(red, green, blue);
                                    image_out.SetPixel(j, i, pic);
                                }
                            }
                        }
                        break;

                    case "Разность":
                        image_out = ret;
                        if (w > image_out.Width)
                        {
                            image_out = new Bitmap(image_out, w, ret.Height);
                        }
                        if (h > image_out.Height)
                        {
                            image_out = new Bitmap(image_out, ret.Width, h);
                        }
                        for (int i = 0; i < h; ++i)
                        {
                            for (int j = 0; j < w; ++j)
                            {
                                var pic = image_out.GetPixel(j, i);
                                var pix = bitmap.GetPixel(j, i);

                                int red = new int();
                                int redc;

                                int green = new int();
                                int greenc;

                                int blue = new int();
                                int bluec;

                                if (im.Red == true)
                                {
                                    red = pix.R;
                                    redc = pic.R;
                                    red = (int)Clamp(redc - red, 0, 255);
                                }

                                if (im.Green == true)
                                {
                                    green = pix.G;
                                    greenc = pic.G;
                                    green = (int)Clamp(greenc - green, 0, 255);
                                }

                                if (im.Blue == true)
                                {
                                    blue = pix.B;
                                    bluec = pic.B;
                                    blue = (int)Clamp(bluec - blue, 0, 255);
                                }

                                if (red != 0 || green != 0 || blue != 0)
                                {
                                    pic = Color.FromArgb(red, green, blue);
                                    image_out.SetPixel(j, i, pic);
                                }
                            }
                        }
                        break;

                    case "Минимум":
                        image_out = ret;
                        if (w > image_out.Width)
                        {
                            image_out = new Bitmap(image_out, w, ret.Height);
                        }
                        if (h > image_out.Height)
                        {
                            image_out = new Bitmap(image_out, ret.Width, h);
                        }
                        for (int i = 0; i < h; ++i)
                        {
                            for (int j = 0; j < w; ++j)
                            {
                                var pic = image_out.GetPixel(j, i);
                                var pix = bitmap.GetPixel(j, i);

                                int red = new int();
                                int redc;

                                int green = new int();
                                int greenc;

                                int blue = new int();
                                int bluec;

                                if (im.Red == true)
                                {
                                    red = pix.R;
                                    redc = pic.R;
                                    if (red < redc)
                                    {
                                        red = (int)Clamp(red, 0, 255);
                                    }
                                    else
                                    {
                                        red = (int)Clamp(redc, 0, 255);
                                    }
                                }

                                if (im.Green == true)
                                {
                                    green = pix.G;
                                    greenc = pic.G;
                                    if (green < greenc)
                                    {
                                        green = (int)Clamp(green, 0, 255);
                                    }
                                    else
                                    {
                                        green = (int)Clamp(greenc, 0, 255);
                                    }
                                }

                                if (im.Blue == true)
                                {
                                    blue = pix.B;
                                    bluec = pic.B;
                                    if (blue < bluec)
                                    {
                                        blue = (int)Clamp(blue, 0, 255);
                                    }
                                    else
                                    {
                                        blue = (int)Clamp(bluec, 0, 255);
                                    }
                                }

                                if (red != 0 || green != 0 || blue != 0)
                                {
                                    pic = Color.FromArgb(red, green, blue);
                                    image_out.SetPixel(j, i, pic);
                                }
                            }
                        }
                        break;

                    case "Максимум":
                        image_out = ret;
                        if (w > image_out.Width)
                        {
                            image_out = new Bitmap(image_out, w, ret.Height);
                        }
                        if (h > image_out.Height)
                        {
                            image_out = new Bitmap(image_out, ret.Width, h);
                        }
                        for (int i = 0; i < h; ++i)
                        {
                            for (int j = 0; j < w; ++j)
                            {
                                var pic = image_out.GetPixel(j, i);
                                var pix = bitmap.GetPixel(j, i);

                                int red = new int();
                                int redc;

                                int green = new int();
                                int greenc;

                                int blue = new int();
                                int bluec;

                                if (im.Red == true)
                                {
                                    red = pix.R;
                                    redc = pic.R;
                                    if (red > redc)
                                    {
                                        red = (int)Clamp(red, 0, 255);
                                    }
                                    else
                                    {
                                        red = (int)Clamp(redc, 0, 255);
                                    }
                                }

                                if (im.Green == true)
                                {
                                    green = pix.G;
                                    greenc = pic.G;
                                    if (green > greenc)
                                    {
                                        green = (int)Clamp(green, 0, 255);
                                    }
                                    else
                                    {
                                        green = (int)Clamp(greenc, 0, 255);
                                    }
                                }

                                if (im.Blue == true)
                                {
                                    blue = pix.B;
                                    bluec = pic.B;
                                    if (blue > bluec)
                                    {
                                        blue = (int)Clamp(blue, 0, 255);
                                    }
                                    else
                                    {
                                        blue = (int)Clamp(bluec, 0, 255);
                                    }
                                }

                                if (red != 0 || green != 0 || blue != 0)
                                {
                                    pic = Color.FromArgb(red, green, blue);
                                    image_out.SetPixel(j, i, pic);
                                }
                            }
                        }
                        break;
                }
                ret = image_out;
            }
            return ret;
        }
    }
}
