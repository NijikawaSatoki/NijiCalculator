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
    class MainProgram
    {
        static int Main()
        {
            // Create the objects
            NijiMath nijimath = new NijiMath();
            // Setup all these strings & variables (prolly for some kind of translation?)
            const string TITLE = "\"Niji's Calculator\"\n";
            const string AUTHOR = "Niji System\n\n";
            string optionAddition = "Addition";
            string optionSubtraction = "Subtraction";
            string optionMultiplication = "Multiplication";
            string optionDivision = "Division";
            string optionModulus = "Modulus";
            string optionSummation = "Summation";
            string optionExponent = "Exponent";
            string optionSqRoot = "Square root";
            List<string> options = new List<string>();
                options.Add(optionAddition);          // Option 0
                options.Add(optionSubtraction);       // Option 1
                options.Add(optionMultiplication);    // Option 2
                options.Add(optionDivision);          // Option 3
                options.Add(optionModulus);           // Option 4
                options.Add(optionSummation);         // Option 5
                options.Add(optionExponent);          // Option 6
                options.Add(optionSqRoot);            // Option 7
            string optionList = $"0. {options[0]}\t1. {options[1]}\t2. {options[2]}\n3. {options[3]}\t4. {options[4]}\t5. {options[5]}\n6. {options[6]}\t7. {options[7]}";
            string welcomeText = "Welcome!";
            string decisionPrompt = "What do you want to do? (Type the number!) ";
            string enterNumberPrompt0 = "Enter a number: ";
            string enterNumberPrompt1 = "Enter another number: ";
            string outOfBoundsMsg0 = "Out of bounds!";
            string outOfBoundsMsg1 = "Stop using that damned noclip!";
            string sendOffMsg = "Have a nice day.";
            // Start!
            Console.Write($"{TITLE}{AUTHOR}");
            // Decisions...
            Console.WriteLine(welcomeText);
            Console.WriteLine(optionList);
            Console.Write(decisionPrompt);
            int choice = Convert.ToInt32(Console.ReadLine());
            // Execute
            switch (choice)
            {
                case 0:     // Addition
                    Console.Write(enterNumberPrompt0);
                    int addX = Convert.ToInt32(Console.ReadLine());
                    Console.Write(enterNumberPrompt1);
                    int addY = Convert.ToInt32(Console.ReadLine());
                    int addResult = nijimath.Addition(addX, addY);
                    string equationAddition = $"{addX} + {addY} = {addResult}";
                    Console.WriteLine(equationAddition);
                    break;
                case 1:     // Subtraction
                    Console.Write(enterNumberPrompt0);
                    int subtractX = Convert.ToInt32(Console.ReadLine());
                    Console.Write(enterNumberPrompt1);
                    int subtractY = Convert.ToInt32(Console.ReadLine());
                    int subtractResult = nijimath.Subtraction(subtractX, subtractY);
                    string equationSubtraction = $"{subtractX} - {subtractY} = {subtractResult}";
                    Console.WriteLine(equationSubtraction);
                    break;
                case 2:     // Multiplication
                    Console.Write(enterNumberPrompt0);
                    int multiplyX = Convert.ToInt32(Console.ReadLine());
                    Console.Write(enterNumberPrompt1);
                    int multiplyY = Convert.ToInt32(Console.ReadLine());
                    int multiplyResult = nijimath.Multiplication(multiplyX, multiplyY);
                    string equationMultiplication = $"{multiplyX} * {multiplyY} = {multiplyResult}";
                    Console.WriteLine(equationMultiplication);
                    break;
                case 3:     // Division
                    Console.Write(enterNumberPrompt0);
                    double divideX = Convert.ToDouble(Console.ReadLine());
                    Console.Write(enterNumberPrompt1);
                    double divideY = Convert.ToDouble(Console.ReadLine());
                    double divideResult = nijimath.Division(divideX, divideY);
                    string equationDivision = $"{divideX} / {divideY} = {divideResult}";
                    Console.WriteLine(equationDivision);
                    break;
                case 4:     // Modulus
                    Console.Write(enterNumberPrompt0);
                    int moduloX = Convert.ToInt32(Console.ReadLine());
                    Console.Write(enterNumberPrompt1);
                    int moduloY = Convert.ToInt32(Console.ReadLine());
                    int moduloResult = nijimath.Modulus(moduloX, moduloY);
                    string equationModulus = $"{moduloX} % {moduloY} = {moduloResult}";
                    Console.WriteLine(equationModulus);
                    break;
                case 5:     // Summation
                    Console.Write(enterNumberPrompt0);
                    int sumX = Convert.ToInt32(Console.ReadLine());
                    int sumResult = nijimath.Summation(sumX);
                    string equationSummation = $"∑({sumX}) = {sumResult}";
                    Console.WriteLine(equationSummation);
                    break;
                case 6:     // Exponentiation
                    Console.Write(enterNumberPrompt0);
                    double exponentX = Convert.ToDouble(Console.ReadLine());
                    Console.Write(enterNumberPrompt1);
                    double exponentY = Convert.ToDouble(Console.ReadLine());
                    double exponentResult = nijimath.Exponentiation(exponentX, exponentY);
                    string equationExponent = $"{exponentX}^{exponentY} = {exponentResult}";
                    Console.WriteLine(equationExponent);
                    break;
                case 7:     // Square roots
                    Console.Write(enterNumberPrompt0);
                    double squareRootX = Convert.ToDouble(Console.ReadLine());
                    double squareRootResult = nijimath.SquareRoot(squareRootX);
                    string equationSquareRoot = $"√{squareRootX} = {squareRootResult}";
                    Console.WriteLine(equationSquareRoot);
                    break;
                default:    // Out of bounds
                    Console.WriteLine(outOfBoundsMsg0);
                    Console.WriteLine(outOfBoundsMsg1);
                    break;
                // End of switch block
            }
            // Sendoff
            Console.WriteLine(sendOffMsg);
            // Exit the program
            return 0;
        }
    }
}

/* >>>>>> END OF FILE <<<<<< */
