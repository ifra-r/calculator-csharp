using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myCal
{
    public partial class calculator : Form
    {
        bool firstClick = true;
        double  input1;
        double  input2;
        char operation;
        public double factorialOfNum (int n)
        {
            double res = 1;
            for (int i=n; i>0; i--)
            {
                res *= i;   
            }
            return res;
        }
        private string DecToAnyBase(int number,int numBase)
        {
            if (number == 0)
                return "0";
            string res = "0";
            while (number != 0)
            {
                int rem = (number % numBase);
                res += rem.ToString();
                number /= numBase;
            }
            string reversed = new string(res.Reverse().ToArray());
            reversed = reversed.Substring(0, reversed.Length - 1);
            return reversed;        }
        public calculator()
        {
            InitializeComponent();
        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }

        private void screen_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (firstClick)
            {
                screen.Text = "";
                firstClick = false;
            }
            screen.Text += "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void one_Click_1(object sender, EventArgs e)
        {
            if (firstClick)
            {
                screen.Text = "1";
                firstClick = false;
            }
            else
                screen.Text += "1";

        }

        private void two_Click(object sender, EventArgs e)
        {
            if (firstClick)
            {
                screen.Text = "2";
                firstClick = false;
            }
            else
                screen.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (firstClick)
            {
                screen.Text = "3";
                firstClick = false;
            }
            else
                screen.Text += "3";
        }

        private void divide_Click_1(object sender, EventArgs e)
        {
            operation = '/';
            input1 = double.Parse(screen.Text);
            screen.Text = input1.ToString(); firstClick = true;
            firstClick = true;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            input2 = double.Parse(screen.Text);
            switch (operation)
            {
                case '+':
                    screen.Text = (input1 + input2).ToString();
                    input1 = double.Parse(screen.Text);
                    break;
                case '-':
                    screen.Text = (input1 - input2).ToString();
                    break;
                case '*':
                    screen.Text = (input1 * input2).ToString();
                    break;
                case '/':
                    screen.Text = (input1 / input2).ToString();
                    break;
                case '%':
                    screen.Text = (input1 % input2).ToString(); 
                    break;
                
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (firstClick)
            {
                screen.Text = "9";
                firstClick = false;
            }
            else
                screen.Text += "9";
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            operation = '-';
            input1 = double.Parse(screen.Text);
            screen.Text = input1.ToString();
            firstClick = true;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            operation = '*';
            input1 = double.Parse(screen.Text);
            screen.Text = input1.ToString(); firstClick = true;
            firstClick = true;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (firstClick)
            {
                screen.Text = "7";
                firstClick = false;
            }
            else
                screen.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (firstClick)
            {
                screen.Text = "8";
                firstClick = false;
            }
            else
                screen.Text += "8";
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (firstClick)
            {
                screen.Text = "6";
                firstClick = false;
            }
            else
                screen.Text += "6";
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (firstClick)
            {
                screen.Text = "5";
                firstClick = false;
            }
            else
                screen.Text += "5";
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (firstClick)
            {
                screen.Text = "4";
                firstClick = false;
            }
            else
                screen.Text += "4";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            operation = '+';
            input1 = double.Parse(screen.Text);
            screen.Text = input1.ToString();
            firstClick = true;
        }

        private void point_Click_1(object sender, EventArgs e)
        {
            if (firstClick)
            {
                screen.Text = "0";
                firstClick=false;
            }
            screen.Text += ".";
        }

        private void clear_Click_1(object sender, EventArgs e)
        {
            screen.Text = "0";
        }

        private void sign_Click(object sender, EventArgs e)
        {
            double temp = new double();
            temp = (double.Parse(screen.Text));
            temp = -1 * temp;
            screen.Text = temp.ToString();
            input1 = (-1 * input1);

          
            //if (temp != 0)
            //{
            //    temp = -1 * temp;
            //    screen.Text = temp.ToString();
            //    input1 = (-1 * input1);
            //}
            //else
            //{
            //    screen.Text = "-0";
            //    input1 = -1;
            //}

            //double value = double.Parse(screen.Text);
            //double newValue = -value;
            //input1 = newValue;
            //screen.Text = newValue.ToString();

        }

        private void percentage_Click(object sender, EventArgs e)
        {

        }

        private void square_Click(object sender, EventArgs e)
        {
            double value = double.Parse(screen.Text);
            double res = Math.Pow(value, 2);
            screen.Text = res.ToString();
            firstClick = true;
        }

        private void leftParanthesis_Click(object sender, EventArgs e)
        {
            //screen.Text = "(";
            screen.Text = "(" + screen.Text;

        }

        private void rightParanthesis_Click_1(object sender, EventArgs e)
        {
            //screen.Text =  ")";
            screen.Text = screen.Text + ")";
        }

        private void log10_Click(object sender, EventArgs e)
        {
            double value = double.Parse(screen.Text);
            double result = Math.Log10(value);
            screen.Text = result.ToString();
            firstClick = true;
        }

        private void pi_Click_1(object sender, EventArgs e)
        {
            //double value = double.Parse(screen.Text);
            //double res = Math.PI
            screen.Text = "3.14159265";
             
        }

        private void cosInverse_Click(object sender, EventArgs e)
        {
            double value = double.Parse(screen.Text);
            double result = Math.Acos(value);
            screen.Text = result.ToString();
            firstClick = true;
        }

        private void sin_Click(object sender, EventArgs e)
        {
            double value = double.Parse(screen.Text);
            double result = Math.Sin(value);
            screen.Text = result.ToString();
            firstClick = true;
        }

        private void tan_Click(object sender, EventArgs e)
        {
            double value = double.Parse(screen.Text);
            double result = Math.Tan(value);
            screen.Text = result.ToString();
            firstClick = true;
        }

        private void log_Click(object sender, EventArgs e)
        {
            double value = double.Parse(screen.Text);
            double result = Math.Log(value);
            screen.Text = result.ToString();
            firstClick = true;
        }

        private void cos_Click(object sender, EventArgs e)
        {
            double value = double.Parse(screen.Text);
            double result = Math.Cos(value);
            screen.Text = result.ToString();
            firstClick = true;
        }

        private void cosec_Click(object sender, EventArgs e)
        {
            double value = double.Parse(screen.Text);
            double result = 1 / Math.Sin(value);
            screen.Text = result.ToString();
            firstClick = true;
        }

        private void sec_Click(object sender, EventArgs e)
        {
            double value = double.Parse(screen.Text);
            double result = 1 / Math.Cos(value);
            screen.Text = result.ToString();
            firstClick = true;
        }

        private void cot_Click(object sender, EventArgs e)
        {
            double value = double.Parse(screen.Text);
            double result = 1 / Math.Tan(value);
            screen.Text = result.ToString();
            firstClick = true;
        }

        private void sinInverse_Click(object sender, EventArgs e)
        {
            double value = double.Parse(screen.Text);
            double result = Math.Asin(value);
            screen.Text = result.ToString();
            firstClick = true;
        }

        private void tanInverse_Click(object sender, EventArgs e)
        {
            double value = double.Parse(screen.Text);
            double result = Math.Atan(value);
            screen.Text = result.ToString();
            firstClick = true;
        }

        private void power10_Click(object sender, EventArgs e)
        {
            double value = double.Parse(screen.Text);
            double result = Math.Pow(10, value);
            screen.Text = result.ToString();
            firstClick = true;
        }

        private void factorial_Click(object sender, EventArgs e)
        {
            double value = double.Parse(screen.Text);
            double res = factorialOfNum((int)value);
            screen.Text = res.ToString();
            firstClick = true;
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            double value = double.Parse(screen.Text);
            double res = Math.Sqrt(value);
            screen.Text = res.ToString();
            firstClick = true;
        }

        private void exponent_Click(object sender, EventArgs e)
        {
            double value = double.Parse(screen.Text);
            double res = Math.Pow(Math.E, value);
            screen.Text = res.ToString();
            firstClick = true;
        }

        private void reciprocal_Click(object sender, EventArgs e)
        {
            double value = double.Parse(screen.Text);
            double res = 1 / (value);
            input1 = res;
            screen.Text = res.ToString();
            firstClick = true; 
        }

        private void abs_Click(object sender, EventArgs e)
        {
            double value = double.Parse(screen.Text);
            double res = Math.Abs(value);
            screen.Text= res.ToString();    
            firstClick = true;
        }

        private void mod_Click(object sender, EventArgs e)
        {
            operation = '%';
            input1 = double.Parse(screen.Text);
            screen.Text = input1.ToString();
            firstClick = true;
        }

        private void cothInverse_Click(object sender, EventArgs e)
        {
            double value = double.Parse(screen.Text);
            double result = 1 / Math.Atan(value);
            screen.Text = result.ToString();
            firstClick = true;
        }

        private void cosechInverse_Click(object sender, EventArgs e)
        {
            double value = double.Parse(screen.Text);
            double result = Math.Log(value + Math.Sqrt(value * value + 1));
            screen.Text = result.ToString();
            firstClick = true;

        }

        private void sinhInverse_Click(object sender, EventArgs e)
        {
            double x = double.Parse(screen.Text);
            double result = Math.Log(x + Math.Sqrt(x * x + 1));
            screen.Text = result.ToString();
            firstClick = true;
        }

        private void coshInverse_Click(object sender, EventArgs e)
        {
            double x = double.Parse(screen.Text);
            if (x < 1)
            {
                screen.Text = "error";
            }
            double result = Math.Log(x + Math.Sqrt(x * x - 1));
            screen.Text = result.ToString();
            firstClick = true;
        }

        private void tanhInverse_Click(object sender, EventArgs e)
        {
            double x = double.Parse(screen.Text);
            if (x <= -1.0 || x >= 1.0)
            {
                screen.Text = "error";
            }
            double result = 0.5 * Math.Log((1 + x) / (1 - x));
            screen.Text = result.ToString();
            firstClick = true;
        }

        private void ln_Click(object sender, EventArgs e)
        {
            double value = double.Parse(screen.Text);
            double result = Math.Log(value);
            screen.Text = result.ToString();
            firstClick = true;
        }

        private void floor_Click(object sender, EventArgs e)
        {
            double value = double.Parse(screen.Text);
            double result = Math.Floor(value);
            screen.Text = result.ToString();
            firstClick = true;
        }

        private void ceil_Click(object sender, EventArgs e)
        {
            double value = double.Parse(screen.Text);
            double result = Math.Ceiling(value);
            screen.Text = result.ToString();
            firstClick = true;
        }

        private void cube_Click(object sender, EventArgs e)
        {
            double value = double.Parse(screen.Text);
            double res = Math.Pow(value, 3);
            screen.Text = res.ToString();
            firstClick = true;
        }

        private void binary_Click(object sender, EventArgs e)
        {
            double value = double.Parse(screen.Text);
            screen.Text = " ";
            screen.Text = DecToAnyBase((int)value, 2).ToString();
            firstClick = true;
        }

        private void octal_Click(object sender, EventArgs e)
        {
            double value = double.Parse(screen.Text);
            screen.Text = DecToAnyBase((int)value, 8);
            firstClick = true;
        }

        private void hexaDecimal_Click(object sender, EventArgs e)
        {
            double value = double.Parse(screen.Text);
            screen.Text = DecToAnyBase((int)value, 16);
            firstClick = true;
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            int len = screen.Text.Length;
            if (len != 1 && screen.Text!= "0")
                screen.Text = screen.Text.Substring(0, len-1);

        }
    }
    
}

