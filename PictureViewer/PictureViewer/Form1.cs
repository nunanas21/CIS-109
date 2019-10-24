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

        private void button4_Click(object sender, EventArgs e) // When show button is clicked it will open up a f
        {
            if (openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void setBckgrndcolorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void clearPicturebutton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null; 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // if check box is checked, you can stretch the size of the image
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal; // if not checked, it will go back to its normal size
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
