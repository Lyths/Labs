namespace Laba1
{
    partial class Fifth_Lab
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
            this.StartBox = new System.Windows.Forms.PictureBox();
            this.GreyBox = new System.Windows.Forms.PictureBox();
            this.FurieBox = new System.Windows.Forms.PictureBox();
            this.Box = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StartBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FurieBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box)).BeginInit();
            this.SuspendLayout();
            // 
            // StartBox
            // 
            this.StartBox.Location = new System.Drawing.Point(12, 12);
            this.StartBox.Name = "StartBox";
            this.StartBox.Size = new System.Drawing.Size(235, 201);
            this.StartBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StartBox.TabIndex = 0;
            this.StartBox.TabStop = false;
            // 
            // GreyBox
            // 
            this.GreyBox.Location = new System.Drawing.Point(263, 12);
            this.GreyBox.Name = "GreyBox";
            this.GreyBox.Size = new System.Drawing.Size(235, 201);
            this.GreyBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GreyBox.TabIndex = 1;
            this.GreyBox.TabStop = false;
            // 
            // FurieBox
            // 
            this.FurieBox.Location = new System.Drawing.Point(516, 12);
            this.FurieBox.Name = "FurieBox";
            this.FurieBox.Size = new System.Drawing.Size(235, 201);
            this.FurieBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FurieBox.TabIndex = 2;
            this.FurieBox.TabStop = false;
            // 
            // Box
            // 
            this.Box.Location = new System.Drawing.Point(767, 12);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(235, 201);
            this.Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Box.TabIndex = 3;
            this.Box.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Click";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(725, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Click";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Fifth_Lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 504);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.FurieBox);
            this.Controls.Add(this.GreyBox);
            this.Controls.Add(this.StartBox);
            this.Name = "Fifth_Lab";
            this.Text = "Fifth_Lab";
            ((System.ComponentModel.ISupportInitialize)(this.StartBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FurieBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox StartBox;
        private System.Windows.Forms.PictureBox GreyBox;
        private System.Windows.Forms.PictureBox FurieBox;
        private System.Windows.Forms.PictureBox Box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}