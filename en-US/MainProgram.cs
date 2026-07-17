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
using System.Collections.Generic;

namespace NijiCalculator
{
    class MainProgram
    {
        static int Main()
        {
            // Create the objects
            NijiMath math = new NijiMath();
            // Start!
            const string TITLE = "\"Niji's Calculator\"\n";
            const string AUTHOR = "Niji System\n\n";
            Console.Write($"{TITLE}{AUTHOR}");
            // Decisions...
            List<string> options = new List<string>();
            options.Add("Addition");          // Option 0
            options.Add("Subtraction");       // Option 1
            options.Add("Multiplication");    // Option 2
            options.Add("Division");          // Option 3
            options.Add("Modulus");           // Option 4
            options.Add("Summation");         // Option 5
            string optionList = $"0. {options[0]}\t1. {options[1]}\t2. {options[2]}\n3. {options[3]}\t4. {options[4]}\t5. {options[5]}";
            Console.WriteLine("Welcome!");
            Console.WriteLine(optionList);
            Console.Write("What do you want to do? ");
            int choice = Convert.ToInt32(Console.ReadLine());
            // Execute
            switch (choice)
            {
                case 0:     // Addition
                    Console.Write("Enter a number: ");
                    int addX = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter another number: ");
                    int addY = Convert.ToInt32(Console.ReadLine());
                    int addResult = math.Addition(addX, addY);
                    Console.WriteLine($"{addX} + {addY} = {addResult}");
                    break;
                case 1:     // Subtraction
                    Console.Write("Enter a number: ");
                    int subtractX = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter another number: ");
                    int subtractY = Convert.ToInt32(Console.ReadLine());
                    int subtractResult = math.Subtraction(subtractX, subtractY);
                    Console.WriteLine($"{subtractX} - {subtractY} = {subtractResult}");
                    break;
                case 2:     // Multiplication
                    Console.Write("Enter a number: ");
                    int multiplyX = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter another number: ");
                    int multiplyY = Convert.ToInt32(Console.ReadLine());
                    int multiplyResult = math.Multiplication(multiplyX, multiplyY);
                    Console.WriteLine($"{multiplyX} * {multiplyY} = {multiplyResult}");
                    break;
                case 3:     // Division
                    Console.Write("Enter a number: ");
                    double divideX = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter another number: ");
                    double divideY = Convert.ToDouble(Console.ReadLine());
                    double divideResult = math.Division(divideX, divideY);
                    Console.WriteLine($"{divideX} / {divideY} = {divideResult}");
                    break;
                case 4:     // Modulus
                    Console.Write("Enter a number: ");
                    int moduloX = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter another number: ");
                    int moduloY = Convert.ToInt32(Console.ReadLine());
                    int moduloResult = math.Modulus(moduloX, moduloY);
                    Console.WriteLine($"{moduloX} % {moduloY} = {moduloResult}");
                    break;
                case 5:     // Summation
                    Console.Write("Enter a number: ");
                    int sumX = Convert.ToInt32(Console.ReadLine());
                    int sumResult = math.Summation(sumX);
                    Console.WriteLine($"∑({sumX}) = {sumResult}");
                    break;
                default:    // Out of bounds
                    Console.WriteLine("Out of bounds!");
                    Console.WriteLine("Stop using that damned noclip!");
                    break;
                // End of switch block
            }
            // Sendoff
            Console.WriteLine("Have a nice day.");
            // Exit the program
            return 0;
        }
    }
}

/* >>>>>> END OF FILE <<<<<< */
