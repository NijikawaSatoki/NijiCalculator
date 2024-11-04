/* =============================================================================
 * Niji's Calculator
 * =============================================================================
 * 
 * Author: Niji System
 * 
 */

// Built-in namespaces
using System;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;

// User defined namespaces
using NijiConvenience;

// Main code
namespace NijiCalculator {
    class MainProgram {
        // Public constants
        public const string HEADING_OUTPUT = "[ HEAD ]    ";
        public const string LOG_OUTPUT = "[ LOG  ]    ";
        public const string OUTPUT = "[ OUT  ]    ";
        public const string MATH_OUTPUT = "[ MATH ]    ";
        // The main code
        static void Main(string[] args) {
            // Force UTF-8 encoding, since C# doesn't seem to do it right :(
            Console.OutputEncoding = Encoding.UTF8;

            // Check the operating system (OS)
            char directorySeparator = '/';
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
                directorySeparator = '\\';
            } else {
                directorySeparator = '/';
            }

            // Constants
            const char LINE_BREAK = '\n';
            const char BLANK_LINE = '\u3000';
            const char SINGLE_TAB = '\t';
            const string DOUBLE_TAB = "\t\t";
            
            // Variables
            char response = '\u3000';
            string operation = "\u3000";
            
            // 1D arrays
            string[,] operations = new string[3, 8] {
                {
                    // Preferred
                    "Addition", "Subtraction", "Multiplication", "Division", "Modulus", "Exponent", "Square", "Cube"
                }, {
                    // For the folks that keep CAPS_LOCK 'on' for some reason
                    "ADDITION", "SUBTRACTION", "MULTIPLICATION", "DIVISION", "MODULUS", "EXPONENT", "SQUARE", "CUBE"
                }, {
                    // For those that never capitalise
                    "addition", "subtraction", "multiplication", "division", "modulus", "exponent", "square", "cube"
                }
            };
            
            // Objects
            Convenience convenience = new Convenience(); // ./NijiConvenience/Convenience.cs
            Calculate calculate = new Calculate(); // ./NijiCalculator/Calculate.cs

            // Create output file and set path
            convenience.CreateOutput("v1.1.0-test-0f");

            string version = "v1.1.0-test-0f";
            string appDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string outputFile = $@"Calculator_Output-{version}.txt";
            string dataDirectory = @"NijiCalculator";

            string path = $@"{appDataDirectory}{directorySeparator}{dataDirectory}{directorySeparator}{outputFile}";

            // Overwrite the previous output
            using (StreamWriter startAnew = new StreamWriter(path, false)) {
                startAnew.WriteLine($"{HEADING_OUTPUT}\t\t\tDO NOT EDIT THIS FILE!");
                startAnew.WriteLine($"{HEADING_OUTPUT}\t\tThis file simply logs the output.");
                startAnew.WriteLine($"{HEADING_OUTPUT}This will be generated automatically by the calculator.");
                startAnew.WriteLine($"{HEADING_OUTPUT}");
                startAnew.WriteLine($"{HEADING_OUTPUT}Staring output...");
                startAnew.WriteLine($"{HEADING_OUTPUT}");
                startAnew.WriteLine($"{HEADING_OUTPUT}");
                startAnew.WriteLine($"{HEADING_OUTPUT}");
            }

            // Start a new output stream
            TextWriter calculatorOutput = new StreamWriter(path, true);

