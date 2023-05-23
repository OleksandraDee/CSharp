using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_2
{
    public partial class Form1 : Form
    {
        double result=0;
        string operationPerformed = "";
        bool isOperationPerfomed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (isOperationPerfomed))
                  txtDisplay.Clear();
            
            isOperationPerfomed=false;
            Button button = (Button)sender;
            txtDisplay.Text = txtDisplay.Text + button.Text;

        }

        private void Operation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            result = Double.Parse(txtDisplay.Text);
            isOperationPerfomed = true;
            lblCalculator.Text = result + " " + operationPerformed;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblCalculator.Text = "Calculator";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+": txtDisplay.Text = (result + Double.Parse(txtDisplay.Text)).ToString();
                          lblCalculator.Text = "Result";
                    break;
                case "-": txtDisplay.Text = (result - Double.Parse(txtDisplay.Text)).ToString();
                          lblCalculator.Text = "Result";
                    break;
                case "*": txtDisplay.Text = (result * Double.Parse(txtDisplay.Text)).ToString();
                          lblCalculator.Text = "Result";
                    break;
                case "/": txtDisplay.Text = (result / Double.Parse(txtDisplay.Text)).ToString();
                          lblCalculator.Text = "Result";
                    break;
                default: break;
            }
        }
    }
}
