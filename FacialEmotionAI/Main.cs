using System.Security.Cryptography;

namespace FacialEmotionAI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private async void buttonStartDetect_Click(object sender, EventArgs e)
        {
            // Select Image File
            OpenFileDialog ofd = new OpenFileDialog();
            var result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBoxImage.Image=Image.FromFile(ofd.FileName); // Set Image to Picture Box

                // Start Detecting
                label1.Text = "Start Detecting..";
                await Task.Delay(2000);
                var res = await Task.Run(() => StartDetect(ofd.FileName));
                label1.Text = res;

            }
        }

        private string StartDetect(string fileName)
        {
            //Load sample data
            var imageBytes = File.ReadAllBytes(fileName);
            MLModel1.ModelInput sampleData = new MLModel1.ModelInput()
            {
                ImageSource = imageBytes,
            };

            //Load model and predict output
            var res = MLModel1.Predict(sampleData);
            return res.PredictedLabel.ToString();
        }
    }

}