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
            this.Gistogramma = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TransformedPicture = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CurvesPanel = new System.Windows.Forms.Panel();
            this.Apply_Transformation = new System.Windows.Forms.Button();
            this.ClearChanges = new System.Windows.Forms.Button();
            this.X_coord = new System.Windows.Forms.TextBox();
            this.Y_coord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Add_coord = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gistogramma)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransformedPicture)).BeginInit();
            this.groupBox3.SuspendLayout();
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
            // Gistogramma
            // 
            this.Gistogramma.Location = new System.Drawing.Point(6, 9);
            this.Gistogramma.Name = "Gistogramma";
            this.Gistogramma.Size = new System.Drawing.Size(935, 153);
            this.Gistogramma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Gistogramma.TabIndex = 1;
            this.Gistogramma.TabStop = false;
            this.Gistogramma.Click += new System.EventHandler(this.Gistogramma_Click);
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
            this.TransformedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
            this.Apply_Transformation.Click += new System.EventHandler(this.Apply_Transformation_Click);
            // 
            // ClearChanges
            // 
            this.ClearChanges.Location = new System.Drawing.Point(253, 12);
            this.ClearChanges.Name = "ClearChanges";
            this.ClearChanges.Size = new System.Drawing.Size(113, 28);
            this.ClearChanges.TabIndex = 5;
            this.ClearChanges.Text = "Clear Changes";
            this.ClearChanges.UseVisualStyleBackColor = true;
            this.ClearChanges.Click += new System.EventHandler(this.ClearChanges_Click);
            // 
            // X_coord
            // 
            this.X_coord.Location = new System.Drawing.Point(417, 17);
            this.X_coord.Name = "X_coord";
            this.X_coord.Size = new System.Drawing.Size(58, 20);
            this.X_coord.TabIndex = 6;
            // 
            // Y_coord
            // 
            this.Y_coord.Location = new System.Drawing.Point(532, 17);
            this.Y_coord.Name = "Y_coord";
            this.Y_coord.Size = new System.Drawing.Size(58, 20);
            this.Y_coord.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "X = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Y = ";
            // 
            // Add_coord
            // 
            this.Add_coord.Location = new System.Drawing.Point(615, 15);
            this.Add_coord.Name = "Add_coord";
            this.Add_coord.Size = new System.Drawing.Size(111, 23);
            this.Add_coord.TabIndex = 10;
            this.Add_coord.Text = "Add coordinates";
            this.Add_coord.UseVisualStyleBackColor = true;
            this.Add_coord.Click += new System.EventHandler(this.Add_coord_Click);
            // 
            // Gradation_transformations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 545);
            this.Controls.Add(this.Add_coord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Y_coord);
            this.Controls.Add(this.X_coord);
            this.Controls.Add(this.ClearChanges);
            this.Controls.Add(this.Apply_Transformation);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Gradation_transformations";
            this.Text = "Gradation_transformations";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gistogramma)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TransformedPicture)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox TransformedPicture;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Apply_Transformation;
        private System.Windows.Forms.Button ClearChanges;
        private System.Windows.Forms.PictureBox Gistogramma;
        private System.Windows.Forms.Panel CurvesPanel;
        private System.Windows.Forms.TextBox X_coord;
        private System.Windows.Forms.TextBox Y_coord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add_coord;
    }
}