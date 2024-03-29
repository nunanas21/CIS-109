﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleClock
{
    public partial class Clock : Form
    {
        Timer t = new Timer();
        public Clock()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            t.Interval = 1000;

            t.Tick += new EventHandler(this.t_Tick);

            t.Start(); //once forms loads, it will start the timer
        }
        private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour; // this wil retrieve whatever current time is on the computer
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }
            label1.Text = time; 

        }
    }
}