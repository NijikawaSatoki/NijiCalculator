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
    class MainProgram
    {
        static int Main()
        {
            // Create the objects
            NijiMath nijimath = new NijiMath();
            NijiConvenience convenient = new NijiConvenience();
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
                { 15, "Temperature" },
                { 16, "Bit shift left" },
                { 17, "Bit shift right" },
                { 18, "Bitwise NOT" },
                { 19, "Bitwise AND" },
                { 20, "Bitwise OR" },
                { 21, "Bitwise XOR" },
                { 22, "" },
                { 23, "" },
                { 24, "" },
                { 25, "" },
                { 26, "" },
                { 27, "" },
                { 28, "" },
                { 29, "" },
                { 30, "" },
                { 31, "" }
            };
            /*
             0. Addition     1. Subtraction          2. Multiplication
             3. Division     4. Modulus              5. Summation
             6. Exponent     7. Square root          8. Sine
             9. Cosine      10. Tangent             11. Natural Log
            12. Base 2 Log  13. Base 10 Log         14. Temperature
            15. Temperature 16. Bit shift left      17. Bit shift right
            18. Bitwise NOT 19. Bitwise AND         20. Bitwise OR
            21. Bitwise XOR
            */
            string optionList = $" 0. {options[0]}\t 1. {options[1]}\t 2. {options[2]}\n 3. {options[3]}\t 4. {options[4]}\t 5. {options[5]}\n 6. {options[6]}\t 7. {options[7]}\t 8. {options[8]}\n 9. {options[9]}\t10. {options[10]}\t11. {options[11]}\n12. {options[12]}\t13. {options[13]}\t14. {options[14]}\n15. {options[15]}\t16. {options[16]}\t\t17. {options[17]}\n18. {options[18]}\t19. {options[19]}\t20. {options[20]}\n21. {options[21]}";
            string welcomeText = "Welcome!";
            string decisionPrompt = "What do you want to do? (Type the number!) ";
            string enterNumberPrompt0 = "Enter a number: ";
            string enterNumberPrompt1 = "Enter another number: ";
            string outOfBoundsMsg0 = "Out of bounds!";
            string outOfBoundsMsg1 = "Stop using that damned noclip!";
            string sendOffMsg = "Have a nice day.";
            // Start!
            Console.Write($"{TITLE}{AUTHOR}");
            char shallIContinue = ' ';
            do
            {
                // Decisions...
                Console.WriteLine(welcomeText);
                Console.WriteLine(optionList);
                Console.Write(decisionPrompt);
                int choice = convenient.Read32BitNumberInput();
                // Set up some prompt strings.
                string bitShiftPrompt = "Please enter the amount of bits to shift by: ";
                // Execute
                switch (choice)
                {
                    case 0:     // Addition
                        // Explains what addition does
                        string additionInfo = "Adds two numbers together.\n";
                        Console.WriteLine(additionInfo);
                        // Prompt the user to input the numbers
                        Console.Write(enterNumberPrompt0);
                        int addX = convenient.Read32BitNumberInput();
                        Console.Write(enterNumberPrompt1);
                        int addY = convenient.Read32BitNumberInput();
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
                        int subtractX = convenient.Read32BitNumberInput();
                        Console.Write(enterNumberPrompt1);
                        int subtractY = convenient.Read32BitNumberInput();
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
                        int multiplyX = convenient.Read32BitNumberInput();
                        Console.Write(enterNumberPrompt1);
                        int multiplyY = convenient.Read32BitNumberInput();
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
                        double divideX = convenient.ReadFloatingPointNumberInput();
                        Console.Write(enterNumberPrompt1);
                        double divideY = convenient.ReadFloatingPointNumberInput();
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
                        int moduloX = convenient.Read32BitNumberInput();
                        Console.Write(enterNumberPrompt1);
                        int moduloY = convenient.Read32BitNumberInput();
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
                        int sumX = convenient.Read32BitNumberInput();
                        // Calculate the sum and print the result
                        int sumResult = nijimath.Summation(sumX);
                        string equationSummation = $"∑({sumX}) = {sumResult}";
                        Console.WriteLine(equationSummation);
                        break;
                    case 6:     // Exponentiation
                        // Explain what exponentiation
                        string exponentiationInfo = "Raises a number to another. This is a compact way of multiplying a number by itself multiple times.\n";
                        Console.WriteLine(exponentiationInfo);
                        // Prompt the user to input the numbers
                        Console.Write(enterNumberPrompt0);
                        double exponentX = convenient.ReadFloatingPointNumberInput();
                        Console.Write(enterNumberPrompt1);
                        double exponentY = convenient.ReadFloatingPointNumberInput();
                        // Calculate the exponent and print the result
                        double exponentResult = nijimath.Exponentiation(exponentX, exponentY);
                        string equationExponent = $"{exponentX} raised to the power of {exponentY} = {exponentResult}";
                        Console.WriteLine(equationExponent);
                        break;
                    case 7:     // Square roots
                        // Explain what square roots do
                        string squareRootInfo = "Calculates what number, when squared, will output the given number.\n";
                        Console.WriteLine(squareRootInfo);
                        // Prompt the user to input the number
                        Console.Write(enterNumberPrompt0);
                        double squareRootX = convenient.ReadFloatingPointNumberInput();
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
                        double sineX = convenient.ReadFloatingPointNumberInput();
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
                        double cosineX = convenient.ReadFloatingPointNumberInput();
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
                        double tangentX = convenient.ReadFloatingPointNumberInput();
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
                        double natLogX = convenient.ReadFloatingPointNumberInput();
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
                        double base2LogX = convenient.ReadFloatingPointNumberInput();
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
                        double base10LogX = convenient.ReadFloatingPointNumberInput();
                        // Calculate the base 10 logarithm and print the result
                        double base10LogResult = nijimath.Base10Logarithm(base10LogX);
                        string equationBase10Log = $"log₁₀ {base10LogX} = {base10LogResult}";
                        Console.WriteLine(equationBase10Log);
                        break;
                    case 14:    // Average
                        // Explain what averaging does
                        string averageInfo = "Gets the average (mean) of all numbers in a given set/list.\n";
                        Console.WriteLine(averageInfo);
                        // Prompt the user to input the number
                        List<double> numberArray = new List<double>();
                        double averageX = 0.00;
                        // User inputs the numbers that they want to average up until a '0' is inputted
                        do
                        {
                            Console.Write("Please enter a number.\nEnter \"0\" to stop: ");
                            averageX = convenient.ReadFloatingPointNumberInput();
                            numberArray.Add(averageX);
                        } while (averageX != 0) ;
                        // Calculate the base 10 logarithm and print the result
                        double averageResult = nijimath.AverageSum(numberArray);
                        string equationAverage = $"The average of all the numbers you gave is {averageResult}.";
                        Console.WriteLine(equationAverage);
                        break;
                    case 15:    // Temperature
                        Console.WriteLine("Let's convert temperatures! But first...\n");
                        // Setup the choices
                        var temperatureOptions = new Dictionary<int, string>
                        {
                            { 0, "Celsius to Fahrenheit" },
                            { 1, "Celsius to Kelvin" },
                            { 2, "Fahrenheit to Celsius" },
                            { 3, "Fahrenheit to Kelvin" },
                            { 4, "Kelvin to Celsius" },
                            { 5, "Kelvin to Fahrenheit" }
                        };
                        string temperatureOptionList = $"0. {temperatureOptions[0]}\t1. {temperatureOptions[1]}\n2. {temperatureOptions[2]}\t3. {temperatureOptions[3]}\n4. {temperatureOptions[4]}\t\t5. {temperatureOptions[5]}";
                        string temperatureDecisionPrompt = "What do you want to do? (Type the number!) ";
                        // Display choices and receive the user's input on what they want to do
                        Console.WriteLine(temperatureOptionList);
                        Console.WriteLine(temperatureDecisionPrompt);
                        int temperatureChoice = convenient.Read32BitNumberInput();
                        // Input prompt stuffs
                        string celsiusPrompt = "Please type in the temperature in °C: ";
                        string fahrenheitPrompt = "Please type in the temperature in °F: ";
                        string kelvinPrompt = "Please type in the temperature in kelvin: ";
                        double temperature = 0.00d;
                        double resultTemperature = 0.0000d;
                        // Execute based on user's choice
                        switch (temperatureChoice)
                        {
                            case 0:    // Celsius to Fahrenheit
                                Console.Write(celsiusPrompt);
                                temperature = convenient.ReadFloatingPointNumberInput();
                                resultTemperature = nijimath.CelsiusToFahrenheit(temperature);
                                Console.WriteLine($"{temperature} °C ≈ {resultTemperature} °F");
                                break;
                            case 1:    // Celsius to Kelvin
                                Console.Write(celsiusPrompt);
                                temperature = convenient.ReadFloatingPointNumberInput();
                                resultTemperature = nijimath.CelsiusToKelvin(temperature);
                                Console.WriteLine($"{temperature} °C ≈ {resultTemperature} K");
                                break;
                            case 2:    // Fahrenheit to Celsius
                                Console.Write(fahrenheitPrompt);
                                temperature = convenient.ReadFloatingPointNumberInput();
                                resultTemperature = nijimath.FahrenheitToCelsius(temperature);
                                Console.WriteLine($"{temperature} °F ≈ {resultTemperature} °C");
                                break;
                            case 3:    // Fahrenheit to Kelvin
                                Console.Write(fahrenheitPrompt);
                                temperature = convenient.ReadFloatingPointNumberInput();
                                resultTemperature = nijimath.FahrenheitToKelvin(temperature);
                                Console.WriteLine($"{temperature} °F ≈ {resultTemperature} K");
                                break;
                            case 4:    // Kelvin to Celsius
                                Console.Write(kelvinPrompt);
                                temperature = convenient.ReadFloatingPointNumberInput();
                                resultTemperature = nijimath.KelvinToCelsius(temperature);
                                Console.WriteLine($"{temperature} K ≈ {resultTemperature} °C");
                                break;
                            case 5:    // Kelvin to Fahrenheit
                                Console.Write(kelvinPrompt);
                                temperature = convenient.ReadFloatingPointNumberInput();
                                resultTemperature = nijimath.KelvinToFahrenheit(temperature);
                                Console.WriteLine($"{temperature} K ≈ {resultTemperature} °F");
                                break;
                            default:    // Out of bounds
                                Console.WriteLine(outOfBoundsMsg0);
                                Console.WriteLine(outOfBoundsMsg1);
                                break;
                            // End of switch block
                        }
                        break;
                    case 16:    // Bit shift left
                        // Explain what shifting a bit to the left does
                        string bitShiftLeftInfo = "Takes a number and shifts its value left by the specified number of bits.\n";
                        Console.WriteLine(bitShiftLeftInfo);
                        // Prompt the user to input the numbers
                        Console.Write(enterNumberPrompt0);
                        uint bitShiftLeftX = convenient.ReadUnsigned32BitNumberInput();
                        Console.Write(bitShiftPrompt);
                        int bitShiftLeftY = convenient.Read32BitNumberInput();
                        // Calculate and print the result
                        uint bitShiftLeftResult = nijimath.BitShiftLeft(bitShiftLeftX, bitShiftLeftY);
                        string equationBitShiftLeft = $"{bitShiftLeftX} << {bitShiftLeftY} = {bitShiftLeftResult}";
                        string bitViewBitShiftLeft = $"Binary: %{Convert.ToString(bitShiftLeftX, toBase: 2).PadLeft(32, '0'),32}\n      = %{Convert.ToString(bitShiftLeftResult, toBase: 2).PadLeft(32, '0'),32}";
                        Console.WriteLine(equationBitShiftLeft);
                        Console.WriteLine(bitViewBitShiftLeft);
                        break;
                    case 17:    // Bit shift right
                        // Explain what shifting a bit to the right does
                        string bitShiftRightInfo = "Takes a number and shifts its value right by the specified number of bits.\n";
                        Console.WriteLine(bitShiftRightInfo);
                        // Prompt the user to input the numbers
                        Console.Write(enterNumberPrompt0);
                        uint bitShiftRightX = convenient.ReadUnsigned32BitNumberInput();
                        Console.Write(bitShiftPrompt);
                        int bitShiftRightY = convenient.Read32BitNumberInput();
                        // Calculate and print the result
                        uint bitShiftRightResult = nijimath.BitShiftLeft(bitShiftRightX, bitShiftRightY);
                        string equationBitShiftRight = $"{bitShiftRightX} >> {bitShiftRightY} = {bitShiftRightResult}";
                        string bitViewBitShiftRight = $"Binary:\n  %{Convert.ToString(bitShiftRightX, toBase: 2).PadLeft(32, '0'), 32}\n= %{Convert.ToString(bitShiftRightResult, toBase: 2).PadLeft(32, '0'),32}";
                        Console.WriteLine(equationBitShiftRight);
                        Console.WriteLine(bitViewBitShiftRight);
                        break;
                    case 18:    // Bitwise NOT
                        // Explain what bitwise NOT does
                        string bitwiseNOTInfo = "A NOT operation takes all the bits that represent a number and flips them, such that 0's become 1's and vice versa.\n";
                        Console.WriteLine(bitwiseNOTInfo);
                        // Prompt the user to input the number
                        Console.Write(enterNumberPrompt0);
                        uint bitwiseNOTOpX = convenient.ReadUnsigned32BitNumberInput();
                        // Calculate and print the result
                        uint bitwiseNOTOpResult = nijimath.BitwiseNOT(bitwiseNOTOpX);
                        string equationBitwiseNOT = $"NOT {bitwiseNOTOpX} = {bitwiseNOTOpResult}";
                        string bitviewBitwiseNOT = $"Binary:\nNOT %{Convert.ToString(bitwiseNOTOpX, toBase: 2).PadLeft(32, '0'), 32}\n  = %{Convert.ToString(bitwiseNOTOpResult, toBase: 2).PadLeft(32, '0'), 32}";
                        Console.WriteLine(equationBitwiseNOT);
                        Console.WriteLine(bitviewBitwiseNOT);
                        break;
                    case 19:    // Bitwise AND
                        // Explain what bitwise AND does
                        string bitwiseANDInfo = "\n";
                        Console.WriteLine(bitwiseANDInfo);
                        // Prompt the user to input the numbers
                        Console.Write(enterNumberPrompt0);
                        uint bitwiseANDOpX = convenient.ReadUnsigned32BitNumberInput();
                        Console.Write(enterNumberPrompt1);
                        int bitwiseANDOpY = convenient.Read32BitNumberInput();
                        // Calculate and print the result
                        uint bitwiseANDOpResult = nijimath.BitwiseAND(bitwiseANDOpX, bitwiseANDOpY);
                        string equationBitwiseAND = $"{bitwiseANDOpX} AND {bitwiseANDOpY} = {bitwiseANDOpResult}";
                        string bitviewBitwiseAND = $"Binary:\n    %{Convert.ToString(bitwiseANDOpX, toBase: 2).PadLeft(32, '0'),32}\nAND %{Convert.ToString(bitwiseANDOpY, toBase: 2).PadLeft(32, '0'),32}\n  = %{Convert.ToString(bitwiseANDOpResult, toBase: 2).PadLeft(32, '0'),32}";
                        Console.WriteLine(equationBitwiseAND);
                        Console.WriteLine(bitviewBitwiseAND);
                        break;
                    case 20:    // Bitwise OR
                        // Explain what bitwise OR does
                        string bitwiseORInfo = "\n";
                        Console.WriteLine(bitwiseORInfo);
                        // Prompt the user to input the numbers
                        Console.Write(enterNumberPrompt0);
                        uint bitwiseOROpX = convenient.ReadUnsigned32BitNumberInput();
                        Console.Write(enterNumberPrompt1);
                        int bitwiseOROpY = convenient.Read32BitNumberInput();
                        // Calculate and print the result
                        uint bitwiseOROpResult = nijimath.BitwiseOR(bitwiseOROpX, bitwiseOROpY);
                        string equationBitwiseOR = $"{bitwiseOROpX} OR {bitwiseOROpY} = {bitwiseOROpResult}";
                        string bitviewBitwiseOR = $"Binary:\n    %{Convert.ToString(bitwiseOROpX, toBase: 2).PadLeft(32, '0'),32}\n OR %{Convert.ToString(bitwiseOROpY, toBase: 2).PadLeft(32, '0'),32}\n  = %{Convert.ToString(bitwiseOROpResult, toBase: 2).PadLeft(32, '0'),32}";
                        Console.WriteLine(equationBitwiseOR);
                        Console.WriteLine(bitviewBitwiseOR);
                        break;
                    case 21:    // Bitwise XOR
                        // Explain what bitwise exclusive OR (XOR) does
                        string bitwiseXORInfo = "\n";
                        Console.WriteLine(bitwiseXORInfo);
                        // Prompt the user to input the numbers
                        Console.Write(enterNumberPrompt0);
                        uint bitwiseXOROpX = convenient.ReadUnsigned32BitNumberInput();
                        Console.Write(enterNumberPrompt1);
                        int bitwiseXOROpY = convenient.Read32BitNumberInput();
                        // Calculate and print the result
                        uint bitwiseXOROpResult = nijimath.BitwiseXOR(bitwiseXOROpX, bitwiseXOROpY);
                        string equationBitwiseXOR = $"{bitwiseXOROpX} XOR {bitwiseXOROpY} = {bitwiseXOROpResult}";
                        string bitviewBitwiseXOR = $"Binary:\n    %{Convert.ToString(bitwiseXOROpX, toBase: 2).PadLeft(32, '0'),32}\nXOR %{Convert.ToString(bitwiseXOROpY, toBase: 2).PadLeft(32, '0'),32}\n  = %{Convert.ToString(bitwiseXOROpResult, toBase: 2).PadLeft(32, '0'),32}";
                        Console.WriteLine(equationBitwiseXOR);
                        Console.WriteLine(bitviewBitwiseXOR);
                        break;
                    case 22:    // 
                        Console.WriteLine(convenient.NotImplemented);
                        break;
                    case 23:    // 
                        Console.WriteLine(convenient.NotImplemented);
                        break;
                    case 24:    // 
                        Console.WriteLine(convenient.NotImplemented);
                        break;
                    case 25:    // 
                        Console.WriteLine(convenient.NotImplemented);
                        break;
                    case 26:    // 
                        Console.WriteLine(convenient.NotImplemented);
                        break;
                    case 27:    // 
                        Console.WriteLine(convenient.NotImplemented);
                        break;
                    case 28:    // 
                        Console.WriteLine(convenient.NotImplemented);
                        break;
                    case 29:    // 
                        Console.WriteLine(convenient.NotImplemented);
                        break;
                    case 30:    // 
                        Console.WriteLine(convenient.NotImplemented);
                        break;
                    case 31:    // 
                        Console.WriteLine(convenient.NotImplemented);
                        break;
                    default:    // Out of bounds
                        Console.WriteLine(outOfBoundsMsg0);
                        Console.WriteLine(outOfBoundsMsg1);
                        break;
                    // End of switch block
                }
                Console.Write("Continue? [Y/n] ");
                shallIContinue = convenient.ReadCharacterInput();
            } while (shallIContinue != 'N' || shallIContinue != 'n');
            // Sendoff
            Console.WriteLine(sendOffMsg);
            // Exit the program
            return 0;
        }
    }
}

/* >>>>>> END OF FILE <<<<<< */
