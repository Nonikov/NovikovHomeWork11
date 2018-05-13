using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Model
{
   public static class ScientificCalc
    {
        #region Utility
        private static int prior(char symb)
        {
            switch (symb)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '÷':
                case '^':
                    return 2;
                default:
                    return -1;
            }
        }
        #endregion

        #region Methods
        public static string CalculateString(string str)
        {
            //string input=tbInput.Text.Replace(" ","");
            string input = str;
            string outStr = String.Empty;
            Stack<char> operStack = new Stack<char>();
            List<string> outList = new List<string>();
            Stack<double> calculation = new Stack<double>();
            string currentToken = String.Empty;
            string operations = "*÷+-^=()";
            string opers = "*÷+-^";
            bool equalFound = false;

            foreach (char c in input)
            {
                if (operations.IndexOf(c, 0) == -1)
                    currentToken += c;
                else 
                {

                    if (!String.IsNullOrEmpty(currentToken)) outList.Add(currentToken);
                    currentToken = String.Empty;
                    if (opers.IndexOf(c) != -1)
                    {
                        if (operStack.Count == 0)
                        {
                            operStack.Push(c);
                            continue;
                        }
                        else 
                        {
                            if (prior(c) > prior(operStack.Peek())) operStack.Push(c);
                            else 
                            { 
                                while (operStack.Count > 0 && prior(operStack.Peek()) >= prior(c)) outList.Add(operStack.Pop().ToString());
                                operStack.Push(c); 
                            }
                        }
                    }
                    if (c == ')')
                    {
                        try
                        {
                            while (operStack.Peek() != '(') 
                            {
                                outList.Add(operStack.Pop().ToString()); 
                                if (operStack.Count == 0)
                                {
                                    return "error";
                                }

                            }
                        }
                        catch
                        {
                            return "error";
                        }
                        operStack.Pop();
                    }
                    if (c == '(' || c == '=') 
                        operStack.Push(c); 
                    if (c == '=')
                    {
                        if (equalFound)
                        {
                            return "error";
                        }
                        equalFound = true;
                    }
                }
            }
            outList.Add(currentToken);
            while (operStack.Count > 0) outList.Add(operStack.Pop().ToString());
            double oper1, oper2, res = 0;

            foreach (string s in outList)
            {
                if (String.IsNullOrEmpty(s)) continue;
                if (s == "(")
                {
                    return "error";
                }
                if (opers.IndexOf(s) != -1) 
                {
                    try
                    {
                        oper2 = calculation.Pop();
                        oper1 = calculation.Pop();
                        if (s == "*") res = oper1 * oper2;
                        if (s == "÷") res = oper1 / oper2;
                        if (s == "-") res = oper1 - oper2;
                        if (s == "+") res = oper1 + oper2;
                        if (s == "^") res = Convert.ToInt32(Math.Pow(oper1, oper2));
                        calculation.Push(res);
                    }
                    catch
                    {
                        return "error";
                    }
                }
                else 
                {
                    calculation.Push(Convert.ToDouble(s));

                }
            }
            return calculation.Pop().ToString();
        }

        public static long Factorial(long n)
        {
            long r = 1;
            for(long i = 2; i <= n; i++)
            {
                r *= i;
            }
            return r;
        }
        #endregion
    }
}