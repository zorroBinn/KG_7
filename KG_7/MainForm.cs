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
            if (originalImage != null)
            {
                pictureBox_image.Image = (Image)originalImage.Clone();
                label_orig_size.Text = originalImage.Size.Width.ToString() + "x" + originalImage.Size.Height.ToString();
                label_cur_size.Text = label_orig_size.Text;
            }
            trackBar_k.Value = 10;
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            ResetImageState();
        }

        private void trackBar_k_ValueChanged(object sender, EventArgs e)
        {
            double k = trackBar_k.Value / 10.0;
            label_k.Text = k.ToString();
        }

        private void button_nearest_neighbor_Click(object sender, EventArgs e)
        {
            double k = trackBar_k.Value / 10.0;
            Bitmap resizedImage = nearestNeighbor((Bitmap)originalImage, k);
            pictureBox_image.Image = resizedImage;
            label_cur_size.Text = resizedImage.Width.ToString() + "x" + resizedImage.Size.Height.ToString();
        }

        private void button_bilinear_smoothing_Click(object sender, EventArgs e)
        {
            double k = trackBar_k.Value / 10.0;
            Bitmap resizedImage = bilinear((Bitmap)originalImage, k);
            pictureBox_image.Image = resizedImage;
            label_cur_size.Text = resizedImage.Width.ToString() + "x" + resizedImage.Size.Height.ToString();
        }

        private Bitmap nearestNeighbor(Bitmap original, double scale) 
        {
            int newWidth = (int)(original.Width * scale);
            int newHeight = (int)(original.Height * scale);
            Bitmap resizedImage = new Bitmap(newWidth, newHeight);

            //

            return resizedImage;
        }

        private Bitmap bilinear(Bitmap original, double scale)
        {
            int newWidth = (int)(original.Width * scale);
            int newHeight = (int)(original.Height * scale);
            Bitmap resizedImage = new Bitmap(newWidth, newHeight);

            //

            return resizedImage;
        }
    }
}
