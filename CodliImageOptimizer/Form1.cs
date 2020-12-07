using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodliImageOptimizer
{
    public partial class ImageOptimizer : Form
    {
        #region Construct and fields

        private bool mouseDown = false;
        private System.Drawing.Point lastLocation;
        private SixLabors.ImageSharp.Image<Rgb24> currentImage;
        private string currentImagePath;

        public ImageOptimizer()
        {
            InitializeComponent();
        }

        #endregion

        #region Managing the window

        private void MinimizeBtn_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void CloseBtn_Click(object sender, EventArgs e) => Application.Exit();

        private void ImageOptimizer_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new System.Drawing.Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void ImageOptimizer_MouseDown(object sender, MouseEventArgs e)
        {
            lastLocation = e.Location;
            mouseDown = true;
        }

        private void ImageOptimizer_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        #endregion

        #region Single file operations

        private async void ChooseFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    currentImagePath = openFileDialog.FileName;

                    //We're setting image
                    SingleImagePreview.ImageLocation = currentImagePath;
                    SingleFilePathbox.Text = currentImagePath;

                    //And other options...
                    var ext = Path.GetExtension(currentImagePath).ToLower();
                    switch (ext)
                    {
                        case ".jpg" or ".jpeg":
                            singleOutputFormatJpeg.Checked = true;
                            break;

                        default:
                            singleOutputFormatPng.Checked = true;
                            break;
                    }

                    //We're looking for image properties
                    currentImage = await SixLabors.ImageSharp.Image.LoadAsync<Rgb24>(currentImagePath);
                    SingleFileHightBox.Text = $"{currentImage.Height}";
                    SingleFileWidthBox.Text = $"{currentImage.Width}";

                    //Now we cen enable size slider
                    SingleFileSizeSlider.Enabled = true;
                }
            }
        }

        #endregion

        #region Multi files operations



        #endregion

        private void SingleFileQualitySlider_Scroll(object sender, EventArgs e)
        {
            SingleFileQualityBox.Text = SingleFileQualitySlider.Value.ToString();
        }

        private void SingleFileQualityBox_TextChanged(object sender, EventArgs e)
        {
            var currentVal = 0;
            var parsing = Int32.TryParse(SingleFileQualityBox.Text, out currentVal);
            if (parsing)
            {
                if (currentVal == SingleFileQualitySlider.Value)
                    return;

                if (currentVal > 100)
                {
                    SingleFileQualityBox.Text = "100";
                    SingleFileQualitySlider.Value = 100;
                }

                if (currentVal < 1)
                {
                    SingleFileQualityBox.Text = "1";
                    SingleFileQualitySlider.Value = 1;
                }

                SingleFileQualitySlider.Value = currentVal;
            }

            else
                SingleFileQualityBox.Text = SingleFileQualitySlider.Value.ToString();
        }

        private void SingleFileSizeSlider_Scroll(object sender, EventArgs e)
        {
            var height = currentImage.Height;
            var width = currentImage.Width;

            var procentage = ((double)SingleFileSizeSlider.Value * 0.01);

            CalculateImageSize(procentage, ref width, ref height);

            SingleFileHightBox.Text = $"{height}";
            SingleFileWidthBox.Text = $"{width}";
        }

        #region Shared methods

        private void CalculateImageSize(double ratio, ref int width, ref int height)
        {
            width = Convert.ToInt32(ratio * width);
            height = Convert.ToInt32(ratio * height);
        }

        private async Task<bool> OptimizeImage(SixLabors.ImageSharp.Image<Rgb24> image, double ratio, int quality, bool overwrite)
        {
            try
            {
                if (ratio < 1.00)
                    image.Mutate(e => e.Resize(Convert.ToInt32(ratio * image.Width), Convert.ToInt32(ratio * image.Height)));

                var savePath = overwrite
                    ? Path.Combine(Path.GetDirectoryName(currentImagePath), Path.GetFileNameWithoutExtension(currentImagePath))
                    : Path.Combine(Path.GetDirectoryName(currentImagePath), $"optimized_{Path.GetFileNameWithoutExtension(currentImagePath)}");

                switch (singleOutputFormatJpeg.Checked)
                {
                    case true when singleOutputFormatJpg.Checked || !singleOutputFormatJpg.Checked:
                        var enc = new JpegEncoder
                        {
                            Quality = quality
                        };

                        var ext = singleOutputFormatJpg.Checked ? "jpg" : "jpeg";

                        CodliProgress.Value = 40;

                        await image.SaveAsync($"{savePath}.{ext}", enc);
                        break;
                }


                CodliProgress.Value = 100;
                return true;
            }

            catch
            {
                return false;
            }
        }

        #endregion

        private async void SingleFileOptimizeBtn_Click(object sender, EventArgs e)
        {
            await OptimizeImage(currentImage, ((double)SingleFileSizeSlider.Value * 0.01), SingleFileQualitySlider.Value, OverwriteSingleBox.Checked);
        }
    }
}
