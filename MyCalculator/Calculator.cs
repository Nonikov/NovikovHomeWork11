using System;
using System.Drawing;
using System.Windows.Forms;
using Model;

namespace MyCalculator
{
    public partial class Calculator : Form
    {
        #region Variables
        private bool _operationEntered;
        private bool _texted = true;
        private bool _tryDivByZero;
        private string _operation;
        private double _buf;
        #endregion

        #region Ctor
        public Calculator()
        {
            InitializeComponent();

            Size = new Size(478, 502);
            panel1.Location = new Point(6, 129);
            panel2.Location = new Point(5, 129);
            programmer1.Location = new Point(5, 129);
            programmer1.Visible = false;
            panel1.Size = new Size(449, 321);
            treeView1.Visible = false;
        }
        #endregion

        #region Standard Handlers
        private void button_Click(object sender, EventArgs e)
        {
            if (_tryDivByZero)
            {
                _tryDivByZero = false;
                display.Font = new Font("Microsoft Sans Serif", 28.2F);
                buttonC.PerformClick();
            }

            var s = sender as Button;

            if (display.Text == "0" || _operationEntered)
            {
                if (s.Text == ".")
                {
                    display.Text = "0.";
                }
                else
                {
                    display.Clear();
                }
                _operationEntered = false;
            }

            if (s.Text == ".")
            {
                if (!display.Text.Contains("."))
                    display.Text += s.Text;
            }
            else
            {
                display.Text += s.Text;
            }

            _texted = true;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            var s = sender as Button;
            _operationEntered = true;

            if (_texted)
            {
                if (s.Text == "%")
                {
                    if (_buf != 0)
                    {
                        double percent = _buf / 100 * Convert.ToDouble(display.Text);
                        display.Text = percent.ToString();
                    }
                    else
                    {
                        buttonC.PerformClick();
                        return;
                    }
                }
                label1.Text += display.Text + s.Text;
            }
            else
            {
                if (label1.Text == "" || label1.Text[label1.Text.Length - 1] == '%')
                {
                    label1.Text = display.Text + s.Text;
                }
                else
                {
                    label1.Text = label1.Text.Remove(label1.Text.Length - 1) + s.Text;
                }
            }

            if (_buf != 0 && _texted)
            {
                buttonEquals.PerformClick();
            }

            _texted = false;
            _operation = s.Text;

            Double.TryParse(display.Text, out _buf);
        }

        private void equals_Click(object sender, EventArgs e)
        {
            double textBox;
            if (!Double.TryParse(display.Text, out textBox))
                buttonC.PerformClick();

            switch (_operation)
            {
                case "+":
                    display.Text = StatndardCalc.Plus(_buf, textBox);
                    break;
                case "-":
                    display.Text = StatndardCalc.Minus(_buf, textBox);
                    break;
                case "*":
                    display.Text = StatndardCalc.Mul(_buf, textBox);
                    break;
                case "÷":
                    if (textBox == 0)
                    {
                        display.Font = new Font("Microsoft Sans Serif", 26F);
                        display.Text = "Can not divide by zero ";
                        _tryDivByZero = true;
                    }
                    else
                    {
                        display.Text = StatndardCalc.Div(_buf, textBox);
                    }
                    break;
                default:
                    break;
            }
            _buf = 0;

            if (!_operationEntered || !_texted)
            {
                _operation = null;

                if (!_tryDivByZero)
                {
                    label1.Text = null;
                }
            }
            _operationEntered = true;
        }
        #endregion

        #region Scientific Handlers
        private void button_ClickScientific(object sender, EventArgs e)
        {
            Button s = sender as Button;

            if (display.Text == "0")
            {
                if (s.Text == ".")
                {
                    display.Text = "0.";
                }
                else
                {
                    display.Clear();
                }
            }
            if (s.Text == ".")
            {
                if (!display.Text.Contains("."))
                    display.Text += s.Text;
            }
            else
            {
                display.Text += s.Text;
            }
        }

        private void equals_ClickScientific(object sender, EventArgs e)
        {
            display.Text = ScientificCalc.CalculateString(display.Text);
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            buttonEquals.PerformClick();
            display.Text = Math.Sin(Convert.ToDouble(display.Text) * Math.PI / 180).ToString();
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            buttonEquals.PerformClick();
            display.Text = Math.Cos(Convert.ToDouble(display.Text) * Math.PI / 180).ToString();
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            buttonEquals.PerformClick();
            display.Text = Math.Tan(Convert.ToDouble(display.Text) * Math.PI / 180).ToString();
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            buttonEquals.PerformClick();
            display.Text = Math.Log10(Convert.ToDouble(display.Text)).ToString();
        }

        private void buttonPI_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {
                display.Clear();
            }
            display.Text += Math.PI.ToString();
        }

        private void buttonSq_Click(object sender, EventArgs e)
        {
            try
            {
                display.Text = Math.Sqrt(Convert.ToDouble(display.Text)).ToString();
            }
            catch
            {
                display.Text = "error";
            }
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            buttonEquals.PerformClick();
            display.Text = ScientificCalc.Factorial(Convert.ToInt64(display.Text)).ToString();
        }
        #endregion

