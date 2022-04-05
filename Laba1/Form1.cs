using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Laba1
{
    public partial class Form1 : Form
    {
        private Bitmap image = null;

        private BindingList<Table> tables;

        private int Counter_Rows = 1;

        string path;

        string name;
        public Form1()
        {
            InitializeComponent();

            image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = image;

            tables = new BindingList<Table>();

        }

        private void Save_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog savefile = new SaveFileDialog())
            {

                savefile.InitialDirectory = Directory.GetCurrentDirectory();
                savefile.Filter = "Картинки (png, jpg, bmp, gif) |*.png;*.jpg;*.bmp;*.gif|All files (*.*)|*.*";
                savefile.RestoreDirectory = true;
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    if (image != null)
                    {
                        image.Save(savefile.FileName);
                        
                    }
                }
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openfile = new OpenFileDialog())
            {
                openfile.InitialDirectory = Directory.GetCurrentDirectory();
                openfile.Filter = "Картинки (png, jpg, bmp, gif) |*.png;*.jpg;*.bmp;*.gif|All files (*.*)|*.*";
                openfile.RestoreDirectory = true;
                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    if (image != null)
                    {
                        pictureBox1.Image = null;
                        image.Dispose();
                    }

                    image = new Bitmap(openfile.FileName);
                    pictureBox1.Image = image;

                    tables.Add(new Table(Counter_Rows, openfile.SafeFileName, "Основа", checkBox_Red.Checked, checkBox_Green.Checked, checkBox_Blue.Checked,  openfile.FileName));
                    name = openfile.SafeFileName;
                    path = openfile.FileName;

                    DataGrid.DataSource = tables;

                    Counter_Rows++;
                    Open.Enabled = false;
                    Save.Enabled = true;
                    Add.Enabled = true;
                    comboBox_regimes.Enabled = true;
                    checkBox_Red.Enabled = true;
                    checkBox_Green.Enabled = true;
                    checkBox_Blue.Enabled = true;
                    Remove.Enabled = false;
                    comboBox_regimes.SelectedItem = "Нет";
                    Clear.Enabled = true;
                    if (comboBox_regimes.Text == "Нет")
                    {
                        checkBox_Red.Enabled = false;
                        checkBox_Green.Enabled = false;
                        checkBox_Blue.Enabled = false;
                    }
                    Gradation_transformations.Enabled = true;
                }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (comboBox_regimes.Text == "")
            {
                MessageBox.Show("Выберите режим обработки изображения");
                return;
            }
            if (checkBox_Red.Checked == false && checkBox_Green.Checked == false && checkBox_Blue.Checked == false && comboBox_regimes.Text != "Нет")
            {
                MessageBox.Show("Выберите цвет обработки изображения");
                return;
            }
            using (OpenFileDialog openfile = new OpenFileDialog())
            {
                openfile.InitialDirectory = Directory.GetCurrentDirectory();
                openfile.Filter = "Картинки (png, jpg, bmp, gif) |*.png;*.jpg;*.bmp;*.gif|All files (*.*)|*.*";
                openfile.RestoreDirectory = true;
                if (openfile.ShowDialog() == DialogResult.OK)
                {

                    tables.Add(new Table(Counter_Rows, openfile.SafeFileName, comboBox_regimes.Text, checkBox_Red.Checked, checkBox_Green.Checked, checkBox_Blue.Checked,  openfile.FileName));
                    DataGrid.DataSource = tables;

                    Counter_Rows++;
                }
                Apply.Enabled = true;
                path = openfile.FileName;
                Remove.Enabled = true;
            }
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                pictureBox1.Image = null;
                image.Dispose();
            }
            image = Table.Con(tables);
            pictureBox1.Image = image;
            pictureBox1.Refresh();
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (image != null)
            {
                pictureBox1.Image = null;
                image.Dispose();
            }
            image = new Bitmap(DataGrid.CurrentRow.Cells[6].Value.ToString());
            pictureBox1.Image = image;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            image.Dispose();
            tables.Clear();
            pictureBox1.Image = null;
            Clear.Enabled = false;
            Save.Enabled = false;
            Add.Enabled = false;
            Apply.Enabled = false;
            Open.Enabled = true;
            Counter_Rows = 1;
            comboBox_regimes.Enabled = false;
            checkBox_Red.Checked = false;
            checkBox_Green.Checked = false;
            checkBox_Blue.Checked = false;
            Remove.Enabled = false;
            comboBox_regimes.SelectedItem = "Нет";
            if (comboBox_regimes.Text == "Нет")
            {
                checkBox_Red.Enabled = false;
                checkBox_Green.Enabled = false;
                checkBox_Blue.Enabled = false;
            }
        }

        private void comboBox_regimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_regimes.Text != "Нет")
            {
                checkBox_Red.Enabled = true;
                checkBox_Green.Enabled = true;
                checkBox_Blue.Enabled = true;
            }
            else
            {
                if (comboBox_regimes.Text == "Нет")
                {
                    checkBox_Red.Enabled = false;
                    checkBox_Green.Enabled = false;
                    checkBox_Blue.Enabled = false;
                }
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                pictureBox1.Image = null;
                image.Dispose();
            }
            if (DataGrid.CurrentRow.Cells[2].Value.ToString() != "Основа")
            {
                int index = tables.IndexOf(tables.FirstOrDefault(x => int.Equals(x.Num, Convert.ToInt32(DataGrid.CurrentRow.Cells[0].Value.ToString()))));
                tables.RemoveAt(index);
                for (int i = index; i < tables.Count; i++)
                {
                    tables[i].Num -= 1;
                }
                Counter_Rows -= 1;
            }
            else
            {
                MessageBox.Show("Удалить основу невозможно");
            }
        }

        private void Gradation_transformations_Click(object sender, EventArgs e)
        {
            Gradation_transformations Window = new Gradation_transformations(); 
            Window.Show();
        }
    }
}
