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
    public partial class Fourth_Lab : Form
    {
        private Bitmap Transforming_Pic = null;
        public Fourth_Lab(string Tranforming_Pic)
        {
            InitializeComponent();

            this.Transforming_Pic = new Bitmap(Transforming_Pic);
            FourthBox.Image = this.Transforming_Pic;

        }
    }
}
