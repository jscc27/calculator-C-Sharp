using System;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment05
{
    public partial class Juliano_Calculator : Form
    {
        decimal firstNumber, secondNumber, result;
        string operation;
        public Juliano_Calculator()
        {
            InitializeComponent();
            textBox2.AppendText("\r\ntest\ntest2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == null || textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void buttonSignal_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString((-1) * Convert.ToDecimal(textBox1.Text));
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDecimal(textBox1.Text);
            operation = "sum";
            textBox1.Text = null;
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDecimal (textBox1.Text);
            operation = "subtraction";
            textBox1.Text = null;
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDecimal(textBox1.Text);
            operation = "multiplication";
            textBox1.Text = null;
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDecimal(textBox1.Text);
            operation = "division";
            textBox1.Text = null;
        }

        private void buttonDivInv_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDecimal(textBox1.Text);
            result = 1 / firstNumber;
            textBox1.Text = Convert.ToString(result);
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDecimal(textBox1.Text);
            result = Convert.ToDecimal(Math.Sqrt(Convert.ToDouble(firstNumber)));
            textBox1.Text = Convert.ToString(result);
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "sum":
                    secondNumber = Convert.ToDecimal(textBox1.Text);
                    result = firstNumber + secondNumber;
                    textBox1.Text = Convert.ToString(result);
                    break;
                case "subtraction":
                    secondNumber = Convert.ToDecimal(textBox1.Text);
                    result = firstNumber - secondNumber;
                    textBox1.Text = Convert.ToString(result);
                    break;
                case "multiplication":
                    secondNumber = Convert.ToDecimal(textBox1.Text);
                    result = firstNumber * secondNumber;
                    textBox1.Text = Convert.ToString(result);
                    break;
                case "division":
                    secondNumber = Convert.ToDecimal(textBox1.Text);
                    if (secondNumber == 0)
                    {
                        textBox1.Text = "ERROR!";
                        Task.Delay(2000).Wait();
                        textBox1.Text = "Cannot divide by 0";
                        Task.Delay(2000).Wait();
                        textBox1.Text = "Clearing...";
                        Task.Delay(2000).Wait();
                        textBox1.Text = null;
                    }
                    else
                    {
                        result = firstNumber / secondNumber;
                        textBox1.Text = Convert.ToString(result);
                    }
                    break;
                case "power":
                    secondNumber = Convert.ToDecimal(textBox1.Text);
                    result = Convert.ToDecimal(Math.Pow(Convert.ToDouble(firstNumber), Convert.ToDouble(secondNumber)));
                    textBox1.Text = Convert.ToString(result);
                    break;
            }
        }
        private void stdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (stdBtn.Checked)
            {
                Size = new Size(500, 489);
                tabControl1.Size = new Size(476, 423);
                calculatorTab.Size = new Size(476, 423);
                clearBtn.Location = new Point(272, 151);
                buttonPlus.Location = new Point(272, 207);
                buttonMult.Location = new Point(272, 263);
                buttonDivInv.Location = new Point(272, 319);
                buttonResult.Location = new Point(384, 207);
                buttonMinus.Location = new Point(328, 207);
                buttonDiv.Location = new Point(328, 263);
                buttonSqrt.Location = new Point(328, 319);
                textBox1.Size = new Size(376,50);
                powBtn.Visible = false;
                piBtn.Visible = false;
                facBtn.Visible = false;
                pow2Btn.Visible = false;
            }
        }

        private void scientificBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (scientificBtn.Checked)
            {
                Size = new Size(600, 489);
                tabControl1.Size = new Size(576, 423);
                calculatorTab.Size = new Size(576, 423);
                clearBtn.Location = new Point(328, 151);
                buttonPlus.Location = new Point(328, 207);
                buttonMult.Location = new Point(328, 263);
                buttonDivInv.Location = new Point(328, 319);
                buttonMinus.Location = new Point(384, 207);
                buttonDiv.Location = new Point(384, 263);
                buttonSqrt.Location = new Point(384, 319);
                buttonResult.Location = new Point(440, 207);
                textBox1.Size = new Size(476, 50);
                pow2Btn.Visible = true;
                powBtn.Visible = true;
                piBtn.Visible = true;
                facBtn.Visible = true;
                pow2Btn.Location = new Point(272, 151);
                powBtn.Location = new Point(272, 207);
                piBtn.Location = new Point(272, 263);
                facBtn.Location = new Point(272, 319);
            }
        }

        private void darkCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (darkCheck.Checked)
            {   
                calculatorTab.BackColor = Color.Black;
                button0.BackColor = Color.White;
                button0.ForeColor = Color.Black;
                button1.BackColor = Color.White;
                button1.ForeColor = Color.Black;
                button2.BackColor = Color.White;
                button2.ForeColor = Color.Black;
                button3.BackColor = Color.White;
                button3.ForeColor = Color.Black;
                button4.BackColor = Color.White;
                button4.ForeColor = Color.Black;
                button5.BackColor = Color.White;
                button5.ForeColor = Color.Black;
                button6.BackColor = Color.White;
                button6.ForeColor = Color.Black;
                button7.BackColor = Color.White;
                button7.ForeColor = Color.Black;
                button8.BackColor = Color.White;
                button8.ForeColor = Color.Black;
                button9.BackColor = Color.White;
                button9.ForeColor = Color.Black;
                buttonDot.BackColor = Color.White;
                buttonDot.ForeColor = Color.Black;
                buttonSignal.BackColor = Color.White;
                buttonSignal.ForeColor = Color.Black;
                stdBtn.ForeColor = Color.White;
                scientificBtn.ForeColor = Color.White;
                darkCheck.ForeColor = Color.White;
            }
            else
            {
                calculatorTab.BackColor = Color.White;
                button0.BackColor = Color.Black;
                button0.ForeColor = Color.White;
                button1.BackColor = Color.Black;
                button1.ForeColor = Color.White;
                button2.BackColor = Color.Black;
                button2.ForeColor = Color.White;
                button3.BackColor = Color.Black;
                button3.ForeColor = Color.White;
                button4.BackColor = Color.Black;
                button4.ForeColor = Color.White;
                button5.BackColor = Color.Black;
                button5.ForeColor = Color.White;
                button6.BackColor = Color.Black;
                button6.ForeColor = Color.White;
                button7.BackColor = Color.Black;
                button7.ForeColor = Color.White;
                button8.BackColor = Color.Black;
                button8.ForeColor = Color.White;
                button9.BackColor = Color.Black;
                button9.ForeColor = Color.White;
                buttonDot.BackColor = Color.Black;
                buttonDot.ForeColor = Color.White;
                buttonSignal.BackColor = Color.Black;
                buttonSignal.ForeColor = Color.White;
                stdBtn.ForeColor = Color.Black;
                scientificBtn.ForeColor = Color.Black;
                darkCheck.ForeColor = Color.Black;
            }
        }
        private void pow2Btn_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDecimal(textBox1.Text);
            result = Convert.ToDecimal(Math.Pow(Convert.ToDouble(firstNumber), 2));
            textBox1.Text = Convert.ToString(result);
        }

        private void powBtn_Click(object sender, EventArgs e)
        {
            operation = "power";
            firstNumber = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = null;
        }

        private void piBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.PI);
        }

        private void facBtn_Click(object sender, EventArgs e)
        {
            int result = 1;
            firstNumber = Convert.ToDecimal(textBox1.Text);
            if (firstNumber%1 != 0 || firstNumber < 0)
            {
                textBox1.Text = "ERROR!";
                Task.Delay(2000).Wait();
                textBox1.Text = "Must be a whole number";
                Task.Delay(2000).Wait();
                textBox1.Text = "Clearing...";
                Task.Delay(2000).Wait();
                textBox1.Text = null;
            }
            else
            {
                while (firstNumber > 0)
                {
                    result = result * Convert.ToInt32(firstNumber);
                    firstNumber--;
                }
                textBox1.Text = Convert.ToString(result);
            }
        }
    }
}