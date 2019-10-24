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

        private void closeButton_Click(object sender, EventArgs e)// closes the  picture viewer when close is clicked. 
        {
            this.Close();
        }

        private void setBackgroundColor_Click(object sender, EventArgs e) // Show the color dialog box, if user clicks ok, change the background to chosen color
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void clearPictureButton_Click(object sender, EventArgs e)// if clear picture button is clicked, it clears/ null 
        {
            pictureBox1.Image = null;
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
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // if check box is checked, you can stretch the size of the image
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal; // if not checked, it will go back to its normal size
        }
    }
}
