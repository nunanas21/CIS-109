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

        }
    }
}
