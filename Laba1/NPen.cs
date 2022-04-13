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
        static private Point[] Array_of_Points;
        public NPen()
        {
            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true);

            Paint += p_event;

            Timer y = new Timer();
            y.Interval = 30;
            y.Tick += (s, a) => { this.Refresh(); };

            VisibleChanged += (s, a) => { y.Start(); };
        }

         static public void ter(List<Point> List_of_coord)
        {
            Array_of_Points = List_of_coord.ToArray();
        }

        public void p_event(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            
            foreach (var item in Array_of_Points)
            {
                e.Graphics.FillRectangle(Brushes.Red, new Rectangle(item.X, item.Y, 15, 15));
            }
            e.Graphics.DrawLines(new Pen(Brushes.Black), Array_of_Points);

        }
        
    }
}
