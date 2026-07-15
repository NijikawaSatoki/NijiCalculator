/* ============================
 * Niji Calculator
 * ============================
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
        private string _errorDivideByZero = "Error!\nYou can't divide by 0!";
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
                Console.WriteLine(_errorDivideByZero);
                Environment.Exit(1);
            }
            double z = x / y;
            return z;
        }
        public int Modulus(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine(_errorDivideByZero);
                Environment.Exit(1);
            }
            int z = x % y;
            return z;
        }
    }
}

/* >>>>>> END OF FILE <<<<<< */
