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
    internal class Fourth_Lab_Class
    {
        public static Bitmap MedianFilter(Bitmap sourceBitmap, int matrixSize)
        {
            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            bool grayscale = false;

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];

            byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);
            sourceBitmap.UnlockBits(sourceData);

            //Gray-scale
            if (grayscale == true)
            {
                float rgb;

                for (int k = 0; k < pixelBuffer.Length; k += 4)
                {
                    rgb = pixelBuffer[k] * 0.11f;
                    rgb += pixelBuffer[k + 1] * 0.59f;
                    rgb += pixelBuffer[k + 2] * 0.3f;


                    pixelBuffer[k] = (byte)rgb;
                    pixelBuffer[k + 1] = pixelBuffer[k];
                    pixelBuffer[k + 2] = pixelBuffer[k];
                    pixelBuffer[k + 3] = 255;
                }
            }

            /*filterOffset:index value for defining extra-matrix
              calcOffset:define amount of pixels in the extra-matrix
              byteOffset:define amout of pixels in the origin matrix
             */
            int filterOffset = (matrixSize - 1) / 2;
            int calcOffset;
            int byteOffset;

            //медианы.
            List<int> neighbourPixels = new List<int>();
            byte[] middlePixel;

            //Основной алгоритм
            for (int offsetY = filterOffset; offsetY < sourceBitmap.Height - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX < sourceBitmap.Width - filterOffset; offsetX++)
                {
                    byteOffset = offsetY * sourceData.Stride + offsetX * 4; //4 из-за учета 4 компонентов из pixelBuffer
                    neighbourPixels.Clear();

                    //значение пикселя рядом (слева, вверху) в отрицательном положении по сравнению с рассматриваемым пикселем
                    for (int filterY = -filterOffset; filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset; filterX <= filterOffset; filterX++)
                        {
                            calcOffset = byteOffset + (filterX * 4) + (filterY * sourceData.Stride);

                            //добавить целочисленное значение (медиану) в качестве соседнего пикселя
                            neighbourPixels.Add(BitConverter.ToInt32(pixelBuffer, calcOffset));

                        }
                    }
                    neighbourPixels.Sort();

                    //назначение определенного среднего пикселя текущему пикселю в виде массива байтов компонента цвета пикселя.
                    middlePixel = BitConverter.GetBytes(neighbourPixels[filterOffset]);

                    resultBuffer[byteOffset] = middlePixel[0];
                    resultBuffer[byteOffset + 1] = middlePixel[1];
                    resultBuffer[byteOffset + 2] = middlePixel[2];
                    resultBuffer[byteOffset + 3] = middlePixel[3];
                }
            }

            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);
            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0, resultBitmap.Width, resultBitmap.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }

        public static Bitmap ArithmeticFilter(Bitmap image)
        {
            int w = image.Width;
            int h = image.Height;

            BitmapData image_data = image.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            int bytes = image_data.Stride * image_data.Height;
            byte[] buffer = new byte[bytes];
            Marshal.Copy(image_data.Scan0, buffer, 0, bytes);
            image.UnlockBits(image_data);

            //значение r для уменьшения размера (эта фильтрация изменит размер выходного изображения)
            //изменив значение r, мы можем четко получить эффект размытия
            int r = 2;
            int wres = w - 2 * r;
            int hres = h - 2 * r;

            Bitmap result_image = new Bitmap(wres, hres);
            BitmapData result_data = result_image.LockBits(new Rectangle(0, 0, wres, hres), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            int res_bytes = result_data.Stride * result_data.Height;
            byte[] result = new byte[res_bytes];

            for (int x = r; x < w - r; x++)
            {
                for (int y = r; y < h - r; y++)
                {
                    int pixel_location = x * 3 + y * image_data.Stride;
                    int res_pixel_location = (x - r) * 3 + (y - r) * result_data.Stride;
                    double[] mean = new double[3];

                    for (int kx = -r; kx <= r; kx++)
                    {
                        for (int ky = -r; ky <= r; ky++)
                        {
                            int kernel_pixel = pixel_location + kx * 3 + ky * image_data.Stride;

                            for (int c = 0; c < 3; c++)
                            {
                                mean[c] += buffer[kernel_pixel + c] / Math.Pow(2 * r + 2, 2); //прибавляем 1 для r
                            }
                        }
                    }

                    for (int c = 0; c < 3; c++)
                    {
                        result[res_pixel_location + c] = (byte)mean[c];
                    }
                }
            }

            Marshal.Copy(result, 0, result_data.Scan0, res_bytes);
            result_image.UnlockBits(result_data);

            return result_image;
        }

        public static Bitmap Convolve(Bitmap srcImage, double[,] kernel)
        {
            int width = srcImage.Width;
            int height = srcImage.Height;

            BitmapData srcData = srcImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            int bytes = srcData.Stride * srcData.Height;
            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];
            Marshal.Copy(srcData.Scan0, buffer, 0, bytes);
            srcImage.UnlockBits(srcData);

            int colorChannels = 3;
            double[] rgb = new double[colorChannels];
            int foff = (kernel.GetLength(0) - 1) / 2;
            int kcenter;
            int kpixel;
            for (int y = foff; y < height - foff; y++)
            {
                for (int x = foff; x < width - foff; x++)
                {
                    for (int c = 0; c < colorChannels; c++)
                    {
                        rgb[c] = 0.0;
                    }

                    //центральный пиксель получает наибольшее значение Гаусса
                    //соседние пиксели получают меньшие значения по мере увеличения расстояния от начала координат.
                    kcenter = y * srcData.Stride + x * 4;
                    for (int fy = -foff; fy <= foff; fy++)
                    {
                        for (int fx = -foff; fx <= foff; fx++)
                        {
                            kpixel = kcenter + fy * srcData.Stride + fx * 4;
                            for (int c = 0; c < colorChannels; c++)
                            {
                                rgb[c] += (double)(buffer[kpixel + c]) * kernel[fy + foff, fx + foff];
                            }
                        }
                    }

                    //Если значение цветного пикселя превышает (0,255), то вернуться к 0 и 255, перспективно
                    for (int c = 0; c < colorChannels; c++)
                    {
                        if (rgb[c] > 255)
                        {
                            rgb[c] = 255;
                        }
                        else if (rgb[c] < 0)
                        {
                            rgb[c] = 0;
                        }
                    }

                    for (int c = 0; c < colorChannels; c++)
                    {
                        result[kcenter + c] = (byte)rgb[c];
                    }

                    result[kcenter + 3] = 255;
                }
            }

            Bitmap resultImage = new Bitmap(width, height);
            BitmapData resultData = resultImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(result, 0, resultData.Scan0, bytes);
            resultImage.UnlockBits(resultData);
            return resultImage;
        }

        public static double[,] GaussianBlur(double weight, int lenght)
        {
            double[,] kernel = new double[lenght, lenght];
            double kernelSum = 0;
            int foff = (lenght - 1) / 2;
            double distance;
            double constant = 1d / (2 * Math.PI * weight * weight);
            for (int y = -foff; y <= foff; y++)
            {
                for (int x = -foff; x <= foff; x++)
                {
                    distance = ((y * y) + (x * x)) / (2 * weight * weight);
                    kernel[y + foff, x + foff] = constant * Math.Exp(-distance);
                    kernelSum += kernel[y + foff, x + foff];
                }
            }

            //результат выводит ядро ​​для свертки следующего шага
            for (int y = 0; y < lenght; y++)
            {
                for (int x = 0; x < lenght; x++)
                {
                    kernel[y, x] = kernel[y, x] * 1d / kernelSum;
                }
            }

            return kernel;
        }
    }
}