        #region Common Handlers
        private void buttonCE_Click(object sender, EventArgs e)
        {
            display.Text = "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            _buf = 0;
            _operation = null;
            label1.Text = null;
            _texted = true;
        }

        private void labelModes_Click(object sender, EventArgs e)
        {
            if (treeView1.Visible == false)
                treeView1.Visible = true;
            else
                treeView1.Visible = false;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "NodeStandard")
            {
                if (labelMode.Text == "Programmer") // Мок, пока нет логики в режиме "Programmer"
                {
                    labelMode.Text = "Standard";
                    Height = 502;
                    panel1.Location = new Point(6, 129);
                    panel2.Visible = false;
                    programmer1.Visible = false;
                    buttonPercent.Visible = true;
                    button0.Width = 85;
                    button0.Location = new Point(91, 245);
                    buttonC.PerformClick();
                }
                else if (labelMode.Text != "Standard")
                {
                    labelMode.Text = "Standard";
                    Height = 502;
                    panel1.Location = new Point(6, 129);
                    panel2.Visible = false;
                    programmer1.Visible = false;
                    buttonPercent.Visible = true;
                    button0.Width = 85;
                    button0.Location = new Point(91, 245);
                    buttonC.PerformClick();

                    button0.Click -= button_ClickScientific;
                    button1.Click -= button_ClickScientific;
                    button2.Click -= button_ClickScientific;
                    button3.Click -= button_ClickScientific;
                    button4.Click -= button_ClickScientific;
                    button5.Click -= button_ClickScientific;
                    button6.Click -= button_ClickScientific;
                    button7.Click -= button_ClickScientific;
                    button8.Click -= button_ClickScientific;
                    button9.Click -= button_ClickScientific;
                    buttonPlus.Click -= button_ClickScientific;
                    buttonDiv.Click -= button_ClickScientific;
                    buttonMinus.Click -= button_ClickScientific;
                    buttonMul.Click -= button_ClickScientific;
                    buttonEquals.Click -= equals_ClickScientific;

                    button0.Click += button_Click;
                    button1.Click += button_Click;
                    button2.Click += button_Click;
                    button3.Click += button_Click;
                    button4.Click += button_Click;
                    button5.Click += button_Click;
                    button6.Click += button_Click;
                    button7.Click += button_Click;
                    button8.Click += button_Click;
                    button9.Click += button_Click;
                    buttonPlus.Click += operator_Click;
                    buttonDiv.Click += operator_Click;
                    buttonMinus.Click += operator_Click;
                    buttonMul.Click += operator_Click;
                    buttonEquals.Click += equals_Click;
                }
            }

            if (e.Node.Name == "NodeScientific")
            {
                if (labelMode.Text == "Programmer") // Мок, пока нет логики в режиме "Programmer"
                {
                    labelMode.Text = "Scientific";
                    Height = 502;
                    panel1.Location = new Point(6, 129);
                    panel2.Visible = false;
                    programmer1.Visible = false;
                    buttonPercent.Visible = true;
                    button0.Width = 85;
                    button0.Location = new Point(91, 245);
                    buttonC.PerformClick();
                }
                else if (labelMode.Text != "Scientific")
                {
                    labelMode.Text = "Scientific";
                    Height = 665;
                    panel1.Location = new Point(5, 292);
                    panel2.Visible = true;
                    buttonPercent.Visible = false;
                    button0.Width = 176;
                    button0.Location = new Point(0, 245);
                    programmer1.Visible = false;

                    buttonC.PerformClick();

                    button0.Click -= button_Click;
                    button1.Click -= button_Click;
                    button2.Click -= button_Click;
                    button3.Click -= button_Click;
                    button4.Click -= button_Click;
                    button5.Click -= button_Click;
                    button6.Click -= button_Click;
                    button7.Click -= button_Click;
                    button8.Click -= button_Click;
                    button9.Click -= button_Click;
                    buttonPlus.Click -= operator_Click;
                    buttonDiv.Click -= operator_Click;
                    buttonMinus.Click -= operator_Click;
                    buttonMul.Click -= operator_Click;
                    buttonEquals.Click -= equals_Click;

                    button0.Click += button_ClickScientific;
                    button1.Click += button_ClickScientific;
                    button2.Click += button_ClickScientific;
                    button3.Click += button_ClickScientific;
                    button4.Click += button_ClickScientific;
                    button5.Click += button_ClickScientific;
                    button6.Click += button_ClickScientific;
                    button7.Click += button_ClickScientific;
                    button8.Click += button_ClickScientific;
                    button9.Click += button_ClickScientific;
                    buttonPlus.Click += button_ClickScientific;
                    buttonDiv.Click += button_ClickScientific;
                    buttonMinus.Click += button_ClickScientific;
                    buttonMul.Click += button_ClickScientific;
                    buttonEquals.Click += equals_ClickScientific;
                }
            }

            if (e.Node.Name == "NodeProgrammer")
            {
                labelMode.Text = "Programmer";
                treeView1.Visible = false;
                Height = 742;
                panel1.Location = new Point(5, 370);
                panel2.Visible = false;
                programmer1.Visible = true;
                buttonPercent.Visible = false;
                button0.Width = 176;
                button0.Location = new Point(0, 245);
            }
            treeView1.Visible = false;
        }
        #endregion
    }
}
