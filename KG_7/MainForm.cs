using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KG_7
{
    public partial class MainForm : Form
    {
        private Image originalImage;

        public MainForm()
        {
            InitializeComponent();
        }

        private void uploadFile_button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Image loadedImage = new Bitmap(openFileDialog.FileName);
                        originalImage = (Image)loadedImage.Clone();
                        pictureBox_image.Image = loadedImage;
                        ResetImageState();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка при загрузке изображения.");
                    }
                }
            }
        }

        private void ResetImageState()
        {
            if (originalImage != null) pictureBox_image.Image = (Image)originalImage.Clone();
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            ResetImageState();
        }
    }
}
