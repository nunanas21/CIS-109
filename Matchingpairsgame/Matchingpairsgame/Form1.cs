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
        List<string> icons = new List<string>()
        {
            "!" , "!" , "N" , "N" , "," , "," , "k" , "k" ,
            "b" , "b" , "v" , "v" , "w" , "w" , "z" , "z"
        };

        public FormMatchingPairsGame()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
