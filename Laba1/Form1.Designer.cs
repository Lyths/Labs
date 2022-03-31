
namespace Laba1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Open = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_regimes = new System.Windows.Forms.ComboBox();
            this.checkBox_Red = new System.Windows.Forms.CheckBox();
            this.checkBox_Green = new System.Windows.Forms.CheckBox();
            this.checkBox_Blue = new System.Windows.Forms.CheckBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Apply = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 428);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(6, 19);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 1;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Enabled = false;
            this.Save.Location = new System.Drawing.Point(119, 19);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Open);
            this.groupBox1.Controls.Add(this.Save);
            this.groupBox1.Location = new System.Drawing.Point(522, 387);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 51);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(3, -5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 452);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // comboBox_regimes
            // 
            this.comboBox_regimes.Enabled = false;
            this.comboBox_regimes.FormattingEnabled = true;
            this.comboBox_regimes.Items.AddRange(new object[] {
            "Нет",
            "Сумма",
            "Разность",
            "Минимум",
            "Максимум",
            "Умножение"});
            this.comboBox_regimes.Location = new System.Drawing.Point(136, 15);
            this.comboBox_regimes.Name = "comboBox_regimes";
            this.comboBox_regimes.Size = new System.Drawing.Size(121, 21);
            this.comboBox_regimes.TabIndex = 1;
            this.comboBox_regimes.SelectedIndexChanged += new System.EventHandler(this.comboBox_regimes_SelectedIndexChanged);
            // 
            // checkBox_Red
            // 
            this.checkBox_Red.AutoSize = true;
            this.checkBox_Red.Enabled = false;
            this.checkBox_Red.Location = new System.Drawing.Point(6, 19);
            this.checkBox_Red.Name = "checkBox_Red";
            this.checkBox_Red.Size = new System.Drawing.Size(49, 17);
            this.checkBox_Red.TabIndex = 5;
            this.checkBox_Red.Text = "RED";
            this.checkBox_Red.UseVisualStyleBackColor = true;
            // 
            // checkBox_Green
            // 
            this.checkBox_Green.AutoSize = true;
            this.checkBox_Green.Enabled = false;
            this.checkBox_Green.Location = new System.Drawing.Point(6, 42);
            this.checkBox_Green.Name = "checkBox_Green";
            this.checkBox_Green.Size = new System.Drawing.Size(64, 17);
            this.checkBox_Green.TabIndex = 6;
            this.checkBox_Green.Text = "GREEN";
            this.checkBox_Green.UseVisualStyleBackColor = true;
            // 
            // checkBox_Blue
            // 
            this.checkBox_Blue.AutoSize = true;
            this.checkBox_Blue.Enabled = false;
            this.checkBox_Blue.Location = new System.Drawing.Point(6, 65);
            this.checkBox_Blue.Name = "checkBox_Blue";
            this.checkBox_Blue.Size = new System.Drawing.Size(54, 17);
            this.checkBox_Blue.TabIndex = 7;
            this.checkBox_Blue.Text = "BLUE";
            this.checkBox_Blue.UseVisualStyleBackColor = true;
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGrid.Location = new System.Drawing.Point(492, 107);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(263, 177);
            this.DataGrid.TabIndex = 8;
            this.DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox_Green);
            this.groupBox3.Controls.Add(this.checkBox_Red);
            this.groupBox3.Controls.Add(this.comboBox_regimes);
            this.groupBox3.Controls.Add(this.checkBox_Blue);
            this.groupBox3.Location = new System.Drawing.Point(492, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 91);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Параметры";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Apply);
            this.groupBox4.Controls.Add(this.Add);
            this.groupBox4.Location = new System.Drawing.Point(522, 339);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 51);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // Apply
            // 
            this.Apply.Enabled = false;
            this.Apply.Location = new System.Drawing.Point(6, 19);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 23);
            this.Apply.TabIndex = 1;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // Add
            // 
            this.Add.Enabled = false;
            this.Add.Location = new System.Drawing.Point(119, 19);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Remove);
            this.groupBox5.Controls.Add(this.Clear);
            this.groupBox5.Location = new System.Drawing.Point(522, 299);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 43);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            // 
            // Clear
            // 
            this.Clear.Enabled = false;
            this.Clear.Location = new System.Drawing.Point(6, 14);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 11;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Remove
            // 
            this.Remove.Enabled = false;
            this.Remove.Location = new System.Drawing.Point(119, 14);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 11;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 452);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Обработочка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_regimes;
        private System.Windows.Forms.CheckBox checkBox_Red;
        private System.Windows.Forms.CheckBox checkBox_Green;
        private System.Windows.Forms.CheckBox checkBox_Blue;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Remove;
    }
}

