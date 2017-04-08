using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class MathOperations
    {
        public string Plus(double firstValue,double secondValue)
        {
            return Convert.ToString(firstValue + secondValue);
        }

        public string Minus(double firstValue, double secondValue)
        {
            return Convert.ToString(firstValue - secondValue);
        }

        public string Multiply(double firstValue, double secondValue)
        {
            return Convert.ToString(firstValue * secondValue);
        }

        public string Divide(double firstValue, double secondValue)
        {
            return Convert.ToString(firstValue / secondValue);
        }

        public string RaiseToPow(double firstValue, double secondValue)
        {
            return Convert.ToString(Math.Pow(firstValue, secondValue));
        }

        public string Sin(double value)
        {
            return Convert.ToString(Math.Sin(value * Math.PI / 180));
        }

        public string Cos(double value)
        {
            return Convert.ToString(Math.Cos(value * Math.PI / 180));
        }

        public string Tan(double value)
        {
            return Convert.ToString(Math.Tan(value * Math.PI / 180));
        }

        public string CTan(double value)
        {
            return Convert.ToString((Math.Cos(value * Math.PI / 180))/(Math.Sin(value * Math.PI / 180)));
        }
    }
}
