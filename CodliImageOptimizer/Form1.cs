using SixLabors.ImageSharp.PixelFormats;
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
        private Point lastLocation;

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
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

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
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //We're setting image
                    SingleImagePreview.ImageLocation = filePath;
                    SingleFilePathbox.Text = filePath;

                    //And other options...
                    var ext = Path.GetExtension(filePath).ToLower();
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
                    using (var img = await SixLabors.ImageSharp.Image.LoadAsync<Rgb24>(filePath))
                    {
                        SingleFileHightBox.Text = $"{img.Height} px";
                        SingleFileWidthBox.Text = $"{img.Width} px";
                    }
                }
            }
        }

        #endregion

        #region Multi files operations



        #endregion
    }
}
