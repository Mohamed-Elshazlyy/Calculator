using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator001
{
    public partial class Form1 : Form
    {
        Calculations operation = new Calculations(); 

        public Form1()
        {
            InitializeComponent();
            operation.Op = true;
            operation.IsDecimal = true;
        }
              
           

        private void buttonNum_Click(object sender, EventArgs e)
        {
            
            if (lblResult.Text == "0" || (operation.Op))
                lblResult.ResetText();
            operation.Op = false;
            Button button = (Button)sender;
            if(button.Text == ".")
            {
                if (operation.IsDecimal)
                {
                    lblResult.Text = lblResult.Text + button.Text;
                    operation.IsDecimal = false;
                }
            }else
            lblResult.Text = lblResult.Text + button.Text;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            lblResult.ResetText();
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            lblResult.Text = "0";
        }

        private void Calculation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation.Calculation = button.Text;
            operation.Value = double.Parse(lblResult.Text);
            operation.Op = true;
            operation.IsDecimal = true;

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            switch (operation.Calculation)
            {
                case "+":
                    lblResult.Text = Calculations.Addition(operation.Value, double.Parse(lblResult.Text)).ToString();
                    break;
                case "-":
                    lblResult.Text = Calculations.Subtraction(operation.Value, double.Parse(lblResult.Text)).ToString();
                    break;
                case "X":
                    lblResult.Text = Calculations.Multiplication(operation.Value, double.Parse(lblResult.Text)).ToString();
                    break;
                case "/":
                    lblResult.Text = Calculations.Division(operation.Value , double.Parse(lblResult.Text)).ToString();
                    break;
                default:
                    break;
            }
            operation.Op = true;
            operation.IsDecimal = true;

        }

       
        public void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            
                switch (e.KeyChar.ToString())
            {
                case "0":
                    button0.PerformClick();
                    break;
                case "1":
                    button1.PerformClick();
                    break;
                case "2":
                    button02.PerformClick();
                    break;
                case "3":
                    button03.PerformClick();
                    break;
                case "4":
                    button04.PerformClick();
                    break;
                case "5":
                    button05.PerformClick();
                    break;
                case "6":
                    button06.PerformClick();
                    break;
                case "7":
                    button07.PerformClick();
                    break;
                case "8":
                    button08.PerformClick();
                    break;
                case "9":
                    button09.PerformClick();
                    break;
                case ".":
                    buttonPoint.PerformClick();
                    break;
                case "+":
                    buttonAdd.PerformClick();
                    break;
                case "-":
                    buttonMinus.PerformClick();
                    break;
                case "*":
                    buttonMultiply.PerformClick();
                    break;
                case "/":
                    buttonDiv.PerformClick();
                    break;
                case "=":
                    btnResult.PerformClick();
                    break;
                default:
                    break;

            }
        }
    }
}
