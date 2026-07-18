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
            NijiMath math = new NijiMath();
            // Setup all these strings & variables (prolly for some kind of translation?)
            const string TITLE = "\"Niji's Calculator\"\n";
            const string AUTHOR = "Niji System\n\n";
            string optionAddition = "Addition";
            string optionSubtraction = "Subtraction";
            string optionMultiplication = "Multiplication";
            string optionDivision = "Division";
            string optionModulus = "Modulus";
            string optionSummation = "Summation";
            List<string> options = new List<string>();
                options.Add(optionAddition);          // Option 0
                options.Add(optionSubtraction);       // Option 1
                options.Add(optionMultiplication);    // Option 2
                options.Add(optionDivision);          // Option 3
                options.Add(optionModulus);           // Option 4
                options.Add(optionSummation);         // Option 5
            string optionList = $"0. {options[0]}\t1. {options[1]}\t2. {options[2]}\n3. {options[3]}\t4. {options[4]}\t5. {options[5]}";
            string welcomeText = "Welcome!";
            string decisionPrompt = "What do you want to do? ";
            string enterNumberPrompt0 = "Enter a number: ";
            string enterNumberPrompt1 = "Enter another number: ";
            int addX = 0;
            int addY = 0;
            int addResult = 0;
            string equationAddition = $"{addX} + {addY} = {addResult}";
            int subtractX = 0;
            int subtractY = 0;
            int subtractResult = 0;
            string equationSubtraction = $"{subtractX} - {subtractY} = {subtractResult}";
            int multiplyX = 0;
            int multiplyY = 0;
            int multiplyResult = 0;
            string equationMultiplication = $"{multiplyX} * {multiplyY} = {multiplyResult}";
            double divideX = 0.00;
            double divideY = 0.00;
            double divideResult = 0.00;
            string equationDivision = $"{divideX} / {divideY} = {divideResult}";
            int moduloX = 0;
            int moduloY = 0;
            int moduloResult = 0;
            string equationModulus = $"{moduloX} % {moduloY} = {moduloResult}";
            int sumX = 0;
            int sumResult = 0;
            string equationSummation = $"∑({sumX}) = {sumResult}";
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
                    addX = Convert.ToInt32(Console.ReadLine());
                    Console.Write(enterNumberPrompt1);
                    addY = Convert.ToInt32(Console.ReadLine());
                    addResult = math.Addition(addX, addY);
                    Console.WriteLine(equationAddition);
                    break;
                case 1:     // Subtraction
                    Console.Write(enterNumberPrompt0);
                    subtractX = Convert.ToInt32(Console.ReadLine());
                    Console.Write(enterNumberPrompt1);
                    subtractY = Convert.ToInt32(Console.ReadLine());
                    subtractResult = math.Subtraction(subtractX, subtractY);
                    Console.WriteLine(equationSubtraction);
                    break;
                case 2:     // Multiplication
                    Console.Write(enterNumberPrompt0);
                    multiplyX = Convert.ToInt32(Console.ReadLine());
                    Console.Write(enterNumberPrompt1);
                    multiplyY = Convert.ToInt32(Console.ReadLine());
                    multiplyResult = math.Multiplication(multiplyX, multiplyY);
                    Console.WriteLine(equationMultiplication);
                    break;
                case 3:     // Division
                    Console.Write(enterNumberPrompt0);
                    divideX = Convert.ToDouble(Console.ReadLine());
                    Console.Write(enterNumberPrompt1);
                    divideY = Convert.ToDouble(Console.ReadLine());
                    divideResult = math.Division(divideX, divideY);
                    Console.WriteLine(equationDivision);
                    break;
                case 4:     // Modulus
                    Console.Write(enterNumberPrompt0);
                    moduloX = Convert.ToInt32(Console.ReadLine());
                    Console.Write(enterNumberPrompt1);
                    moduloY = Convert.ToInt32(Console.ReadLine());
                    moduloResult = math.Modulus(moduloX, moduloY);
                    Console.WriteLine(equationModulus);
                    break;
                case 5:     // Summation
                    Console.Write(enterNumberPrompt0);
                    sumX = Convert.ToInt32(Console.ReadLine());
                    sumResult = math.Summation(sumX);
                    Console.WriteLine(equationSummation);
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
