//Create a simple calculator that given a string of operators(+ - * and /) and numbers
//separated by spaces returns the value of that expression

//Example:

//Evaluator().evaluate("2 / 2 + 3 * 4 - 6") # => 7
//Remember about the order of operations! Multiplications and divisions have a higher priority
//and should be performed left-to-right.Additions and subtractions have a lower priority and
//should also be performed left-to-right.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Calculator
{
    public class Evaluator
    {
        public double Evaluate(string expression)
        {
            if (string.IsNullOrEmpty(expression))
            {
                return 0;
            }
            expression = Regex.Replace(expression, @"\s+", "");

            double firstOperand = Char.GetNumericValue(expression[0]);
            char operation = expression[1];
            double secondOperand = Char.GetNumericValue(expression[2]);

            double result= 0;
            switch (operation)
            {
                case '+':
                    result = firstOperand + secondOperand;
                    break;
                case '-':
                    result = firstOperand - secondOperand;
                    break;
                case '*':
                    result = firstOperand * secondOperand;
                    break;
                case '/':
                    result = firstOperand / secondOperand;
                    break;
                default:
                    throw new ArgumentException($"{operation} is not a supported operation");
            }

            return result;
        }
    }
}
