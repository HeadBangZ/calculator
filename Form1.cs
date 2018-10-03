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
        double resultValue;
        
        public CalculatorApp()
        {
            InitializeComponent();
        }

        private void numberBtn(object sender, EventArgs e)
        {
            if (resultBox.Text == "0")
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
        }

        private void operatorBtn(object sender, EventArgs e)
        {
            Button mathBtn = (Button)sender;
            operation = mathBtn.Text;
            resultValue = Double.Parse(resultBox.Text);
            resultField.Text = resultValue + " " + operation;
        }

        private void numC_Click(object sender, EventArgs e)
        {
            resultBox.Text = "0";
            resultField.Text = "";
        }
    }
}
