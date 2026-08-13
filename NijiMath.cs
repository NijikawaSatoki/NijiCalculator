/* =============================================================================
 * Niji Calculator
 * =============================================================================
 * 
 * presented by:
 *     Niji System
 *         Satoki Nijikawa
 *         Wamo
 *         Kiyoi
 *         Vihreääketty
 *         Hsiao Lyuhsien
 *         Antiainehunt Õudus
 *         Rinith
 *         Q'aemil
 */

using System;
using System.Collections.Generic;

namespace NijiCalculator
{
    class NijiMath
    {
        private string _errorDivideByZeroMsg = "Error!\nYou can't divide by 0!";
        private string _errorArrayLengthZeroMsg = "Error!\nThe length of the array is 0!\nYou can't divide by 0!";
        public int Addition(int x, int y)
        {
            int z = x + y;
            return z;
        }
        public int Subtraction(int x, int y)
        {
            int z = x - y;
            return z;
        }
        public int Multiplication(int x, int y)
        {
            int z = x * y;
            return z;
        }
        public double Division(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine(_errorDivideByZeroMsg);
                Environment.Exit(1);
            }
            double z = x / y;
            return z;
        }
        public int Modulus(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine(_errorDivideByZeroMsg);
                Environment.Exit(1);
            }
            int z = x % y;
            return z;
        }
        public int Summation(int n)
        {
            int sum = 0;
            int x = 0;
            for (int i = 1; i <= n; i++)
            {
                x += i;
            }
            sum = x;
            return sum;
        }
        public double Exponentiation(double @base, double exponent)
        {
            double x = @base;
            double y = exponent;
            double z = Math.Pow(x, y);
            return z;
        }
        public double SquareRoot(double square)
        {
            double sqRoot = Math.Sqrt(square);
            return sqRoot;
        }
        public double TrigSine(double angle)
        {
            double sine = Math.Sin(angle);
            return sine;
        }
        public double TrigCosine(double angle)
        {
            double cosine = Math.Cos(angle);
            return cosine;
        }
        public double TrigTangent(double angle)
        {
            double tangent = Math.Tan(angle);
            return tangent;
        }
        public double NaturalLogarithm(double x)
        {
            double log = Math.Log(x);
            return log;
        }
        public double Base2Logarithm(double x)
        {
            double log = Math.Log2(x);
            return log;
        }
        public double Base10Logarithm(double x)
        {
            double log = Math.Log10(x);
            return log;
        }
        public double AverageSum(List<double> items)
        {
            double average = 0;
            double sum = 0;
            if (items.Count == 0)
            {
                Console.WriteLine(_errorArrayLengthZeroMsg);
                Environment.Exit(1);
            }
            for (int i = 0; i < items.Count; i++)
            {
                sum += items[i];
            }
            average = sum / items.Count;
            return average;
        }
    }
}

/* >>>>>> END OF FILE <<<<<< */
