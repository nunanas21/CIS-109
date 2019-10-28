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
    }
}
