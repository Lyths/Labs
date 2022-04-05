namespace Laba1
{
    partial class Gradation_transformations
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TransformedPicture = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CurvesPanel = new System.Windows.Forms.Panel();
            this.Apply_Transformation = new System.Windows.Forms.Button();
            this.ListOfTransformRegimes = new System.Windows.Forms.ComboBox();
            this.ClearChanges = new System.Windows.Forms.Button();
            this.Gistogramma = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransformedPicture)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gistogramma)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Gistogramma);
            this.groupBox1.Location = new System.Drawing.Point(1, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(947, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TransformedPicture);
            this.groupBox2.Location = new System.Drawing.Point(417, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(531, 322);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // TransformedPicture
            // 
            this.TransformedPicture.Location = new System.Drawing.Point(6, 12);
            this.TransformedPicture.Name = "TransformedPicture";
            this.TransformedPicture.Size = new System.Drawing.Size(519, 304);
            this.TransformedPicture.TabIndex = 0;
            this.TransformedPicture.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CurvesPanel);
            this.groupBox3.Location = new System.Drawing.Point(1, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 322);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // CurvesPanel
            // 
            this.CurvesPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurvesPanel.Location = new System.Drawing.Point(6, 12);
            this.CurvesPanel.Name = "CurvesPanel";
            this.CurvesPanel.Size = new System.Drawing.Size(398, 304);
            this.CurvesPanel.TabIndex = 0;
            // 
            // Apply_Transformation
            // 
            this.Apply_Transformation.Location = new System.Drawing.Point(7, 12);
            this.Apply_Transformation.Name = "Apply_Transformation";
            this.Apply_Transformation.Size = new System.Drawing.Size(113, 28);
            this.Apply_Transformation.TabIndex = 3;
            this.Apply_Transformation.Text = "Apply Transform";
            this.Apply_Transformation.UseVisualStyleBackColor = true;
            // 
            // ListOfTransformRegimes
            // 
            this.ListOfTransformRegimes.FormattingEnabled = true;
            this.ListOfTransformRegimes.Location = new System.Drawing.Point(126, 17);
            this.ListOfTransformRegimes.Name = "ListOfTransformRegimes";
            this.ListOfTransformRegimes.Size = new System.Drawing.Size(121, 21);
            this.ListOfTransformRegimes.TabIndex = 4;
            // 
            // ClearChanges
            // 
            this.ClearChanges.Location = new System.Drawing.Point(253, 12);
            this.ClearChanges.Name = "ClearChanges";
            this.ClearChanges.Size = new System.Drawing.Size(113, 28);
            this.ClearChanges.TabIndex = 5;
            this.ClearChanges.Text = "Clear Changes";
            this.ClearChanges.UseVisualStyleBackColor = true;
            // 
            // Gistogramma
            // 
            this.Gistogramma.Location = new System.Drawing.Point(6, 9);
            this.Gistogramma.Name = "Gistogramma";
            this.Gistogramma.Size = new System.Drawing.Size(935, 153);
            this.Gistogramma.TabIndex = 1;
            this.Gistogramma.TabStop = false;
            // 
            // Gradation_transformations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 545);
            this.Controls.Add(this.ClearChanges);
            this.Controls.Add(this.ListOfTransformRegimes);
            this.Controls.Add(this.Apply_Transformation);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Gradation_transformations";
            this.Text = "Gradation_transformations";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TransformedPicture)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gistogramma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox TransformedPicture;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel CurvesPanel;
        private System.Windows.Forms.Button Apply_Transformation;
        private System.Windows.Forms.ComboBox ListOfTransformRegimes;
        private System.Windows.Forms.Button ClearChanges;
        private System.Windows.Forms.PictureBox Gistogramma;
    }
}