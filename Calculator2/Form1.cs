using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Calcutor2 : Form
    {

        public Calcutor2()
        {
            InitializeComponent();
        }

        //
        //All of the variables
        //

        public double number1, number2, Sum, Multiply, Minus, Divide;
        bool OPMultiply, OPSum, OPMinus, OPDivide;

        //
        //Functions of buttons from 1 to 9 and 0
        //

        private void button1_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + "1";
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + "8";
        }

       

        private void button9_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + "0";
        }

      

        //
        //Function of the C Button(Deleting Button)
        //

        private void buttonC_Click(object sender, EventArgs e)
        {
            textResult.Text = "";
        }

        //
        //Functions of sum, minus, multiply and divide button
        //

        private void buttonSum_Click(object sender, EventArgs e)
        {
            if (textResult.Text != "")
            {
                number1 = double.Parse(textResult.Text);

                OPSum = true;

                textResult.Text = "";
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (textResult.Text != "")
            {
                number1 = double.Parse(textResult.Text);

                OPMinus = true;

                textResult.Text = "";
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (textResult.Text != "")
            {
                number1 = double.Parse(textResult.Text);

                OPMultiply = true;

                textResult.Text = "";
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (textResult.Text != "")
            {
                number1 = double.Parse(textResult.Text);

                OPDivide = true;

                textResult.Text = "";
            }
        }

        //
        //Function of the Result Button
        //

        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (textResult.Text != "")
            {
                number2 = double.Parse(textResult.Text);

                if (OPSum == true)
                {
                    Sum = number1 + number2;

                    textResult.Text = Sum.ToString();

                    OPSum = false;
                }

                else if (OPMinus == true)
                {
                    Minus = number1 - number2;

                    textResult.Text = Minus.ToString();

                    OPMinus = false;
                }

                else if (OPMultiply == true)
                {
                    Multiply = number1 * number2;

                    textResult.Text = Multiply.ToString();

                    OPMultiply = false;
                }

                else if (OPDivide == true)
                {
                    Divide = number1 / number2;

                    textResult.Text = Divide.ToString();

                    OPDivide = false;
                }

                
            }
            
        }

        //
        //Function of mouseEnter and mouseLeave actions
        //

        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;

            currentButton.BackColor = Color.DarkBlue;

            currentButton.ForeColor = Color.White;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;

            currentButton.BackColor = Color.Aquamarine;

            currentButton.ForeColor = Color.Black;
        }
    }
} 
