using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class StatndardCalc
    {
        #region Methods
        public static string Plus(double oper1, double oper2)
        {
            return (oper1 + oper2).ToString();
        }

        public static string Minus(double oper1, double oper2)
        {
            return (oper1 - oper2).ToString();
        }

        public static string Mul(double oper1, double oper2)
        {
            return (oper1 * oper2).ToString();
        }

        public static string Div(double oper1, double oper2)
        {
            return (oper1 / oper2).ToString();
        }
        #endregion
    }
}
