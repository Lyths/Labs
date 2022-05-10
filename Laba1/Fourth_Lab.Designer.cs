namespace Laba1
{
    partial class Fourth_Lab
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FourthBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FourthBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FourthBox
            // 
            this.FourthBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FourthBox.Location = new System.Drawing.Point(12, 12);
            this.FourthBox.Name = "FourthBox";
            this.FourthBox.Size = new System.Drawing.Size(414, 288);
            this.FourthBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FourthBox.TabIndex = 0;
            this.FourthBox.TabStop = false;
            // 
            // Fourth_Lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FourthBox);
            this.Name = "Fourth_Lab";
            this.Text = "Fourth_Lab";
            ((System.ComponentModel.ISupportInitialize)(this.FourthBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox FourthBox;
    }
}