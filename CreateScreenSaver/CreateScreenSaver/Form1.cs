using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateScreenSaver
{
    public partial class frmScSaver : Form
    {
        List<Image> BFImages = new List<Image>(); // store an array of pictures
        List<BritPic> BritPics = new List<BritPic>(); // store array of Britpictures
        Random rand = new Random(); //used to generate random numbers

        class BritPic // going to hold a different postion 
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
            Close(); // When you run the application, if you press any key, the application will return to normal screen size.
        }

        private void frmScSaver_Load(object sender, EventArgs e)
        {
            string[] images = System.IO.Directory.GetFiles("pics"); //this goes through and creates a lsit 

            


            
            
        }

    }
}
