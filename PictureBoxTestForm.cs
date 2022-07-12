using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxTest
{
    public partial class PictureBoxTestForm : Form
    {
        private int ImageNumber { get; set; } = -1; // The image to display
        public PictureBoxTestForm()
        {
            InitializeComponent();
        }

        private void nextImageButton_Click(object sender, EventArgs e)
        {
            ImageNumber = (ImageNumber + 1) % 3;  // Cycles from 0 to 2

            // Retrieve image from resources
            imagePictureBox.Image = (Image)(Properties.Resources.ResourceManager.GetObject(
                $"image{ImageNumber}"));
        }
    }
}
