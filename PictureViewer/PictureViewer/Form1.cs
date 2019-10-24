using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {

        }

        private void setBackgroundColor_Click(object sender, EventArgs e)
        {

        }

        private void clearPictureButton_Click(object sender, EventArgs e)
        {

        }

        private void showPicturebutton_Click(object sender, EventArgs e) // when show picture button is selected, it will open up a file dialog box
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) // if user clicks the ok button it will load the image into the picgture box 
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
