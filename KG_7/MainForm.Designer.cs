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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_image
            // 
            this.pictureBox_image.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_image.Name = "pictureBox_image";
            this.pictureBox_image.Size = new System.Drawing.Size(871, 737);
            this.pictureBox_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_image.TabIndex = 18;
            this.pictureBox_image.TabStop = false;
            // 
            // button_Reset
            // 
            this.button_Reset.BackColor = System.Drawing.Color.DarkOrange;
            this.button_Reset.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Reset.ForeColor = System.Drawing.Color.Navy;
            this.button_Reset.Location = new System.Drawing.Point(1029, 703);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(143, 46);
            this.button_Reset.TabIndex = 17;
            this.button_Reset.Text = "Сброс";
            this.button_Reset.UseVisualStyleBackColor = false;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // uploadFile_button
            // 
            this.uploadFile_button.BackColor = System.Drawing.Color.DarkOrange;
            this.uploadFile_button.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uploadFile_button.ForeColor = System.Drawing.Color.Navy;
            this.uploadFile_button.Location = new System.Drawing.Point(1029, 12);
            this.uploadFile_button.Name = "uploadFile_button";
            this.uploadFile_button.Size = new System.Drawing.Size(143, 65);
            this.uploadFile_button.TabIndex = 16;
            this.uploadFile_button.Text = "Загрузить файл";
            this.uploadFile_button.UseVisualStyleBackColor = false;
            this.uploadFile_button.Click += new System.EventHandler(this.uploadFile_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pictureBox_image);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.uploadFile_button);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_image;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button uploadFile_button;
    }
}