            // Write the variable declarations to the output file
            calculatorOutput.WriteLine($@"{LOG_OUTPUT}Constant `LINE_BREAK' has been set to `\n'.");
            calculatorOutput.WriteLine($@"{LOG_OUTPUT}Constant `BLANK_LINE' has been set to `\u3000' (Ideographic Space).");
            calculatorOutput.WriteLine($@"{LOG_OUTPUT}Constant `SINGLE_TAB' has been set to `\t'.");
            calculatorOutput.WriteLine($@"{LOG_OUTPUT}Constant `DOUBLE_TAB' has been set to `\t\t'.");
            calculatorOutput.WriteLine($@"{LOG_OUTPUT}Variable `response' has been set to `\u3000' (Ideographic Space).");
            calculatorOutput.WriteLine($@"{LOG_OUTPUT}Variable `operation' has been set to `\u3000' (Ideographic Space).");
            calculatorOutput.WriteLine($"{LOG_OUTPUT}Array `operations' has been declared as 2-dimensional, 3 rows, 8 columns. It's values are as follows:");
            calculatorOutput.WriteLine($"{LOG_OUTPUT}Addition\tSubtraction\tMultiplication\tDivision\tModulus\tExponent\tSquare\tCube");
            calculatorOutput.WriteLine($"{LOG_OUTPUT}ADDITION\tSUBTRACTION\tMULTIPLICATION\tDIVISION\tMODULUS\tEXPONENT\tSQUARE\tCUBE");
            calculatorOutput.WriteLine($"{LOG_OUTPUT}addition\tsubtraction\tmultiplication\tdivision\tmodulus\texponent\tsquare\tcube");

            // Introduction
            Console.WriteLine($"{SINGLE_TAB}\"Niji's Calculator\"");
            calculatorOutput.WriteLine($"{OUTPUT}{SINGLE_TAB}\"Niji's Calculator\"");
            Console.WriteLine($"{DOUBLE_TAB}By Niji System");
            calculatorOutput.WriteLine($"{OUTPUT}{DOUBLE_TAB}By Niji System");
            calculatorOutput.WriteLine($"{OUTPUT}{DOUBLE_TAB}Version 1.1.0-test-0f");
            Console.WriteLine(BLANK_LINE);
            calculatorOutput.WriteLine($"{OUTPUT}");
            Console.WriteLine("This is a calculator written in C#.");
            calculatorOutput.WriteLine($"{OUTPUT}This is a calculator written in C#.");
            Console.WriteLine($"Your output file will be located at {path}!");
            calculatorOutput.WriteLine($"{OUTPUT}Your output file will be located at {path}!");

