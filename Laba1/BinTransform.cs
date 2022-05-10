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
            BinBox.Image = this.Transforming_Pic;
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            if (GavrilovMethod.Checked == false)
            {
                MessageBox.Show("Отметьте метод обработки!");
                return;
            }
            if (GavrilovMethod.Checked == true)
            {
                Transforming_Pic = BinTransformClass.Gavrilov(Transforming_Pic);
            }
            BinBox.Refresh();
        }
    }
}
