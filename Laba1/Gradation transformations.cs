﻿using System;
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
    public partial class Gradation_transformations : Form
    {
        public Gradation_transformations()
        {
            InitializeComponent();

            var canvas = new NPen();
            canvas.Size = new Size(500, 500);
            canvas.Location = new Point(0, 0);
            CurvesPanel.Controls.Add(canvas);  
        }

    }
}