            // The main calculator part :3
            do {
                // Math variables
                long x = 0;
                calculatorOutput.WriteLine($"{LOG_OUTPUT}Variable `x' has been set to `{x}'.");
                long y = 0;
                calculatorOutput.WriteLine($"{LOG_OUTPUT}Variable `y' has been set to `{y}'.");
                double yDivide = 0.000000000000000;
                calculatorOutput.WriteLine($"{LOG_OUTPUT}Variable `yDivide' has been set to `{yDivide}'.");

                // This controls whether or not the DividedByZero code runs.
                bool divideByZero = false;
                calculatorOutput.WriteLine($"{LOG_OUTPUT}Variable `divideByZero' has been set to `{divideByZero}'.");
                Console.WriteLine("What operation would you like to perform?");
                calculatorOutput.WriteLine($"{OUTPUT}What operation would you like to perform?");
                Console.WriteLine("Your current options are:");
                calculatorOutput.WriteLine($"{OUTPUT}Your current options are:");

                // List of available operations
                Console.WriteLine($"{operations[0, 0]}{SINGLE_TAB}{operations[0, 1]}{SINGLE_TAB}{operations[0, 2]}{LINE_BREAK}{operations[0, 3]}{SINGLE_TAB}{operations[0, 4]}{DOUBLE_TAB}{operations[0, 5]}{LINE_BREAK}{operations[0, 6]}{DOUBLE_TAB}{operations[0, 7]}{DOUBLE_TAB}Exit");
                calculatorOutput.WriteLine($"{OUTPUT}{operations[0, 0]}{SINGLE_TAB}{operations[0, 1]}{SINGLE_TAB}{operations[0, 2]}{LINE_BREAK}{OUTPUT}{operations[0, 3]}{SINGLE_TAB}{operations[0, 4]}{DOUBLE_TAB}{operations[0, 5]}{LINE_BREAK}{OUTPUT}{operations[0, 6]}{DOUBLE_TAB}{operations[0, 7]}{DOUBLE_TAB}Exit");

                // Retrieve user input
                Console.WriteLine("Please enter your selection: ");
                operation = Console.ReadLine();
                calculatorOutput.WriteLine($"{OUTPUT}Please enter your selection: {operation}");
                calculatorOutput.WriteLine($"{LOG_OUTPUT}Variable `operation' has been set to `{operation}'.");
                
                // Check against the available operations
                if (operation == operations[0, 0] || operation == operations[1, 0] || operation == operations[2, 0]) {
                    /* <3 `Addition' <3 */
                    Console.WriteLine($"You chose {operations[2, 0]}.");
                    calculatorOutput.WriteLine($"{OUTPUT}You chose {operations[2, 0]}.");
                    
                    // Initialise variables
                    long sum = 0;
                    calculatorOutput.WriteLine($"{LOG_OUTPUT}Variable `sum' has been set to `{sum}'.");
                    
                    // Explanation
                    Console.WriteLine("Addition adds two numbers together.");
                    calculatorOutput.WriteLine($"{OUTPUT}Addition adds two numbers together.");
                    
                    // Grab user input
                    Console.WriteLine("Please enter a number (no decimals please): ");
                    x = convenience.Input64BitInteger();
                    calculatorOutput.WriteLine($"{OUTPUT}Please enter a number (no decimals please): {x}");
                    calculatorOutput.WriteLine($"{LOG_OUTPUT}Variable `x' has been set to `{x}'.");
                    Console.WriteLine("Please enter a second number (again, no decimals please): ");
                    y = convenience.Input64BitInteger();
                    calculatorOutput.WriteLine($"{OUTPUT}Please enter a second number (again, no decimals please): {y}.");
                    calculatorOutput.WriteLine($"{LOG_OUTPUT}Variable `y' has been set to `{y}'.");
                    
                    // Calculate the sum
                    sum = calculate.Add(x, y);
                    calculatorOutput.WriteLine($"{MATH_OUTPUT}{x} + {y} = {sum}");
                    calculatorOutput.WriteLine($"{LOG_OUTPUT}Variable `sum' has been set to `{sum}'.");
                    Console.WriteLine($"Your sum is {sum}.");
                    calculatorOutput.WriteLine($"{OUTPUT}Your sum is {sum}.");
                } else if (operation == operations[0, 1] || operation == operations[1, 1] || operation == operations[2, 1]) {
                    /* <3 `Subtraction' <3 */
                    Console.WriteLine($"You chose {operations[2, 1]}.");
                    calculatorOutput.WriteLine($"{OUTPUT}You chose {operations[2, 1]}.");
                    
                    // Initialise variables
                    long difference = 0;
                    calculatorOutput.WriteLine($"{LOG_OUTPUT}Variable `difference' has been set to {difference}.");
                    
                    // Explanation
                    Console.WriteLine("Subtraction subtracts one number from another.");
                    calculatorOutput.WriteLine($"{OUTPUT}Subtraction subtracts one number from another.");
                    
                    // Grab user input
                    Console.WriteLine("Please enter a number (no decimals please): ");
                    x = convenience.Input64BitInteger();
                    calculatorOutput.WriteLine($"{OUTPUT}Please enter a number (no decimals please): {x}");
                    calculatorOutput.WriteLine($"{LOG_OUTPUT}Variable `x' has been set to {x}.");
                    Console.WriteLine("Please enter the amount to take away (again, no decimals please): ");
                    y = convenience.Input64BitInteger();
                    calculatorOutput.WriteLine($"{OUTPUT}Please enter a number (no decimals please): {y}");
                    calculatorOutput.WriteLine($"{LOG_OUTPUT}Variable `y' has been set to {y}.");

                    // Calculate the difference
                    difference = calculate.Subtract(x, y);
                    calculatorOutput.WriteLine($"{MATH_OUTPUT}{x} - {y} = {difference}");
                    calculatorOutput.WriteLine($"{LOG_OUTPUT}Variable `difference' has been set to `{difference}'.");
                    Console.WriteLine($"Your difference is {difference}.");
                    calculatorOutput.WriteLine($"{OUTPUT}Your difference is {difference}.");
                } else if (operation == operations[0, 2] || operation == operations[1, 2] || operation == operations[2, 2]) {
                    /* <3 `Multiplication' <3 */
                    Console.WriteLine($"You chose {operations[2, 2]}.");
                    calculatorOutput.WriteLine($"{OUTPUT}You chose {operations[2, 2]}.");
                    
                    // Initialise variables
                    long product = 0;
                    
                    // Explanation
                    Console.WriteLine("Multiplication multiplies a number by another number.");
                    calculatorOutput.WriteLine($"{OUTPUT}Multiplication multiplies a number by another number.");
                    
                    // Grab user input
                    Console.WriteLine("Please enter a number (no decimals please): ");
                    x = convenience.Input64BitInteger();
                    calculatorOutput.WriteLine($"{OUTPUT}Please enter a number (no decimals please): {x}");
                    calculatorOutput.WriteLine($"{LOG_OUTPUT}Variable `x' has been set to `{x}'.");
                    Console.WriteLine("Please enter the number you want to multiply by (again, no decimals please): ");
                    y = convenience.Input64BitInteger();
                    calculatorOutput.WriteLine($"{OUTPUT}Please enter the number you want to multiply by (again, no decimals please): {y}");
                    calculatorOutput.WriteLine($"{LOG_OUTPUT}Variable `y' has been set to `{y}'.");
                    
                    // Calculate the product
                    product = calculate.Multiply(x, y);
                    calculatorOutput.WriteLine($"{MATH_OUTPUT}{x} × {y} = {product}");
                    calculatorOutput.WriteLine($"{LOG_OUTPUT}Variable `product' has been set to `{product}'.");
                    Console.WriteLine($"Your product is {product}.");
                    calculatorOutput.WriteLine($"{OUTPUT}Your product is {product}.");
                } else if (operation == operations[0, 3] || operation == operations[1, 3] || operation == operations[2, 3]) {
                    /* <3 `Division' <3 */
                    Console.WriteLine($"You chose {operations[2, 3]}.");
                    calculatorOutput.WriteLine($"{OUTPUT}You chose {operations[2, 3]}.");
                    
                    // Initialise variables
                    double xDivide = 0.000000000000000;
                    calculatorOutput.WriteLine($"{LOG_OUTPUT}Variable `xDivide' has been set to `{xDivide}'.");
                    double quotient = 0.000000000000000;
                    calculatorOutput.WriteLine($"{LOG_OUTPUT}Variable `quotient' has been set to `{quotient}'.");
                    
                    // Explanation
                    Console.WriteLine("Division divides one number by another.");
                    calculatorOutput.WriteLine($"{OUTPUT}Division divides one number by another.");
                    
                    // Grab user input
                    Console.WriteLine("Please enter a number: ");
                    xDivide = convenience.InputDouble();
                    calculatorOutput.WriteLine($"{OUTPUT}Please enter a number: {xDivide}");
                    calculatorOutput.WriteLine($"{LOG_OUTPUT}Variable `xDivide' has been set to `{xDivide}'.");
                    Console.WriteLine("Please enter the number you want divide by: ");
                    yDivide = convenience.InputDouble();
                    calculatorOutput.WriteLine($"{OUTPUT}Please enter the number you want divide by: {yDivide}");
                    calculatorOutput.WriteLine($"{LOG_OUTPUT}Variable `yDivide' has been set to `{yDivide}'.");
                    
                    // Check if the divisor is 0
                    if (yDivide == 0) {
                        divideByZero = true;
                        calculatorOutput.WriteLine($"{LOG_OUTPUT}Variable `divideByZero' has been set to `{divideByZero}'.");
                        // You destroyed the universe...
                        Console.WriteLine("WARNING! USER ATTEMPTED TO DIVIDE BY ZERO!");
                        calculatorOutput.WriteLine($"{OUTPUT}WARNING! USER ATTEMPTED TO DIVIDE BY ZERO!");
                        Console.WriteLine("...");
                        calculatorOutput.WriteLine($"{OUTPUT}...");
                        Console.WriteLine("Are you happy with yourself?");
                        calculatorOutput.WriteLine($"{OUTPUT}Are you happy with yourself?");
                        Console.WriteLine("You just destroyed the entire universe by creating a singularity.");
                        calculatorOutput.WriteLine($"{OUTPUT}You just destroyed the entire universe by creating a singularity.");
                        goto DividedByZero;
                    } else if (yDivide != 0) {
                        // Calculate the quotient
                        quotient = calculate.Divide(xDivide, yDivide);
                        calculatorOutput.WriteLine($"{MATH_OUTPUT}{xDivide} ÷ {yDivide} = {quotient}");
                        calculatorOutput.WriteLine($"{LOG_OUTPUT}Variable `quotient' has been set to `{quotient}'.");
                        Console.WriteLine($"Your quotient is {quotient}.");
                        calculatorOutput.WriteLine($"{OUTPUT}Your quotient is {quotient}.");
                    }
                } else if (operation == operations[0, 4] || operation == operations[1, 4] || operation == operations[2, 4]) {
                    /* <3 `Modulus' <3 */
                    Console.WriteLine($"You chose {operations[2, 4]}.");
                    calculatorOutput.WriteLine($"{OUTPUT}You chose {operations[2, 4]}.");
                    
                    // Initialise variables
                    long remainder = 0;
                    calculatorOutput.WriteLine($"{LOG_OUTPUT}Variable `remainder' has been set to `{remainder}'.");
                    
                    // Explanation
                    Console.WriteLine("Modulus takes the remainder from a division operation.");
                    calculatorOutput.WriteLine($"{OUTPUT}Modulus takes the remainder from a division operation.");
                    
                    // Grab user input
                    Console.WriteLine("Please enter a number (no decimals please): ");
                    x = convenience.Input64BitInteger();
                    calculatorOutput.WriteLine($"{OUTPUT}Please enter a number (no decimals please): {x}");
                    calculatorOutput.WriteLine($"{LOG_OUTPUT}Variable `x' has been set to `{x}'.");
                    Console.WriteLine("Please enter the number you want to divide by (again, no decimals please): ");
                    y = convenience.Input64BitInteger();
                    calculatorOutput.WriteLine($"{OUTPUT}Please enter a number (no decimals please): {y}");
                    calculatorOutput.WriteLine($"{LOG_OUTPUT}Variable `y' has been set to `{y}'.");

                    // Check if the divisor is 0
                    if (y == 0) {
                        divideByZero = true;
                        calculatorOutput.WriteLine($"{LOG_OUTPUT}Variable `divideByZero' has been set to `{divideByZero}'.");
                        // You destroyed the universe...
                        Console.WriteLine("WARNING! USER ATTEMPTED TO DIVIDE BY ZERO!");
                        calculatorOutput.WriteLine($"{OUTPUT}WARNING! USER ATTEMPTED TO DIVIDE BY ZERO!");
                        Console.WriteLine("...");
                        calculatorOutput.WriteLine($"{OUTPUT}...");
                        Console.WriteLine("Are you happy with yourself?");
                        calculatorOutput.WriteLine($"{OUTPUT}Are you happy with yourself?");
                        Console.WriteLine("You just destroyed the entire universe by creating a singularity.");
                        calculatorOutput.WriteLine($"{OUTPUT}You just destroyed the entire universe by creating a singularity.");
                        goto DividedByZero;
                    } else if (y != 0) {
                        // Retrieve the remainder
                        remainder = calculate.Modulo(x, y);
                        calculatorOutput.WriteLine($"{MATH_OUTPUT}{x} mod {y} = {remainder}");
                        calculatorOutput.WriteLine($"{LOG_OUTPUT}Variable `remainder' has been set to `{remainder}'.");
                        Console.WriteLine($"The remainder from {x} divided by {y} is {remainder}.");
                        calculatorOutput.WriteLine($"{OUTPUT}The remainder from {x} divided by {y} is {remainder}.");
                    }
                } else if (operation == operations[0, 5] || operation == operations[1, 5] || operation == operations[2, 5]) {
                    /* <3 `nth Power Exponent' <3 */
                    Console.WriteLine($"You chose {operations[2, 5]}.");
                    
                    // Initialise variables
                    double exponentBase = 1.00;
                    double exponentPower = 0.00;
                    double powerResult = 1.00;
                    
                    // Explanation
                    Console.WriteLine("Exponents simply denoted a number being multiplied by itself x amount of times.");
                    
                    // Grab user input
                    Console.WriteLine("Please enter your base: ");
                    exponentBase = convenience.InputDouble();
                    Console.WriteLine("Please enter your exponent: ");
                    exponentPower = convenience.InputDouble();
                    
                    // Calculate the result
                    powerResult = calculate.NthPower(exponentBase, exponentPower);
                    Console.WriteLine($"{exponentBase} to the power of {exponentPower} results in {powerResult}.");
                } else if (operation == operations[0, 6] || operation == operations[1, 6] || operation == operations[2, 6]) {
                    /* <3 `Square' <3 */
                    Console.WriteLine($"You chose {operations[2, 6]}.");
                    
                    // Initialise variables
                    double squareBase = 1.00;
                    double square = 0.00;
                    
                    // Explanation
                    Console.WriteLine("Squaring is multiplying a number by itself once, e.g. 3² = 3×3.");
                    
                    // Grab user input
                    Console.WriteLine("Please enter your base: ");
                    squareBase = convenience.InputDouble();
                    
                    // Calculate the square
                    square = calculate.Square(squareBase);
                    Console.WriteLine($"Your square is {square}.");
                } else if (operation == operations[0, 7] || operation == operations[1, 7] || operation == operations[2, 7]) {
                    /* <3 `Cube' <3 */
                    Console.WriteLine($"You chose {operations[2, 7]}.");

                    // Initialise variables
                    double cubeBase = 1.00;
                    double cube = 0.00;

                    // Explanation
                    Console.WriteLine("Cubing is multiplying a number by itself twice, e.g. 3³ = 3×3×3");

                    // Grab user input
                    Console.WriteLine("Please enter your base: ");
                    cubeBase = convenience.InputDouble();

                    // Calculate the cube
                    cube = calculate.Cube(cubeBase);
                    Console.WriteLine($"Your cube is {cube}.");
                } else if (operation == "Exit" || operation == "EXIT" || operation == "exit") {
                    /* <3 `Exit' <3 */
                    Console.WriteLine("Exiting the calculator...");
                    calculatorOutput.WriteLine($"{OUTPUT}Exiting the calculator...");
                    break;
                } else {
                    /* <3 Invalid input <3 */
                    Console.WriteLine("#@%$!"); // #@%$!
                    calculatorOutput.WriteLine($"{OUTPUT}#@%$!");
                }
                
                DividedByZero:
                    if (divideByZero == true) {
                        Console.WriteLine("*ugh*");
                        calculatorOutput.WriteLine($"{OUTPUT}*ugh*");
                        Console.WriteLine("I'll restore the universe back to how it was.");
                        calculatorOutput.WriteLine($"{OUTPUT}I'll restore the universe back to how it was.");
                        Console.WriteLine("Next time, DON'T DIVIDE BY ZERO!");
                        calculatorOutput.WriteLine($"{OUTPUT}Next time, DON'T DIVIDE BY ZERO!");
                    }
                /* oreZyBdediviD */
                
                // Ask the user what they want to do
                Console.Write("Would you like to perform another operation? [Y/n] ");
                response = convenience.InputCharacter();
                calculatorOutput.WriteLine($"{OUTPUT}Would you like to perform another operation? [Y/n] {response}");
                calculatorOutput.WriteLine($"{LOG_OUTPUT}Variable `response' has been set to `{response}'.");
            } while (response == 'Y' || response == 'y');
            
            // Sendoff
            if (response == 'N' || response == 'n') {
                Console.WriteLine("Have a nice day!");
                calculatorOutput.WriteLine($"{OUTPUT}Have a nice day!");
            } else if (operation == "Exit" || operation == "EXIT" || operation == "exit") {
                Console.WriteLine("Hope you have a nice day, then.");
                calculatorOutput.WriteLine($"{OUTPUT}Hope you have a nice day, then.");
            } else {
                Console.WriteLine("Maybe hit your `n' or `y' key next time.");
                Console.WriteLine("Anyway, have a nice day.");
                calculatorOutput.WriteLine($"{OUTPUT}Maybe hit your `n' or `y' key next time.");
                calculatorOutput.WriteLine($"{OUTPUT}Anyway, have a nice day.");
            }

            calculatorOutput.Close();
        }
    }
}
