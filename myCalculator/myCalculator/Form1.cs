using System;
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
        Double resultValue = 0;
        string operatorClicked = "";
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

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operatorClicked = button.Text;
            resultValue = Double.Parse(resultbox.Text); // since result value is declared a double data type, it will pass the msessage from the text box and convert it into a relevant value
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
           resultbox.Text = "0";
           resultValue = 0;   
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            switch (operatorClicked)// switch will look for an expression(operator_clicked)and evaluate the expression once. the value of the expression will than be compared to each of the case like addition, subtraction etc. If ther is a match, the associated block of code will be executed once the match is found, it hits the breaks
            {
                case "+":
                    resultbox.Text = (resultValue + Double.Parse(resultbox.Text)).ToString();
                    break;
                case "-":
                    resultbox.Text = (resultValue - Double.Parse(resultbox.Text)).ToString();
                    break;
                case "*":
                    resultbox.Text = (resultValue * Double.Parse(resultbox.Text)).ToString();
                    break;
                case "/":
                    resultbox.Text = (resultValue / Double.Parse(resultbox.Text)).ToString();
                    break;
                default:
                    break; 
            }
        }
    }
}
