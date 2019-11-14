using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace digitalClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start(); //calling the timer from the form. Once the form loads, it will trigger or call the method to start
        }
  

        private void timer1_Tick(object sender, EventArgs e)
        {
            hourMinuteLabel.Text = DateTime.Now.ToString("HH:mm"); //dot. means its a method and it takes in text. Text is set to take in the datetime.now method. This method witll take the current date time from the computer and dipslay it by converting it into a string in the specified format. 
            secondsLabel.Text = DateTime.Now.ToString("ss");
            dateLabel.Text = DateTime.Now.ToString("MMM:dd:yyyy");
            weekdayLabel.Text = DateTime.Now.ToString("dddd");

        }

    }
}
