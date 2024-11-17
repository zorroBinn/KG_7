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
            trackBar_n.Value = 1;
            trackBar_sigma.Value = 10;
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
            if (originalImage == null) { return; }
            double k = trackBar_k.Value / 10.0;
            Bitmap resizedImage = nearestNeighbor((Bitmap)originalImage, k);
            pictureBox_image.Image = resizedImage;
            label_cur_size.Text = resizedImage.Width.ToString() + "x" + resizedImage.Size.Height.ToString();
        }


        private void button_bilinear_smoothing_Click(object sender, EventArgs e)
        {
            if (originalImage == null) { return; }
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

            for (int y = 0; y < newHeight; y++)
            {
                for (int x = 0; x < newWidth; x++)
                {
                    //Нахождение ближайшего пикселя в оригинале
                    int origX = Math.Min((int)(x / scale), original.Width - 1);
                    int origY = Math.Min((int)(y / scale), original.Height - 1);
                    Color pixelColor = original.GetPixel(origX, origY);
                    resizedImage.SetPixel(x, y, pixelColor);
                }
            }

            return resizedImage;
        }


        private Bitmap bilinear(Bitmap original, double scale)
        {
            int newWidth = (int)(original.Width * scale);
            int newHeight = (int)(original.Height * scale);
            Bitmap resizedImage = new Bitmap(newWidth, newHeight);

            for (int y = 0; y < newHeight; y++)
            {
                for (int x = 0; x < newWidth; x++)
                {
                    double gx = x / scale;
                    double gy = y / scale;
                    int gxi = (int)gx;
                    int gyi = (int)gy;

                    int gxi1 = Math.Min(gxi + 1, original.Width - 1);
                    int gyi1 = Math.Min(gyi + 1, original.Height - 1);

                    //Цвета соседних пикселей
                    Color c00 = original.GetPixel(gxi, gyi);
                    Color c10 = original.GetPixel(gxi1, gyi);
                    Color c01 = original.GetPixel(gxi, gyi1);
                    Color c11 = original.GetPixel(gxi1, gyi1);

                    //Дробная часть
                    double fx = gx - gxi;
                    double fy = gy - gyi;
                    Color interpolatedColor = BilinearInterpolate(c00, c10, c01, c11, fx, fy);
                    resizedImage.SetPixel(x, y, interpolatedColor);
                }
            }

            return resizedImage;
        }


        /// <summary>
        /// Выполняет билинейную интерполяцию цвета между четырьмя соседними пикселями
        /// </summary>
        /// <param name="c00">Цвет верхнего левого пикселя</param>
        /// <param name="c10">Цвет верхнего правого пикселя</param>
        /// <param name="c01">Цвет нижнего левого пикселя</param>
        /// <param name="c11">Цвет нижнего правого пикселя</param>
        /// <param name="fx">Дробная часть X координаты</param>
        /// <param name="fy">Дробная часть Y координаты</param>
        /// <returns>Результирующий интерполяционный цвет</returns>
        private Color BilinearInterpolate(Color c00, Color c10, Color c01, Color c11, double fx, double fy)
        {
            //Весовые коэффициенты для каждого пикселя зависят от расстояния до точки интерполяции
            double r = (1 - fx) * (1 - fy) * c00.R + fx * (1 - fy) * c10.R + (1 - fx) * fy * c01.R + fx * fy * c11.R;
            double g = (1 - fx) * (1 - fy) * c00.G + fx * (1 - fy) * c10.G + (1 - fx) * fy * c01.G + fx * fy * c11.G;
            double b = (1 - fx) * (1 - fy) * c00.B + fx * (1 - fy) * c10.B + (1 - fx) * fy * c01.B + fx * fy * c11.B;

            return Color.FromArgb((int)r, (int)g, (int)b);
        }

        //Чем больше n, тем более сглаженное изображение
        private void trackBar_n_ValueChanged(object sender, EventArgs e)
        {
            label_n.Text = (trackBar_n.Value * 2 + 1).ToString();
        }

        //Определяет степень размытия (чем больше - тем размытее)
        private void trackBar_sigma_ValueChanged(object sender, EventArgs e)
        {
            double sigma = trackBar_sigma.Value / 10.0;
            label_sigma.Text = sigma.ToString();
        }


        private void ApplyGaussianBlur(int filterSize, double sigma)
        {
            Bitmap source = new Bitmap(pictureBox_image.Image);
            Bitmap result = new Bitmap(source.Width, source.Height);

            double[,] filter = CreateGaussianKernel(filterSize, sigma);

            //Радиус фильтра
            int r = filterSize / 2;

            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    double red = 0.0, green = 0.0, blue = 0.0;

                    for (int fy = 0; fy < filterSize; fy++)
                    {
                        for (int fx = 0; fx < filterSize; fx++)
                        {
                            // Вычисляем координаты соседнего пикселя с учетом отзеркаливания
                            int imageX = x + fx - r;
                            int imageY = y + fy - r;

                            if (imageX < 0) imageX = -imageX;
                            if (imageX >= source.Width) imageX = 2 * source.Width - imageX - 1;
                            if (imageY < 0) imageY = -imageY;
                            if (imageY >= source.Height) imageY = 2 * source.Height - imageY - 1;

                            // Получаем цвет пикселя и добавляем взвешенные значения
                            Color pixelColor = source.GetPixel(imageX, imageY);

                            red += pixelColor.R * filter[fy, fx];
                            green += pixelColor.G * filter[fy, fx];
                            blue += pixelColor.B * filter[fy, fx];
                        }
                    }

                    int rValue = Math.Min(Math.Max((int)Math.Round(red), 0), 255);
                    int gValue = Math.Min(Math.Max((int)Math.Round(green), 0), 255);
                    int bValue = Math.Min(Math.Max((int)Math.Round(blue), 0), 255);

                    result.SetPixel(x, y, Color.FromArgb(rValue, gValue, bValue));
                }
            }
            pictureBox_image.Image = result;
        }


        private double[,] CreateGaussianKernel(int size, double sigma)
        {
            double[,] kernel = new double[size, size];
            int r = size / 2;
            double sigma2 = sigma * sigma;
            double normalizationFactor = 0.0;

            for (int y = -r; y <= r; y++)
            {
                for (int x = -r; x <= r; x++)
                {
                    double value = Math.Exp(-(x * x + y * y) / (2 * sigma2));
                    kernel[y + r, x + r] = value;
                    normalizationFactor += value;
                }
            }

            //Нормализация ядра, чтобы сумма элементов фильтра равнялась 1.
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    kernel[y, x] /= normalizationFactor;
                }
            }
            return kernel;
        }


        private void button_filter_Click(object sender, EventArgs e)
        {
            if (originalImage == null) { return; }
            ApplyGaussianBlur((trackBar_n.Value * 2 + 1), trackBar_sigma.Value / 10.0);
        }
    }
}
