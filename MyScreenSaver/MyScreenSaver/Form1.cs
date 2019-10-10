using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyScreenSaver
{
    public partial class frmScSaver : Form
    {
        List<Image> BGImages = new List<Image>(); //variable that holds an array of pictures
        List<BritPic> BritPics = new List<BritPic>(); //store an array of britpic objects
        Random rand = new Random(); //used to generate random numbers

        class BritPic
        { //going to hold a position for each picture on the screen saver
            public int PicNum;
            public float X;
            public float Y;
            public float Speed;
        }


        public frmScSaver()
        {
            InitializeComponent();
        }

        private void frmScSaver_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }

        private void frmScSaver_Load(object sender, EventArgs e)
        {
            string[] images = System.IO.Directory.GetFiles("pics");// put a list of file names in the pics directory into images variable
            
            foreach (string image in images) 
            {
                BGImages.Add(new Bitmap(image));// creates a new bitmap picture and add it to the bgimage array
            }

            for (int i = 0; i < 50; ++i) // as long as i is less than 50, it will keep on increasing by 1. It will look into the directory for images and it will check as long as the images is less than 50 it will keep adding images to the screen
            {
                BritPic mp = new BritPic(); //
                mp.PicNum = i % BGImages.Count;
                mp.X = rand.Next(0, Width);
                mp.Y = rand.Next(0, Height);

                

                BritPics.Add(mp); // will add and object to the end of list
           
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void frmScSaver_Paint(object sender, PaintEventArgs e)
        {
            foreach (BritPic bp in BritPics) 
            {
                e.Graphics.DrawImage(BGImages[bp.PicNum], bp.X, bp.Y);
                bp.X -= 2; //drawing of the images and postion them on the x and y axis
                
                if (bp.X < -250) // if the object moves off the left edge of the screen, move it back 
                {
                    bp.X = Width + rand.Next(20, 100);
                }
            }
                
        }
    }
}
