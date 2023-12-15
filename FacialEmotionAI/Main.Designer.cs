namespace FacialEmotionAI
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxImage = new PictureBox();
            buttonStartDetect = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Image = Properties.Resources.RadFtNa6n66wdg;
            pictureBoxImage.Location = new Point(45, 12);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(412, 366);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImage.TabIndex = 0;
            pictureBoxImage.TabStop = false;
            // 
            // buttonStartDetect
            // 
            buttonStartDetect.BackColor = Color.FromArgb(64, 64, 64);
            buttonStartDetect.FlatAppearance.BorderSize = 0;
            buttonStartDetect.FlatStyle = FlatStyle.Flat;
            buttonStartDetect.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStartDetect.ForeColor = Color.White;
            buttonStartDetect.Location = new Point(45, 418);
            buttonStartDetect.Name = "buttonStartDetect";
            buttonStartDetect.Size = new Size(402, 72);
            buttonStartDetect.TabIndex = 1;
            buttonStartDetect.Text = "Upload Image";
            buttonStartDetect.UseVisualStyleBackColor = false;
            buttonStartDetect.Click += buttonStartDetect_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(58, 514);
            label1.Name = "label1";
            label1.Size = new Size(389, 94);
            label1.TabIndex = 2;
            label1.Text = "...";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(491, 632);
            Controls.Add(label1);
            Controls.Add(buttonStartDetect);
            Controls.Add(pictureBoxImage);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Facil Emotion App";
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxImage;
        private Button buttonStartDetect;
        private Label label1;
    }
}