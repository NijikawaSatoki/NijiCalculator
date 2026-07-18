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

namespace NijiCalculator
{
    class NijiMath
    {
        private string _errorDivideByZeroMsgEn = "Error!\nYou can't divide by 0!";
        private string _errorDivideByZeroMsgJa = "注意！\nｘ÷０はできません！";
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
                Console.WriteLine(_errorDivideByZeroMsgEn);
                Environment.Exit(1);
            }
            double z = x / y;
            return z;
        }
        public int Modulus(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine(_errorDivideByZeroMsgEn);
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
                x = x + i;
            }
            sum = x;
            return sum;
        }
    }
}

/* >>>>>> END OF FILE <<<<<< */
