﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myCalculator
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void click_button(object sender, EventArgs e)
        {

            if (resultbox.Text == "0") // if the text from the resultbox  is equal to zero 
                resultbox.Clear(); // the 0 will clear before you click a button. 

            Button button = (Button)sender;
            resultbox.Text = resultbox.Text + button.Text; // it will display the text on any button that is clicked
        }
    }
}
