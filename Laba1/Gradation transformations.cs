using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    public partial class Gradation_transformations : Form
    {
        private Bitmap Transforming_Pic = null;
        private List<Point> Points_of_Curve;
        private Bitmap image = null;
        public Gradation_transformations(string Transforming_Pic)
        {
            InitializeComponent();

            this.Transforming_Pic = new Bitmap(Transforming_Pic);
            TransformedPicture.Image = this.Transforming_Pic;

            Points_of_Curve = new List<Point>();
            Points_of_Curve.Add(new Point(390, 0));
            Points_of_Curve.Add(new Point(0, 298));

            /*var canvas = new NPen();
            canvas.Size = new Size(500, 500);
            canvas.Location = new Point(0, 0);
            NPen.ter(Points_of_Curve);
            CurvesPanel.Controls.Add(canvas);

            image = new Bitmap(256, Gistogramma.Height);
            Gistogramma.Image = image;
            Histogram();*/
        }

        private void Add_coord_Click(object sender, EventArgs e)
        {
            Points_of_Curve.Remove(new Point(0, 298));
            Points_of_Curve.Add(new Point(Convert.ToInt32(X_coord.Text), Convert.ToInt32(Y_coord.Text)));
            Points_of_Curve.Add(new Point(0, 298));
            //NPen.ter(Points_of_Curve);
            Histogram();
        }

         private void Histogram()
        {
            int[] N = new int[256];
            int c;
            int max;
            Point A = new Point();
            Point B = new Point();
            for (int i = 0; i < Transforming_Pic.Height; i++)
            {
                for (int j = 0; j < Transforming_Pic.Width; j++)
                {
                    var pix = Transforming_Pic.GetPixel(j, i);

                    int Red = pix.R;
                    int Green = pix.G;
                    int Blue = pix.B;

                    c = (Red + Green + Blue) / 3;
                    N[c]++;
                }
            }
            max = N.Max();
            Graphics g = Graphics.FromImage(image);
            for (int i = 0; i < 256; i++)
            {
                A = new Point(i, Gistogramma.Height - 1); 
                B = new Point(i, Gistogramma.Height - 1 - N[i]* Gistogramma.Height/max);
                g.DrawLine(new Pen(Brushes.Black),A, B);
            }
            Gistogramma.Refresh();
        }

        private void Gistogramma_Click(object sender, EventArgs e)
        {

        }

        private void ClearChanges_Click(object sender, EventArgs e)
        {
            Points_of_Curve.Clear();
            Points_of_Curve.Add(new Point(390, 0));
            Points_of_Curve.Add(new Point(0, 298));
            //NPen.ter(Points_of_Curve);
            Histogram();
            TransformedPicture.Image = Transforming_Pic;
            TransformedPicture.Refresh();
        }

        private void Apply_Transformation_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog savefile = new SaveFileDialog())
            {

                savefile.InitialDirectory = Directory.GetCurrentDirectory();
                savefile.Filter = "Картинки (png, jpg, bmp, gif) |*.png;*.jpg;*.bmp;*.gif|All files (*.*)|*.*";
                savefile.RestoreDirectory = true;
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    if (Transforming_Pic != null)
                    {
                        Transforming_Pic.Save(savefile.FileName);

                    }
                }
            }
        }
    }
}
