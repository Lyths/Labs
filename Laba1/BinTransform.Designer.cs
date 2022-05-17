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
            this.StartBox = new System.Windows.Forms.PictureBox();
            this.Apply = new System.Windows.Forms.Button();
            this.GavrilovBox = new System.Windows.Forms.PictureBox();
            this.OtsuBox = new System.Windows.Forms.PictureBox();
            this.NiblecBox = new System.Windows.Forms.PictureBox();
            this.OtsuButton = new System.Windows.Forms.Button();
            this.NiblecButton = new System.Windows.Forms.Button();
            this.SauvBox = new System.Windows.Forms.PictureBox();
            this.SauvButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StartBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GavrilovBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtsuBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NiblecBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SauvBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StartBox
            // 
            this.StartBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartBox.Location = new System.Drawing.Point(24, 22);
            this.StartBox.Name = "StartBox";
            this.StartBox.Size = new System.Drawing.Size(213, 183);
            this.StartBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StartBox.TabIndex = 0;
            this.StartBox.TabStop = false;
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(296, 211);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(117, 28);
            this.Apply.TabIndex = 1;
            this.Apply.Text = "Gavrilov";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // GavrilovBox
            // 
            this.GavrilovBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GavrilovBox.Location = new System.Drawing.Point(254, 22);
            this.GavrilovBox.Name = "GavrilovBox";
            this.GavrilovBox.Size = new System.Drawing.Size(218, 183);
            this.GavrilovBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GavrilovBox.TabIndex = 3;
            this.GavrilovBox.TabStop = false;
            // 
            // OtsuBox
            // 
            this.OtsuBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OtsuBox.Location = new System.Drawing.Point(490, 22);
            this.OtsuBox.Name = "OtsuBox";
            this.OtsuBox.Size = new System.Drawing.Size(218, 183);
            this.OtsuBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OtsuBox.TabIndex = 4;
            this.OtsuBox.TabStop = false;
            // 
            // NiblecBox
            // 
            this.NiblecBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NiblecBox.Location = new System.Drawing.Point(725, 22);
            this.NiblecBox.Name = "NiblecBox";
            this.NiblecBox.Size = new System.Drawing.Size(218, 183);
            this.NiblecBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NiblecBox.TabIndex = 5;
            this.NiblecBox.TabStop = false;
            // 
            // OtsuButton
            // 
            this.OtsuButton.Location = new System.Drawing.Point(541, 211);
            this.OtsuButton.Name = "OtsuButton";
            this.OtsuButton.Size = new System.Drawing.Size(117, 28);
            this.OtsuButton.TabIndex = 6;
            this.OtsuButton.Text = "Otsu";
            this.OtsuButton.UseVisualStyleBackColor = true;
            this.OtsuButton.Click += new System.EventHandler(this.OtsuButton_Click);
            // 
            // NiblecButton
            // 
            this.NiblecButton.Location = new System.Drawing.Point(783, 211);
            this.NiblecButton.Name = "NiblecButton";
            this.NiblecButton.Size = new System.Drawing.Size(117, 28);
            this.NiblecButton.TabIndex = 7;
            this.NiblecButton.Text = "Niblec";
            this.NiblecButton.UseVisualStyleBackColor = true;
            this.NiblecButton.Click += new System.EventHandler(this.NiblecButton_Click);
            // 
            // SauvBox
            // 
            this.SauvBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SauvBox.Location = new System.Drawing.Point(24, 305);
            this.SauvBox.Name = "SauvBox";
            this.SauvBox.Size = new System.Drawing.Size(213, 183);
            this.SauvBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SauvBox.TabIndex = 8;
            this.SauvBox.TabStop = false;
            // 
            // SauvButton
            // 
            this.SauvButton.Location = new System.Drawing.Point(296, 388);
            this.SauvButton.Name = "SauvButton";
            this.SauvButton.Size = new System.Drawing.Size(117, 28);
            this.SauvButton.TabIndex = 9;
            this.SauvButton.Text = "Sauv";
            this.SauvButton.UseVisualStyleBackColor = true;
            this.SauvButton.Click += new System.EventHandler(this.SauvButton_Click);
            // 
            // BinTransform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 583);
            this.Controls.Add(this.SauvButton);
            this.Controls.Add(this.SauvBox);
            this.Controls.Add(this.NiblecButton);
            this.Controls.Add(this.OtsuButton);
            this.Controls.Add(this.NiblecBox);
            this.Controls.Add(this.OtsuBox);
            this.Controls.Add(this.GavrilovBox);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.StartBox);
            this.Name = "BinTransform";
            this.Text = "BinTransform";
            ((System.ComponentModel.ISupportInitialize)(this.StartBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GavrilovBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtsuBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NiblecBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SauvBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox StartBox;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.PictureBox GavrilovBox;
        private System.Windows.Forms.PictureBox OtsuBox;
        private System.Windows.Forms.PictureBox NiblecBox;
        private System.Windows.Forms.Button OtsuButton;
        private System.Windows.Forms.Button NiblecButton;
        private System.Windows.Forms.PictureBox SauvBox;
        private System.Windows.Forms.Button SauvButton;
    }
}