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
        private List<Point> PointList = new List<Point>();
        private bool isDown = false;
        private Point OldLocation;
        private Point[] Points;
        public NPen()
        {
            PointList.Add(new Point(390, 0));
            PointList.Add(new Point(0, 298));
            Points = new Point[PointList.Count];
            Func();
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

        private void Func()
        {

            Points = new Point[PointList.Count];
            PointList.CopyTo(Points);
        }

        private void Pen_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown == true)
            {

            }
        }

        private void Pen_MouseUp(object sender, MouseEventArgs e)
        {
            PointList.Insert(1, new Point(e.X, e.Y));
            Func();
            isDown = false;
        }

        private void Pen_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                OldLocation = e.Location;

            }
            else if (e.Button == MouseButtons.Right)
            {
            }

        }

        public void p_event(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Red, new Rectangle(390, 0, 15, 15));
            e.Graphics.FillRectangle(Brushes.Red, new Rectangle(0, 298, 15, 15));
            if (Points.Length != 0)
            {
                foreach (var item in PointList)
                {
                    e.Graphics.FillRectangle(Brushes.Red, new Rectangle(item.X, item.Y, 15, 15));
                }
                e.Graphics.DrawLines(new Pen(Brushes.Black), Points);

            }
        }
    }
}
