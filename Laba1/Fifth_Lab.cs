using AForge.Imaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    public partial class Fifth_Lab : Form
    {
        private Bitmap Transforming_Pic = null;
        public Fifth_Lab(string Transforming_Pic)
        {
            InitializeComponent();

            this.Transforming_Pic = new Bitmap(Transforming_Pic);
            StartBox.Image = this.Transforming_Pic;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap ResultBox = new Bitmap((Bitmap)StartBox.Image);
            Fifth_LabClass.Convert2GrayScaleFast(ResultBox);
            GreyBox.Image = ResultBox;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)StartBox.Image;
            Bitmap grayScaleBP = new Bitmap(2, 2, PixelFormat.Format8bppIndexed);
            Rectangle cloneRect = new Rectangle(0, 0, 512, 512);
            grayScaleBP = source.Clone(cloneRect, PixelFormat.Format8bppIndexed);
            ComplexImage complexImage = ComplexImage.FromBitmap(grayScaleBP);
            complexImage.ForwardFourierTransform();
            Bitmap fourierImage = complexImage.ToBitmap();

            FurieBox.Image = fourierImage;

            complexImage.BackwardFourierTransform();
            Box.Image = complexImage.ToBitmap();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
