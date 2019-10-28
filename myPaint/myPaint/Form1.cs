using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myPaint
{
    public partial class Form1 : Form
    {
        Bitmap bmp = new Bitmap(1024, 768);// setting the resolution-we can only draw on a canvcas this size
        Pen p = new Pen(Color.Black, 5); // can be accessed anywhere on the application. represents the pen color 
        bool drawing = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)//Changed from mouse down to mouse click so it can be used by the mouse up as well 
        {
            if (drawing) // if variable drawing is accessed, the drawing default is false
                drawing = false;
            else
                drawing = true;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)// this method will run when the mouse enters the picture box
        {
            if (drawing)
            {
                Graphics g = Graphics.FromImage(bmp);
                g.DrawEllipse(p, e.X, e.Y, 3, 1);
                pictureBox2.Image = bmp;


            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            p.Color = Color.Magenta; 
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            p.Color = Color.Green;

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            p.Color = Color.Blue;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            p.Color = Color.Purple;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            p.Color = Color.Yellow;
        }
    }
}
