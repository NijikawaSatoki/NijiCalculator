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
            var options = new Dictionary<int, string>
            {
                {  0, "Addition" },
                {  1, "Subtraction" },
                {  2, "Multiplication" },
                {  3, "Division" },
                {  4, "Modulus" },
                {  5, "Summation" },
                {  6, "Exponent" },
                {  7, "Square root" },
                {  8, "Sine" },
                {  9, "Cosine" },
                { 10, "Tangent" },
                { 11, "Natural Log" },
                { 12, "Base 2 Log" },
                { 13, "Base 10 Log" }
            };
            string optionList = $" 0. {options[0]}\t 1. {options[1]}\t 2. {options[2]}\n 3. {options[3]}\t 4. {options[4]}\t 5. {options[5]}\n 6. {options[6]}\t 7. {options[7]}\t 8. {options[8]}\n 9. {options[9]}\t10. {options[10]}\t11. {options[11]}\n12. {options[12]}\t13. {options[13]}";
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
                    string equationMultiplication = $"{multiplyX} × {multiplyY} = {multiplyResult}";
                    Console.WriteLine(equationMultiplication);
                    break;
                case 3:     // Division
                    Console.Write(enterNumberPrompt0);
                    double divideX = Convert.ToDouble(Console.ReadLine());
                    Console.Write(enterNumberPrompt1);
                    double divideY = Convert.ToDouble(Console.ReadLine());
                    double divideResult = nijimath.Division(divideX, divideY);
                    string equationDivision = $"{divideX} ÷ {divideY} = {divideResult}";
                    Console.WriteLine(equationDivision);
                    break;
                case 4:     // Modulus
                    Console.Write(enterNumberPrompt0);
                    int moduloX = Convert.ToInt32(Console.ReadLine());
                    Console.Write(enterNumberPrompt1);
                    int moduloY = Convert.ToInt32(Console.ReadLine());
                    int moduloResult = nijimath.Modulus(moduloX, moduloY);
                    string equationModulus = $"{moduloX} mod {moduloY} = {moduloResult}";
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
                case 8:     // Sine
                    Console.Write(enterNumberPrompt0);
                    double sineX = Convert.ToDouble(Console.ReadLine());
                    double sineResult = nijimath.TrigSine(sineX);
                    string equationSine = $"sin {sineX}° = {sineResult}";
                    Console.WriteLine(equationSine);
                    break;
                case 9:     // Cosine
                    Console.Write(enterNumberPrompt0);
                    double cosineX = Convert.ToDouble(Console.ReadLine());
                    double cosineResult = nijimath.TrigCosine(cosineX);
                    string equationCosine = $"cos {cosineX}° = {cosineResult}";
                    Console.WriteLine(equationCosine);
                    break;
                case 10:    // Tangent
                    Console.Write(enterNumberPrompt0);
                    double tangentX = Convert.ToDouble(Console.ReadLine());
                    double tangentResult = nijimath.TrigTangent(tangentX);
                    string equationTangent = $"tan {tangentX}° = {tangentResult}";
                    Console.WriteLine(equationTangent);
                    break;
                case 11:    // Natural logarithm
                    Console.Write(enterNumberPrompt0);
                    double natLogX = Convert.ToDouble(Console.ReadLine());
                    double natLogResult = nijimath.NaturalLogarithm(natLogX);
                    string equationNatLog = $"ln {natLogX} = {natLogResult}";
                    Console.WriteLine(equationNatLog);
                    break;
                case 12:    // Base 2 logarithm
                    Console.Write(enterNumberPrompt0);
                    double base2LogX = Convert.ToDouble(Console.ReadLine());
                    double base2LogResult = nijimath.Base2Logarithm(base2LogX);
                    string equationBase2Log = $"log₂ {base2LogX} = {base2LogResult}";
                    Console.WriteLine(equationBase2Log);
                    break;
                case 13:    // Base 10 logarithm
                    Console.Write(enterNumberPrompt0);
                    double base10LogX = Convert.ToDouble(Console.ReadLine());
                    double base10LogResult = nijimath.Base10Logarithm(base10LogX);
                    string equationBase10Log = $"log₁₀ {base10LogX} = {base10LogResult}";
                    Console.WriteLine(equationBase10Log);
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
