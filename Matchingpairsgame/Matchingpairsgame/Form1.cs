/* Na Ly 
 * Reno Technology Academy
 * CIS109: Coding in c# for Imbedded Systems
 * Udemy: 17 Beignner c# Walkthrough Projects Step by Step
 * Project 1: Create a Matching Pairs Game Icon Image Game
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matchingpairsgame
{
    public partial class FormMatchingPairsGame : Form
    {
        Random random = new Random();
        List<string> icons = new List<string>() // list of 
        {
            "!" , "!" , "N" , "N" , "," , "," , "k" , "k" ,
            "b" , "b" , "v" , "v" , "w" , "w" , "z" , "z"
        };

        public FormMatchingPairsGame()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }
        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls) //control label is converted into icon label
            {
                Label iconLabel = control as Label; 
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];

                    iconLabel.ForeColor = iconLabel.BackColor; //changes the colore of the icon to same as the background color

                    icons.RemoveAt(randomNumber); // take the icon and remove it from list so its not used again. 
                }
            }
        }
    
        Label firstClicked, secondClicked;

        private void label_click(object sender, EventArgs e)
        {
            if (firstClicked != null && secondClicked != null)
                return; 

            Label clickedLabel = sender as Label;

            if (clickedLabel == null)
                return;
            if (clickedLabel.ForeColor == Color.Black)
                return; 
            if (firstClicked == null)
            {
                firstClicked = clickedLabel;
                firstClicked.ForeColor = Color.Black;
                return; 
            }
            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            CheckForWinner();


            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null; 
            }
            else 
                timer1.Start();
        }

        private void CheckForWinner()
        {
            Label label;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;

                if (label != null && label.ForeColor == label.BackColor)
                    return;

            }

            MessageBox.Show("You matched all the icons! Congrats!");
            Close();

        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null; 
        }
    }
}
