using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        String operation = "";
        Double firstNumber, secondNumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void numericValues(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (visor.Text == "0")
                visor.Text = "";

            if (b.Text == ".")
            {
                if (!visor.Text.Contains("."))
                    visor.Text = visor.Text + b.Text;
            }
                
            
            else
            {
                    visor.Text = visor.Text + b.Text;      
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            visor.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            visor.Text = "0";

            String f, s;

            f = Convert.ToString(firstNumber);
            s = Convert.ToString(secondNumber);

            s = "";
            f = "";
        }

        private void operations_functions(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            firstNumber = Double.Parse(visor.Text);
            operation = b.Text;
            visor.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (visor.Text.Length > 0) 
            {
                visor.Text = visor.Text.Remove(visor.Text.Length - 1,1);
            }
            if (visor.Text == "")
            {
                visor.Text = "0";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (visor.Text.Contains("-"))
            {
                visor.Text = visor.Text.Remove(0, 1);
            }
            else
            {
                visor.Text = "-" + visor.Text;
            }
                
        }

        private void button18_Click(object sender, EventArgs e)
        {
            secondNumber = Double.Parse(visor.Text);
            switch (operation)
            {
                case "+":
                    visor.Text = Convert.ToString(firstNumber + secondNumber);
                    break;

                case "-":
                    visor.Text = Convert.ToString(firstNumber - secondNumber);
                    break;

                case "*":
                    visor.Text = Convert.ToString(firstNumber * secondNumber);
                    break;

                case "/":
                    visor.Text = Convert.ToString(firstNumber / secondNumber);
                    break;

                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
