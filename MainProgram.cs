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
                { 13, "Base 10 Log" },
                { 14, "Average" },
                { 15, "" }
            };
            string optionList = $" 0. {options[0]}\t 1. {options[1]}\t 2. {options[2]}\n 3. {options[3]}\t 4. {options[4]}\t 5. {options[5]}\n 6. {options[6]}\t 7. {options[7]}\t 8. {options[8]}\n 9. {options[9]}\t10. {options[10]}\t11. {options[11]}\n12. {options[12]}\t13. {options[13]}\t{options[14]}";
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
                    // Explains what addition does
                    string additionInfo = "Adds two numbers together.\n";
                    Console.WriteLine(additionInfo);
                    // Prompt the user to input the numbers
                    Console.Write(enterNumberPrompt0);
                    int addX = Convert.ToInt32(Console.ReadLine());
                    Console.Write(enterNumberPrompt1);
                    int addY = Convert.ToInt32(Console.ReadLine());
                    // Add the numbers and print the result
                    int addResult = nijimath.Addition(addX, addY);
                    string equationAddition = $"{addX} + {addY} = {addResult}";
                    Console.WriteLine(equationAddition);
                    break;
                case 1:     // Subtraction
                    // Explains what subtraction does
                    string subtractionInfo = "Subtracts one number from another.\n";
                    Console.WriteLine(subtractionInfo);
                    // Prompt the user to input the numbers
                    Console.Write(enterNumberPrompt0);
                    int subtractX = Convert.ToInt32(Console.ReadLine());
                    Console.Write(enterNumberPrompt1);
                    int subtractY = Convert.ToInt32(Console.ReadLine());
                    // Subtract the numbers and print the result
                    int subtractResult = nijimath.Subtraction(subtractX, subtractY);
                    string equationSubtraction = $"{subtractX} - {subtractY} = {subtractResult}";
                    Console.WriteLine(equationSubtraction);
                    break;
                case 2:     // Multiplication
                    // Explains what multiplication does
                    string multiplicationInfo = "Multiplies two numbers together.\n";
                    Console.WriteLine(multiplicationInfo);
                    // Prompt the user to input the numbers
                    Console.Write(enterNumberPrompt0);
                    int multiplyX = Convert.ToInt32(Console.ReadLine());
                    Console.Write(enterNumberPrompt1);
                    int multiplyY = Convert.ToInt32(Console.ReadLine());
                    // Multiply the numbers and print the result
                    int multiplyResult = nijimath.Multiplication(multiplyX, multiplyY);
                    string equationMultiplication = $"{multiplyX} × {multiplyY} = {multiplyResult}";
                    Console.WriteLine(equationMultiplication);
                    break;
                case 3:     // Division
                    // Explain what division does
                    string divisionInfo = "Divides one number by another.\n";
                    Console.WriteLine(divisionInfo);
                    // Prompt the user to input the numbers
                    Console.Write(enterNumberPrompt0);
                    double divideX = Convert.ToDouble(Console.ReadLine());
                    Console.Write(enterNumberPrompt1);
                    double divideY = Convert.ToDouble(Console.ReadLine());
                    // Divide the numbers and print the result
                    double divideResult = nijimath.Division(divideX, divideY);
                    string equationDivision = $"{divideX} ÷ {divideY} = {divideResult}";
                    Console.WriteLine(equationDivision);
                    break;
                case 4:     // Modulus
                    // Explains what modulus does
                    string modulusInfo = "Divides two numbers and takes the remainder.\n";
                    Console.WriteLine(modulusInfo);
                    // Prompt the user to input the numbers
                    Console.Write(enterNumberPrompt0);
                    int moduloX = Convert.ToInt32(Console.ReadLine());
                    Console.Write(enterNumberPrompt1);
                    int moduloY = Convert.ToInt32(Console.ReadLine());
                    // Perform the modulus and print the result
                    int moduloResult = nijimath.Modulus(moduloX, moduloY);
                    string equationModulus = $"{moduloX} mod {moduloY} = {moduloResult}";
                    Console.WriteLine(equationModulus);
                    break;
                case 5:     // Summation
                    // Explain what summation does
                    string summationInfo = "Summation takes a number, start at a specific index, and then iterate through.\n";
                    Console.WriteLine(summationInfo);
                    // Prompt the user to input the number
                    Console.Write(enterNumberPrompt0);
                    int sumX = Convert.ToInt32(Console.ReadLine());
                    // Calculate the sum and print the result
                    int sumResult = nijimath.Summation(sumX);
                    string equationSummation = $"∑({sumX}) = {sumResult}";
                    Console.WriteLine(equationSummation);
                    break;
                case 6:     // Exponentiation
                    // Explain what exponentiation
                    string exponentiationInfo = "\n";
                    Console.WriteLine(exponentiationInfo);
                    // Prompt the user to input the numbers
                    Console.Write(enterNumberPrompt0);
                    double exponentX = Convert.ToDouble(Console.ReadLine());
                    Console.Write(enterNumberPrompt1);
                    double exponentY = Convert.ToDouble(Console.ReadLine());
                    // Calculate the exponent and print the result
                    double exponentResult = nijimath.Exponentiation(exponentX, exponentY);
                    string equationExponent = $"{exponentX}^{exponentY} = {exponentResult}";
                    Console.WriteLine(equationExponent);
                    break;
                case 7:     // Square roots
                    // Explain what square roots do
                    string squareRootInfo = "\n";
                    Console.WriteLine(squareRootInfo);
                    // Prompt the user to input the number
                    Console.Write(enterNumberPrompt0);
                    double squareRootX = Convert.ToDouble(Console.ReadLine());
                    // Calculate the square root and print the result
                    double squareRootResult = nijimath.SquareRoot(squareRootX);
                    string equationSquareRoot = $"√{squareRootX} = {squareRootResult}";
                    Console.WriteLine(equationSquareRoot);
                    break;
                case 8:     // Sine
                    // Explain what sine does (I won't because I'm bad at trigonometry :p)
                    string sineInfo = "\n";
                    Console.WriteLine(sineInfo);
                    // Prompt the user to input the angle
                    Console.Write(enterNumberPrompt0);
                    double sineX = Convert.ToDouble(Console.ReadLine());
                    // Calculate the sine and print the result
                    double sineResult = nijimath.TrigSine(sineX);
                    string equationSine = $"sin {sineX}° = {sineResult}";
                    Console.WriteLine(equationSine);
                    break;
                case 9:     // Cosine
                    // Explain what cosine does (I won't because I'm bad at trigonometry :p)
                    string cosineInfo = "\n";
                    Console.WriteLine(cosineInfo);
                    // Prompt the user to input the angle
                    Console.Write(enterNumberPrompt0);
                    double cosineX = Convert.ToDouble(Console.ReadLine());
                    // Calculate the cosine and print the result
                    double cosineResult = nijimath.TrigCosine(cosineX);
                    string equationCosine = $"cos {cosineX}° = {cosineResult}";
                    Console.WriteLine(equationCosine);
                    break;
                case 10:    // Tangent
                    // Explain what tangent does (I won't because I'm bad at trigonometry :p)
                    string tangentInfo = "\n";
                    Console.WriteLine(tangentInfo);
                    // Prompt the user to input the angle
                    Console.Write(enterNumberPrompt0);
                    double tangentX = Convert.ToDouble(Console.ReadLine());
                    // Calculate the tangent and print the result
                    double tangentResult = nijimath.TrigTangent(tangentX);
                    string equationTangent = $"tan {tangentX}° = {tangentResult}";
                    Console.WriteLine(equationTangent);
                    break;
                case 11:    // Natural logarithm
                    // Explain what the natural logarithm does (I won't because I'm bad at high level algebra :p)
                    string naturalLogInfo = "\n";
                    Console.WriteLine(naturalLogInfo);
                    // Prompt the user to input the number
                    Console.Write(enterNumberPrompt0);
                    double natLogX = Convert.ToDouble(Console.ReadLine());
                    // Calculate the natural logarithm and print the result
                    double natLogResult = nijimath.NaturalLogarithm(natLogX);
                    string equationNatLog = $"ln {natLogX} = {natLogResult}";
                    Console.WriteLine(equationNatLog);
                    break;
                case 12:    // Base 2 logarithm
                    // Explain what the base 2 logarithm does (I won't because I'm bad at high level algebra :p)
                    string base2LogInfo = "\n";
                    Console.WriteLine(base2LogInfo);
                    // Prompt the user to input the number
                    Console.Write(enterNumberPrompt0);
                    double base2LogX = Convert.ToDouble(Console.ReadLine());
                    // Calculate the base 2 logarithm and print the result
                    double base2LogResult = nijimath.Base2Logarithm(base2LogX);
                    string equationBase2Log = $"log₂ {base2LogX} = {base2LogResult}";
                    Console.WriteLine(equationBase2Log);
                    break;
                case 13:    // Base 10 logarithm
                    // Explain what the base 10 logarithm does (I won't because I'm bad at high level algebra :p)
                    string base10LogInfo = "\n";
                    Console.WriteLine(base10LogInfo);
                    // Prompt the user to input the number
                    Console.Write(enterNumberPrompt0);
                    double base10LogX = Convert.ToDouble(Console.ReadLine());
                    // Calculate the base 10 logarithm and print the result
                    double base10LogResult = nijimath.Base10Logarithm(base10LogX);
                    string equationBase10Log = $"log₁₀ {base10LogX} = {base10LogResult}";
                    Console.WriteLine(equationBase10Log);
                    break;
                case 14:    // Average
                    // Explain what averaging does
                    string averageInfo = "\n";
                    Console.WriteLine(averageInfo);
                    // Prompt the user to input the number
                    List<double> numberArray = new List<double>();
                    double averageX = 0.00;
                    // User inputs the numbers that they want to average up until a '0' is inputted
                    do
                    {
                        Console.Write("Please enter a number.\nEnter \"0\" to stop: ");
                        averageX = Convert.ToDouble(Console.ReadLine());
                        numberArray.Add(averageX);
                    } while (averageX != 0) ;
                    // Calculate the base 10 logarithm and print the result
                    double averageResult = nijimath.AverageSum(numberArray);
                    string equationAverage = $"The average of all the numbers you gave is {averageResult}.";
                    Console.WriteLine(equationAverage);
                    break;
                case 15:    // 

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
