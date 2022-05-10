namespace Laba1
{
    partial class BinTransform
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
            this.BinBox = new System.Windows.Forms.PictureBox();
            this.Apply = new System.Windows.Forms.Button();
            this.GavrilovMethod = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.BinBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BinBox
            // 
            this.BinBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BinBox.Location = new System.Drawing.Point(12, 12);
            this.BinBox.Name = "BinBox";
            this.BinBox.Size = new System.Drawing.Size(332, 271);
            this.BinBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BinBox.TabIndex = 0;
            this.BinBox.TabStop = false;
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(519, 111);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(117, 57);
            this.Apply.TabIndex = 1;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // GavrilovMethod
            // 
            this.GavrilovMethod.AutoSize = true;
            this.GavrilovMethod.Location = new System.Drawing.Point(361, 52);
            this.GavrilovMethod.Name = "GavrilovMethod";
            this.GavrilovMethod.Size = new System.Drawing.Size(115, 17);
            this.GavrilovMethod.TabIndex = 2;
            this.GavrilovMethod.Text = "Метод Гаврилова";
            this.GavrilovMethod.UseVisualStyleBackColor = true;
            // 
            // BinTransform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GavrilovMethod);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.BinBox);
            this.Name = "BinTransform";
            this.Text = "BinTransform";
            ((System.ComponentModel.ISupportInitialize)(this.BinBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BinBox;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.CheckBox GavrilovMethod;
    }
}