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
 *         SAW-01-2548 "Mlikam Klichesh"
 */

using System;
using System.Collections.Generic;

namespace NijiCalculator
{
    class NijiMath
    {
        // Error message(s)
        private readonly string _errorDivideByZeroMsg = "Error!\nYou can't divide by 0!";
        private readonly string _errorArrayLengthZeroMsg = "Error!\nThe length of the array is 0!\nYou can't divide by 0!";
        // Basic operations
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
        // Bitwise functions (these always assume that you're working with 32-bit numbers!)
        public uint BitwiseNOT(uint number)
        {
            uint @byte = ~number;
            return @byte;
        }
        public uint BitShiftLeft(uint number, int shiftCount)
        {
            // Note that if `shiftCount` is >= 31, then the value will be a guaranteed 0!
            uint @byte = number << shiftCount;
            return @byte;
        }
        public uint BitShiftRight(uint number, int shiftCount)
        {
            // Note that if `shiftCount` is >= 31, then the value will be a guaranteed 0!
            uint @byte = number >> shiftCount;
            return @byte;
        }
        public uint BitwiseAND(uint number, int mask)
        {
            uint uintMask = (uint)mask;
            uint @byte = number & uintMask;
            return @byte;
        }
        public uint BitwiseOR(uint number, int mask)
        {
            uint uintMask = (uint)mask;
            uint @byte = number | uintMask;
            return @byte;
        }
        public uint BitwiseXOR(uint number, int mask)
        {
            uint uintMask = (uint)mask;
            uint @byte = number ^ uintMask;
            return @byte;
        }
        // Trigonometric functions
        public double Sine(double angle)
        {
            double sine = Math.Sin(angle);
            return sine;
        }
        public double Cosine(double angle)
        {
            double cosine = Math.Cos(angle);
            return cosine;
        }
        public double Tangent(double angle)
        {
            double tangent = Math.Tan(angle);
            return tangent;
        }
        public double HypberbolicSine(double angle)
        {
            double hyperSine = Math.Sinh(angle);
            return hyperSine;
        }
        public double HypberbolicCosine(double angle)
        {
            double hyperCosine = Math.Cosh(angle);
            return hyperCosine;
        }
        public double HypberbolicTangent(double angle)
        {
            double hyperTangent = Math.Tanh(angle);
            return hyperTangent;
        }
        // Logarithmic functions
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
        // Temperature functions
        public double CelsiusToFahrenheit(double celsius)
        {
            // Temperature constants
            const double ABSOLUTE_ZERO = -273.15d;
            const double WATER_FREEZING_POINT = 0d;
            const double WATER_BOILING_POINT = 100d;
            // Calculate the temperature in °F
            double fahrenheit = 0.00d;
            if (celsius == ABSOLUTE_ZERO)
            {
                fahrenheit = -459.67d;
            }
            else if (celsius == WATER_FREEZING_POINT)
            {
                fahrenheit = 32d;
            }
            else if (celsius == WATER_BOILING_POINT)
            {
                fahrenheit = 212d;
            }
            else
            {
                fahrenheit = celsius * (9d / 5d) + 32;
            }
            return fahrenheit;
        }
        public double CelsiusToKelvin(double celsius)
        {
            // Temperature constants
            const double ABSOLUTE_ZERO = -273.15d;
            const double WATER_FREEZING_POINT = 0d;
            const double WATER_BOILING_POINT = 100d;
            // Calculate the temperature in K
            double kelvin = 0.00d;
            if (celsius == ABSOLUTE_ZERO)
            {
                kelvin = 0d;
            }
            else if (celsius == WATER_FREEZING_POINT)
            {
                kelvin = 273.15d;
            }
            else if (celsius == WATER_BOILING_POINT)
            {
                kelvin = 373.15d;
            }
            else
            {
                kelvin = celsius + 273.15d;
            }
            return kelvin;
        }
        public double FahrenheitToCelsius(double fahrenheit)
        {
            // Temperature constants
            const double ABSOLUTE_ZERO = -459.67d;
            const double WATER_FREEZING_POINT = 32d;
            const double WATER_BOILING_POINT = 212d;
            // Calculate the temperature in °C
            double celsius = 0.00d;
            if (fahrenheit == ABSOLUTE_ZERO)
            {
                celsius = -273.15d;
            }
            else if (fahrenheit == WATER_FREEZING_POINT)
            {
                celsius = 0d;
            }
            else if (fahrenheit == WATER_BOILING_POINT)
            {
                celsius = 100d;
            }
            else
            {
                celsius = (fahrenheit - 32) * 5d / 9d;
            }
            return celsius;
        }
        public double FahrenheitToKelvin(double fahrenheit)
        {
            // Temperature constants
            const double ABSOLUTE_ZERO = -459.67d;
            const double WATER_FREEZING_POINT = 32d;
            const double WATER_BOILING_POINT = 212d;
            // Calculate the temperature in K
            double kelvin = 0.00d;
            if (fahrenheit == ABSOLUTE_ZERO)
            {
                kelvin = 0.00d;
            }
            else if (fahrenheit == WATER_FREEZING_POINT)
            {
                kelvin = 273.15d;
            }
            else if (fahrenheit == WATER_BOILING_POINT)
            {
                kelvin = 373.15d;
            }
            else
            {
                double celsius = (fahrenheit - 32) * 5d / 9d;
                kelvin = celsius + 273.15d;
            }
            return kelvin;
        }
        public double KelvinToCelsius(double kelvin)
        {
            // Temperature constants
            const double ABSOLUTE_ZERO = 0d;
            const double WATER_FREEZING_POINT = 273.15d;
            const double WATER_BOILING_POINT = 373.15d;
            // Calculate the temperature in °C
            double celsius = 0.00d;
            if (kelvin == ABSOLUTE_ZERO)
            {
                celsius = -273.15d;
            }
            else if (kelvin == WATER_FREEZING_POINT)
            {
                celsius = 0d;
            }
            else if (kelvin == WATER_BOILING_POINT)
            {
                celsius = 100d;
            }
            else
            {
                celsius = kelvin - 273.15d;
            }
            return celsius;
        }
        public double KelvinToFahrenheit(double kelvin)
        {
            // Temperature constants
            const double ABSOLUTE_ZERO = 0d;
            const double WATER_FREEZING_POINT = 273.15d;
            const double WATER_BOILING_POINT = 373.15d;
            // Calculate the temperature in °F
            double fahrenheit = 0.00d;
            if (kelvin == ABSOLUTE_ZERO)
            {
                fahrenheit = -459.67d;
            }
            else if (kelvin == WATER_FREEZING_POINT)
            {
                fahrenheit = 32d;
            }
            else if (kelvin == WATER_BOILING_POINT)
            {
                fahrenheit = 212d;
            }
            else
            {
                double celsius = kelvin - 273.15d;
                fahrenheit = celsius * (9d / 5d) + 32;
            }
            return fahrenheit;
        }
        // Other functions
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
        public double AverageSum(List<double> items)
        {
            double average = 0;
            double sum = 0;
            // For edge cases where the list somehow has a length of 0
            if (items.Count == 0)
            {
                Console.WriteLine(_errorArrayLengthZeroMsg);
                Environment.Exit(1);
            }
            // Average it all up :3
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
