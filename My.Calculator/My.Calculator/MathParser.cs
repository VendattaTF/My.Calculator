using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My.Calculator
{

    class MathParser
    {
        /*
         * To do list: 
         * log(a,b), mod(a,b), round(x,n),! (n!), arcsin(x), arcos(x), arctg(x), arcctg(x)
         * ln(x), log2(x), log10(x), rad(x), exp(x), deg(x), abs(x), sgn(x), floor(x)
         */
        //Get text of an expression and calculate its value.
        public double Calculate(string newExpr)
        {
            char[] expr = newExpr.ToCharArray();
            double result = parseParanthesis(expr);
            if (result !=double.NaN)
                return result;
            else
                return double.NaN;

        }
        //Check if there are unknown sintax.
        public bool check(string str)
        {
            for (int i = 1; i < str.Length; i++)
                if (str[i] == ' ')
                    return false;
            return true;
        }
        //Variable x.
        private double varX;
        //Set value for variable x.
        public void setArgumentValue(double var)
        {
            varX = var;
        }
        //Recursively calculate value of any expression between paranthesis.
        private double parseParanthesis(char[] expr)
        {
            int indexStart = 0;
            bool exParanthesis = false;
            while (indexStart < expr.Length - 1)
            {
                if (expr[indexStart] == '(')
                {
                    exParanthesis = true;
                    break;
                }
                indexStart++;

            }
            int indexEnd = indexStart + 1;
            int nr = 0;
            while (indexEnd < expr.Length)
            {
                if (expr[indexEnd] == '(')
                    nr++;
                if (expr[indexEnd] == ')')
                {
                    if (nr == 0)

                    {
                        exParanthesis = true;
                        break;
                    }
                    else nr--;
                }

                indexEnd++;
            }
            if (exParanthesis == true)
            {
                MathParser mathParser = new MathParser();
                mathParser.setArgumentValue(varX);
                string expression = new string(expr);
                string expression1 = expression;
                string expression2 = expression;
                expression = expression.Substring(0, indexEnd);
                expression = expression.Substring(indexStart + 1);
                if (indexStart - 1 >= 0)
                {
                    expression1 = expression1.Substring(0, indexStart);
                }
                else expression1 = "";
                if (indexEnd + 1 < expression2.Length)
                {
                    expression2 = expression2.Substring(indexEnd + 1);
                }
                else expression2 = "";
                double result = mathParser.Calculate(expression);
                string expressionResult;
                if (result != double.NaN)
                    expressionResult = expression1 + result.ToString() + expression2;
                else return double.NaN;

                expr = expressionResult.ToCharArray();

                return parseParanthesis(expr);
            }
            else
                return parseSummands(expr, 0);

        }
        //Summ or difference two values x and y.(x+y,x-y)
        private double parseSummands(char[] expr, int index)
        {
            double x = parseFactors(expr, ref index);
            while (true)
            {
                char op = expr[index];
                if (op != '+' && op != '-')
                    return x;
                index++;
                double y = parseFactors(expr, ref index);
                if (op == '+')
                    x += y;
                else
                    x -= y;
            }
        }
        //Multiplicate two values x and y.(x*y,x/y)
        private double parseFactors(char[] expr, ref int index)
        {
            double x = parsePowers(expr, ref index);
            while (true)
            {
                char op = expr[index];
                if (op != '/' && op != '*')
                    return x;
                index++;
                double y = parsePowers(expr, ref index);
                if (op == '/')
                    x /= y;
                else
                    x *= y;
            }
        }
        //Raise the power of x to y.(x^y)
        private double parsePowers(char[] expr, ref int index)
        {
            double x = parseFunctions(expr, ref index);
            while (true)
            {
                char op = expr[index];
                if (op != '^')
                    return x;
                index++;
                double y = parseFunctions(expr, ref index);
                x = Math.Pow(x, y);
            }
        }
        //Search for functions and returning its value. (sin(X),cos(X),tan(X),sqrt(X))
        private double parseFunctions(char[] expr, ref int index)
        {
            if (((int)expr[index] >= '0' && (int)expr[index] <= '9') || expr[index] == '.' || expr[index] == '-' || expr[index] == 'e' || (expr[index] == 'p' && expr[index + 1] == 'i'))
                return GetDouble(expr, ref index);
            else
            {
                char op = expr[index];
                if (op != 's' && op != 'c' && op != 't')
                    return GetDouble(expr, ref index);
                double x;
                if (expr[index] == 's' && expr[index + 1] == 'q' && expr[index + 2] == 'r' && expr[index + 3] == 't')
                {
                    index += 4;
                    x = GetDouble(expr, ref index);
                    if (x >= 0)
                        return Math.Sqrt(x);
                    else
                        return double.NaN;
                }
                index += 3;
                x = GetDouble(expr, ref index);
                if (op == 'c')
                    return Math.Cos(x);
                else
                if (op == 's')
                    return Math.Sin(x);
                else
                    return Math.Tan(x);
            }
        }
        //Return the value following after an operand.
        private double GetDouble(char[] expr, ref int index)
        {

            string dbl = "";

            int indexInitial = index;
            while (((int)expr[index] >= '0' && (int)expr[index] <= '9') || expr[index] == '.' || expr[index] == '-' || expr[index] == 'e' || (expr[index] == 'p' && expr[index + 1] == 'i') || expr[index] == 'x')
            {
                if (expr[index] == '-' && index != indexInitial)
                {
                    break;
                }
                if (expr[index] == '-' && expr[index + 1] == '-' && index == indexInitial)
                {
                    index += 2;
                }
                if (expr[index] == 'e')
                {
                    if (index + 1 < expr.Length)
                        index++;
                    return Math.E;
                }
                if (expr[index] == 'p' && expr[index + 1] == 'i')
                {
                    if (index + 2 < expr.Length)
                        index += 2;
                    return Math.PI;
                }
                if (expr[index] == 'x')
                {
                    if (index + 1 < expr.Length)
                        index++;
                    return varX;
                }
                else
                {
                    dbl = dbl + expr[index].ToString();
                    index++;
                }
                if (index == expr.Length)
                {
                    index--;
                    break;
                }
            }
            if (dbl == "")
                return double.NaN;
            else
                return double.Parse(dbl);
        }

    }
}
