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

                    icons.RemoveAt(randomNumber); // take the icon and remove it from list so its not used again. 
                }
            }
        }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
