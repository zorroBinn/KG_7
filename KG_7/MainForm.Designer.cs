namespace KG_7
{
    partial class MainForm
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
            this.pictureBox_image = new System.Windows.Forms.PictureBox();
            this.button_Reset = new System.Windows.Forms.Button();
            this.uploadFile_button = new System.Windows.Forms.Button();
            this.label_original_size = new System.Windows.Forms.Label();
            this.label_current_size = new System.Windows.Forms.Label();
            this.label_orig_size = new System.Windows.Forms.Label();
            this.label_cur_size = new System.Windows.Forms.Label();
            this.trackBar_k = new System.Windows.Forms.TrackBar();
            this.label_k = new System.Windows.Forms.Label();
            this.button_nearest_neighbor = new System.Windows.Forms.Button();
            this.button_bilinear_smoothing = new System.Windows.Forms.Button();
            this.button_filter = new System.Windows.Forms.Button();
            this.trackBar_n = new System.Windows.Forms.TrackBar();
            this.trackBar_sigma = new System.Windows.Forms.TrackBar();
            this.label_sigma = new System.Windows.Forms.Label();
            this.label_n = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_k)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_n)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_sigma)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_image
            // 
            this.pictureBox_image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_image.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_image.Name = "pictureBox_image";
            this.pictureBox_image.Size = new System.Drawing.Size(871, 737);
            this.pictureBox_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_image.TabIndex = 18;
            this.pictureBox_image.TabStop = false;
            // 
            // button_Reset
            // 
            this.button_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Reset.BackColor = System.Drawing.Color.DarkOrange;
            this.button_Reset.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Reset.ForeColor = System.Drawing.Color.Navy;
            this.button_Reset.Location = new System.Drawing.Point(1043, 12);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(129, 65);
            this.button_Reset.TabIndex = 17;
            this.button_Reset.Text = "Сброс";
            this.button_Reset.UseVisualStyleBackColor = false;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // uploadFile_button
            // 
            this.uploadFile_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uploadFile_button.BackColor = System.Drawing.Color.DarkOrange;
            this.uploadFile_button.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uploadFile_button.ForeColor = System.Drawing.Color.Navy;
            this.uploadFile_button.Location = new System.Drawing.Point(894, 12);
            this.uploadFile_button.Name = "uploadFile_button";
            this.uploadFile_button.Size = new System.Drawing.Size(143, 65);
            this.uploadFile_button.TabIndex = 16;
            this.uploadFile_button.Text = "Загрузить файл";
            this.uploadFile_button.UseVisualStyleBackColor = false;
            this.uploadFile_button.Click += new System.EventHandler(this.uploadFile_button_Click);
            // 
            // label_original_size
            // 
            this.label_original_size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_original_size.AutoSize = true;
            this.label_original_size.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_original_size.ForeColor = System.Drawing.Color.Navy;
            this.label_original_size.Location = new System.Drawing.Point(986, 80);
            this.label_original_size.Name = "label_original_size";
            this.label_original_size.Size = new System.Drawing.Size(186, 27);
            this.label_original_size.TabIndex = 19;
            this.label_original_size.Text = "Исходный размер:";
            // 
            // label_current_size
            // 
            this.label_current_size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_current_size.AutoSize = true;
            this.label_current_size.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_current_size.ForeColor = System.Drawing.Color.Navy;
            this.label_current_size.Location = new System.Drawing.Point(997, 134);
            this.label_current_size.Name = "label_current_size";
            this.label_current_size.Size = new System.Drawing.Size(175, 27);
            this.label_current_size.TabIndex = 20;
            this.label_current_size.Text = "Текущий размер:";
            // 
            // label_orig_size
            // 
            this.label_orig_size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_orig_size.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_orig_size.ForeColor = System.Drawing.Color.Navy;
            this.label_orig_size.Location = new System.Drawing.Point(986, 107);
            this.label_orig_size.Name = "label_orig_size";
            this.label_orig_size.Size = new System.Drawing.Size(186, 27);
            this.label_orig_size.TabIndex = 21;
            this.label_orig_size.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_cur_size
            // 
            this.label_cur_size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_cur_size.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_cur_size.ForeColor = System.Drawing.Color.Navy;
            this.label_cur_size.Location = new System.Drawing.Point(986, 161);
            this.label_cur_size.Name = "label_cur_size";
            this.label_cur_size.Size = new System.Drawing.Size(186, 27);
            this.label_cur_size.TabIndex = 22;
            this.label_cur_size.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trackBar_k
            // 
            this.trackBar_k.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.trackBar_k.Location = new System.Drawing.Point(889, 216);
            this.trackBar_k.Maximum = 100;
            this.trackBar_k.Minimum = 1;
            this.trackBar_k.Name = "trackBar_k";
            this.trackBar_k.Size = new System.Drawing.Size(283, 45);
            this.trackBar_k.TabIndex = 23;
            this.trackBar_k.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar_k.Value = 10;
            this.trackBar_k.ValueChanged += new System.EventHandler(this.trackBar_k_ValueChanged);
            // 
            // label_k
            // 
            this.label_k.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_k.AutoSize = true;
            this.label_k.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_k.ForeColor = System.Drawing.Color.Navy;
            this.label_k.Location = new System.Drawing.Point(889, 186);
            this.label_k.Name = "label_k";
            this.label_k.Size = new System.Drawing.Size(24, 27);
            this.label_k.TabIndex = 24;
            this.label_k.Text = "1";
            // 
            // button_nearest_neighbor
            // 
            this.button_nearest_neighbor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_nearest_neighbor.BackColor = System.Drawing.Color.DarkOrange;
            this.button_nearest_neighbor.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_nearest_neighbor.ForeColor = System.Drawing.Color.Navy;
            this.button_nearest_neighbor.Location = new System.Drawing.Point(1029, 267);
            this.button_nearest_neighbor.Name = "button_nearest_neighbor";
            this.button_nearest_neighbor.Size = new System.Drawing.Size(143, 65);
            this.button_nearest_neighbor.TabIndex = 25;
            this.button_nearest_neighbor.Text = "Ближайшего соседа";
            this.button_nearest_neighbor.UseVisualStyleBackColor = false;
            this.button_nearest_neighbor.Click += new System.EventHandler(this.button_nearest_neighbor_Click);
            // 
            // button_bilinear_smoothing
            // 
            this.button_bilinear_smoothing.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_bilinear_smoothing.BackColor = System.Drawing.Color.DarkOrange;
            this.button_bilinear_smoothing.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_bilinear_smoothing.ForeColor = System.Drawing.Color.Navy;
            this.button_bilinear_smoothing.Location = new System.Drawing.Point(1029, 338);
            this.button_bilinear_smoothing.Name = "button_bilinear_smoothing";
            this.button_bilinear_smoothing.Size = new System.Drawing.Size(143, 65);
            this.button_bilinear_smoothing.TabIndex = 26;
            this.button_bilinear_smoothing.Text = "Билинейное сглаживание";
            this.button_bilinear_smoothing.UseVisualStyleBackColor = false;
            this.button_bilinear_smoothing.Click += new System.EventHandler(this.button_bilinear_smoothing_Click);
            // 
            // button_filter
            // 
            this.button_filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_filter.BackColor = System.Drawing.Color.DarkOrange;
            this.button_filter.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_filter.ForeColor = System.Drawing.Color.Navy;
            this.button_filter.Location = new System.Drawing.Point(1029, 683);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(143, 66);
            this.button_filter.TabIndex = 27;
            this.button_filter.Text = "Фильтр Гаусса";
            this.button_filter.UseVisualStyleBackColor = false;
            this.button_filter.Click += new System.EventHandler(this.button_filter_Click);
            // 
            // trackBar_n
            // 
            this.trackBar_n.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_n.LargeChange = 1;
            this.trackBar_n.Location = new System.Drawing.Point(889, 524);
            this.trackBar_n.Maximum = 3;
            this.trackBar_n.Minimum = 1;
            this.trackBar_n.Name = "trackBar_n";
            this.trackBar_n.Size = new System.Drawing.Size(283, 45);
            this.trackBar_n.TabIndex = 28;
            this.trackBar_n.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar_n.Value = 1;
            this.trackBar_n.ValueChanged += new System.EventHandler(this.trackBar_n_ValueChanged);
            // 
            // trackBar_sigma
            // 
            this.trackBar_sigma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_sigma.LargeChange = 1;
            this.trackBar_sigma.Location = new System.Drawing.Point(889, 632);
            this.trackBar_sigma.Maximum = 20;
            this.trackBar_sigma.Minimum = 1;
            this.trackBar_sigma.Name = "trackBar_sigma";
            this.trackBar_sigma.Size = new System.Drawing.Size(283, 45);
            this.trackBar_sigma.TabIndex = 29;
            this.trackBar_sigma.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar_sigma.Value = 10;
            this.trackBar_sigma.ValueChanged += new System.EventHandler(this.trackBar_sigma_ValueChanged);
            // 
            // label_sigma
            // 
            this.label_sigma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_sigma.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_sigma.ForeColor = System.Drawing.Color.Navy;
            this.label_sigma.Location = new System.Drawing.Point(1117, 602);
            this.label_sigma.Name = "label_sigma";
            this.label_sigma.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_sigma.Size = new System.Drawing.Size(55, 27);
            this.label_sigma.TabIndex = 30;
            this.label_sigma.Text = "1";
            // 
            // label_n
            // 
            this.label_n.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_n.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_n.ForeColor = System.Drawing.Color.Navy;
            this.label_n.Location = new System.Drawing.Point(1128, 494);
            this.label_n.Name = "label_n";
            this.label_n.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_n.Size = new System.Drawing.Size(44, 27);
            this.label_n.TabIndex = 31;
            this.label_n.Text = "3";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(1092, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 27);
            this.label3.TabIndex = 32;
            this.label3.Text = "n:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(1049, 602);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 27);
            this.label1.TabIndex = 33;
            this.label1.Text = "sigma";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_n);
            this.Controls.Add(this.label_sigma);
            this.Controls.Add(this.trackBar_sigma);
            this.Controls.Add(this.trackBar_n);
            this.Controls.Add(this.button_filter);
            this.Controls.Add(this.button_bilinear_smoothing);
            this.Controls.Add(this.button_nearest_neighbor);
            this.Controls.Add(this.label_k);
            this.Controls.Add(this.trackBar_k);
            this.Controls.Add(this.label_cur_size);
            this.Controls.Add(this.label_orig_size);
            this.Controls.Add(this.label_current_size);
            this.Controls.Add(this.label_original_size);
            this.Controls.Add(this.pictureBox_image);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.uploadFile_button);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_k)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_n)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_sigma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_image;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button uploadFile_button;
        private System.Windows.Forms.Label label_original_size;
        private System.Windows.Forms.Label label_current_size;
        private System.Windows.Forms.Label label_orig_size;
        private System.Windows.Forms.Label label_cur_size;
        private System.Windows.Forms.TrackBar trackBar_k;
        private System.Windows.Forms.Label label_k;
        private System.Windows.Forms.Button button_nearest_neighbor;
        private System.Windows.Forms.Button button_bilinear_smoothing;
        private System.Windows.Forms.Button button_filter;
        private System.Windows.Forms.TrackBar trackBar_n;
        private System.Windows.Forms.TrackBar trackBar_sigma;
        private System.Windows.Forms.Label label_sigma;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}