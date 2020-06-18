using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssignmentV3;

namespace CalculatorV2
{
    public partial class Form_Calculator : Form
    {
        string input = string.Empty;//this sets a new string. which is empty
        string num1 = string.Empty;//this sests num1 as a empty string
        string num2 = string.Empty;//this sets num2 as an empty string
        char num;//this sets num as a char
        double result = 0.0;//this creates a new double called result which = 0.0
        public Form_Calculator()
        {
            InitializeComponent();
        }

        private void btn_Num0_Click(object sender, EventArgs e)
        {
            this.txtbox_Calc.Text = "";//this sets the textbox to to show nothing
            input += "0";//this says that input will either add 0 to the string. or the string will = 0
            this.txtbox_Calc.Text += input; //says furthur says that calcbox.text will either +0 to the string or the string will = 0
            //This pattern continues for the other btn_Num_Click. no expection.
        }

        private void btn_Num1_Click(object sender, EventArgs e)
        {
            this.txtbox_Calc.Text = "";
            input += "1";
            this.txtbox_Calc.Text += input;
        }

        private void btn_Num2_Click(object sender, EventArgs e)
        {
            this.txtbox_Calc.Text = "";
            input += "2";
            this.txtbox_Calc.Text += input;
        }

        private void btn_Num3_Click(object sender, EventArgs e)
        {
            this.txtbox_Calc.Text = "";
            input += "3";
            this.txtbox_Calc.Text += input;
        }

        private void btn_Num4_Click(object sender, EventArgs e)
        {
            this.txtbox_Calc.Text = "";
            input += "4";
            this.txtbox_Calc.Text += input;
        }

        private void btn_Num5_Click(object sender, EventArgs e)
        {
            this.txtbox_Calc.Text = "";
            input += "5";
            this.txtbox_Calc.Text += input;
        }

        private void btn_Num6_Click(object sender, EventArgs e)
        {
            this.txtbox_Calc.Text = "";
            input += "6";
            this.txtbox_Calc.Text += input;
        }

        private void btn_Num7_Click(object sender, EventArgs e)
        {
            this.txtbox_Calc.Text = "";
            input += "7";
            this.txtbox_Calc.Text += input;
        }

        private void btn_Num8_Click(object sender, EventArgs e)
        {
            this.txtbox_Calc.Text = "";
            input += "8";
            this.txtbox_Calc.Text += input;
        }

        private void btn_Num9_Click(object sender, EventArgs e)
        {
            this.txtbox_Calc.Text = "";
            input += "9";
            this.txtbox_Calc.Text += input;
        }

        private void btn_Point_Click(object sender, EventArgs e)
        {
            this.txtbox_Calc.Text = "";
            input += ".";
            this.txtbox_Calc.Text += input;
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            num1 = input; // this sets num1 to equal the input from the buttons
            num = '+'; //this sets the num value to = '+'
            input = string.Empty;//this empties the string for more numbers 
            //this set up is then used for the -,/ and * buttons
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            num1 = input;
            num = '-';
            input = string.Empty;
        }

        private void btn_Divide_Click(object sender, EventArgs e)
        {
            num1 = input;
            num = '/';
            input = string.Empty;
        }

        private void btn_Times_Click(object sender, EventArgs e)
        {
            num1 = input;
            num = '*';
            input = string.Empty;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            this.txtbox_Calc.Text = "";//this says that calcboc.text will show nothing
            this.input = string.Empty;//this empties the input variable
            this.num1 = string.Empty;//this empties num1 vairable
            this.num2 = string.Empty;//this empties num2 vairable
        }

        private void btn_Equals_Click(object sender, EventArgs e)
        {
            num2 = input;//this says that num2 will equal the input given
            double finalnum1, finalnum2;//this sets finalnum1 and finalnum2 as doubles
            double.TryParse(num1, out finalnum1);//this says that num1 will pass its value on to finalnum1
            double.TryParse(num2, out finalnum2);//this says that num2 will pass its value on to finalnum2
            if(num == '+')//this if statement says that if num = + then it was add the numbers and display the result
            {
                result = finalnum1 + finalnum2;
                txtbox_Calc.Text = result.ToString();   
            }
            if (num == '-')//this if statement says that if num = - then it was subtract the numbers and display the result
            {
                result = finalnum1 - finalnum2;
                txtbox_Calc.Text = result.ToString();
            }
            if (num == '/')//this if statement says that if num = / then it was divide the numbers and display the result
            {
                result = finalnum1 / finalnum2;
                txtbox_Calc.Text = result.ToString();
            }
            if (num == '*')//this if statement says that if num = * then it was multiply the numbers and display the result
            {
                result = finalnum1 * finalnum2;
                txtbox_Calc.Text = result.ToString();
            }
        }

        private void btn_Main_Click(object sender, EventArgs e)
        {
            this.Close();//this closes the form
            Form_MainMenu main = new Form_MainMenu();//sets main to = new menu
            main.Show();//this shows the main
        }
    }
}
