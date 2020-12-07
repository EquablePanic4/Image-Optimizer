using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        #endregion

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
    }
}
