using System;
using System.Collections.Generic;
using System.Text;

namespace NewCalk
{
    public static class OperatorCalculator
    {
        public static double Calculate(double val1, double val2, string mathOperator)
        {
            double result = 0;
            switch (mathOperator)
            {
                case "/":
                    result = val1 / val2;
                    break;
                case "*":
                    result = val1 * val2;
                    break;
                case "+":
                    result = val1 + val2;
                    break;
                case "-":
                    result = val1 - val2;
                    break;
            }
            return result;
        }
    }
}