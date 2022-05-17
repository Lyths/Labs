using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    public partial class Fourth_Lab : Form
    {
        private Bitmap Transforming_Pic = null;
        public Fourth_Lab(string Transforming_Pic)
        {
            InitializeComponent();

            this.Transforming_Pic = new Bitmap(Transforming_Pic);
            FourthBox.Image = this.Transforming_Pic;
        }

        private void Median_Click(object sender, EventArgs e)
        {
            Bitmap resultBitmap = new Bitmap((Bitmap)FourthBox.Image);
            FourthBox2.Image = Fourth_Lab_Class.MedianFilter(resultBitmap, Convert.ToInt32(textBox.Text));
        }

        
        private void Linear_Click(object sender, EventArgs e)
        {
            Bitmap sourceBitmap = new Bitmap((Bitmap)FourthBox.Image);
            FourthBox3.Image = Fourth_Lab_Class.ArithmeticFilter(sourceBitmap);
        }

        private void Gaus_Click(object sender, EventArgs e)
        {
            Bitmap sourceBitmap = new Bitmap((Bitmap)FourthBox.Image);
            FourthBox4.Image = Fourth_Lab_Class.Convolve(sourceBitmap, Fourth_Lab_Class.GaussianBlur(Convert.ToInt32(SigmaBox.Text), Convert.ToInt32(SizeBox.Text)));
        }
    }
}
