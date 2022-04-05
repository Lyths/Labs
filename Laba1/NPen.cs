using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    public partial class NPen : System.Windows.Forms.Panel
    {
        private List<Rectangle> RectList;
        private List<Point> PointList;
        private Point[] Points = new Point[20];
        public NPen()
        {
            RectList = new List<Rectangle>();
            PointList = new List<Point>();
            PointList.Add(new Point(390, 0));
            PointList.Add(new Point(0, 298));
            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true);

            Paint += p_event;

            MouseDown += Pen_MouseDown;
            MouseUp += Pen_MouseUp;
            MouseMove += Pen_MouseMove;

            Timer y = new Timer();
            y.Interval = 30;
            y.Tick += (s, a) => { this.Refresh(); };

            VisibleChanged += (s, a) => { y.Start(); };
        }

        private void Pen_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Pen_MouseUp(object sender, MouseEventArgs e)
        {
            RectList.Add(new Rectangle(e.X, e.Y, 15, 15));
            PointList.Insert(1, new Point(e.X, e.Y));
        }

        private void Pen_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {

            }
            else if (e.Button == MouseButtons.Right)
            {
                RectList.Remove(new Rectangle(e.X, e.Y, 15, 15));
                PointList.Remove(new Point(e.X, e.Y));
            }

        }

        public void p_event(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Red, new Rectangle(390, 0, 15, 15));
            e.Graphics.FillRectangle(Brushes.Red, new Rectangle(0, 298, 15, 15));
            foreach (var item in RectList)
            {
                if (RectList.Count!=0)
                {
                    e.Graphics.FillRectangle(Brushes.Red, item);
                }
            }
            for (int i = 0; i < PointList.Count; i++)
            {
                Points[i] = PointList[i];
            }
            e.Graphics.DrawCurve(new Pen(Brushes.Black), Points);

        }
    }
}
