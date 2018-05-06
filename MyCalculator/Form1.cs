using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        private bool _operationPressed;
        private bool _texted = true;
        private bool _tryDivByZero;
        private string _operation;
        private double _buf;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (_tryDivByZero)
            {
                _tryDivByZero = false;
                display.Font = new Font("Microsoft Sans Serif", 28.2F);
                buttonC.PerformClick();
            }

            var s = sender as Button;

            if (display.Text == "0" || _operationPressed)
            {
                display.Clear();
                _operationPressed = false;
            }

            if (!(display.Text.Contains(".") && s.Text.Contains(".")))
            {
                display.Text += s.Text;
            }

            _texted = true;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            var s = sender as Button;
            _operationPressed = true;

            if (_texted)
            {
                label1.Text += display.Text + s.Text;
            }
            else
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1) + s.Text;
            }

            if (_buf != 0 && _texted)
            {
                Equals.PerformClick();
            }

            _texted = false;
            _operation = s.Text;

            Double.TryParse(display.Text, out _buf);
        }

        private void equals_Click(object sender, EventArgs e)
        {
            double textBox = Convert.ToDouble(display.Text);

            switch (_operation)
            {
                case "+":
                    display.Text = (_buf + textBox).ToString();
                    break;
                case "-":
                    display.Text = (_buf - textBox).ToString();
                    break;
                case "*":
                    display.Text = (_buf * textBox).ToString();
                    break;
                case "/":
                    if (textBox == 0)
                    {
                        display.Font = new Font("Microsoft Sans Serif", 26F);
                        display.Text = "Can not divide by zero ";
                        _tryDivByZero = true;
                    }
                    else
                    {
                        display.Text = (_buf / textBox).ToString();
                    }
                    break;
                default:
                    break;
            }
            _buf = 0;

            if (!_operationPressed || !_texted)
            {
                _operation = null;

                if (!_tryDivByZero)
                {
                    label1.Text = null;
                }
            }
            _operationPressed = true;
        }

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
    }
}
