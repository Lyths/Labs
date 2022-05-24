using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    public partial class BinTransform : Form
    {
        private Bitmap Transforming_Pic = null;
        public BinTransform(string Transforming_Pic)
        {
            InitializeComponent();

            this.Transforming_Pic = new Bitmap(Transforming_Pic);
            StartBox.Image = this.Transforming_Pic;
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            Bitmap resultBitmap = new Bitmap((Bitmap)StartBox.Image);
            GavrilovBox.Image = BinTransformClass.Gavrilov(resultBitmap);
        }

        private void OtsuButton_Click(object sender, EventArgs e)
        {
            Bitmap resultBitmap = new Bitmap((Bitmap)StartBox.Image);
            OtsuBox.Image = BinTransformClass.Otsu(resultBitmap);
        }

        private void NiblecButton_Click(object sender, EventArgs e)
        {
            Bitmap resultBitmap = new Bitmap((Bitmap)StartBox.Image);
            NiblecBox.Image = BinTransformClass.Niblec(resultBitmap, 9, -0.2);
        }

        private void Sauvol_Click(object sender, EventArgs e)
        {
            Bitmap resultBitmap = new Bitmap((Bitmap)StartBox.Image);
            SauvolBox.Image = BinTransformClass.Sauvol(resultBitmap, 9, 0.25);
        }
    }
}
