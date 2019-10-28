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

        Bitmap bmp = new Bitmap(1024, 768);// we can only draw on a canvcas this size
        Pen p = new Pen(Color.Black, 5);
        bool drawing = false; 
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (drawing) // if variable drawing is accessed, the drawing default is false
                drawing = false;
            else
                drawing = true;
        }
    }
}
