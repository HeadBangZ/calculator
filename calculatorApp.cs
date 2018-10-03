using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorApp : Form
    {
        string operation;
		bool isOperationPerformed = false;
		double result;
		double numValue;
        
        public CalculatorApp()
        {
            InitializeComponent();
        }

        private void numberBtn(object sender, EventArgs e)
        {
            if ((resultBox.Text == "0") || (isOperationPerformed))
            {
                resultBox.Clear();
            }
            Button numBtn = (Button)sender;
            if (numBtn.Text == ".")
            {
                if (!resultBox.Text.Contains("."))
                {
                    resultBox.Text = resultBox.Text + numBtn.Text;
                }
            }
            else
            {
                resultBox.Text = resultBox.Text + numBtn.Text;
            }
			result = Double.Parse(resultBox.Text);
			resultField.Text = result.ToString();
			isOperationPerformed = false;
		}

		private void operatorBtn(object sender, EventArgs e)
        {
            Button mathBtn = (Button)sender;
			operation = mathBtn.Text;
			numValue = Double.Parse(resultBox.Text);
			resultField.Text = (numValue + " " + operation).ToString();
			isOperationPerformed = true;
        }

        private void numC_Click(object sender, EventArgs e)
        {
            resultBox.Text = "0";
            resultField.Text = "";
        }

		private void equalBtn_Click(object sender, EventArgs e)
		{
			switch (operation)
			{
				case "+":
					resultField.Text = (numValue + Double.Parse(resultBox.Text)).ToString();
					break;
				case "-":
					resultField.Text = (numValue - Double.Parse(resultBox.Text)).ToString();
					break;
				case "/":
					resultField.Text = (numValue / Double.Parse(resultBox.Text)).ToString();
					break;
				case "*":
					resultField.Text = (numValue * Double.Parse(resultBox.Text)).ToString();
					break;
			}
			resultBox.Clear();
		}
	}
}
