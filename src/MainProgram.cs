/* =============================================================================
 * Niji's Calculator
 * =============================================================================
 * 
 * Author: Niji System
 * 
 */

// Built-in namespaces
using System;

// User defined namespaces
using NijiConvenience;

// Main code
namespace NijiCalculator {
    class MainProgram {
        static void Main(string[] args) {
            // Constants
            const char LINE_BREAK = '\n';
            const char BLANK_LINE = ' ';
            const char SINGLE_TAB = '\t';
            const string DOUBLE_TAB = "\t\t";
            // Variables
            char response = ' ';
            string operation = " ";
            // 1D arrays
            string[,] operations = new string[3, 8] {
                {
                    // Preferred
                    "Addition", "Subtraction", "Multiplication", "Division", "Modulus", "#@%$!", "#@%$!", "#@%$!"
                }, {
                    // For the folks that keep CAPS_LOCK 'on' for some reason
                    "ADDITION", "SUBTRACTION", "MULTIPLICATION", "DIVISION", "MODULUS", "#@%$!", "#@%$!", "#@%$!"
                }, {
                    // For those that never capitalise
                    "addition", "subtraction", "multiplication", "division", "modulus", "#@%$!", "#@%$!", "#@%$!"
                }
            };
            // Objects
            Convenience convenience = new Convenience(); // ./NijiConvenience/Convenience.cs
            // Introduction
            Console.WriteLine(SINGLE_TAB + "Niji's Calculator");
            Console.WriteLine(DOUBLE_TAB + "By Niji System");
            Console.WriteLine(BLANK_LINE);
            Console.WriteLine("This is a calculator written in C#.");
            // The main calculator part :3
            do {
                // Math variables
                long x = 1;
                long y = 1;
                double yDivide = 1.000000000000000;
                Console.WriteLine("What operation would you like to perform?");
                Console.WriteLine("Your current options are:");
                // List of available operations
                Console.WriteLine(operations[0, 0] + SINGLE_TAB + operations[0, 1] + SINGLE_TAB + operations[0, 2] + LINE_BREAK + operations[0, 3] + SINGLE_TAB + operations[0, 4] + DOUBLE_TAB + "Exit");
                // Retrieve user input
                Console.Write("Please enter your selection: ");
                operation = Console.ReadLine();
                // Check against the available operations
                if (operation == operations[0, 0] || operation == operations[1, 0] || operation == operations[2, 0]) {
                    /* <3 `Addition' <3 */
                    Console.WriteLine("You chose " + operations[2, 0] + ".");
                    // Initialise variables
                    long sum = 0;
                    // Explanation
                    Console.WriteLine("Addition adds two numbers together.");
                    // Grab user input
                    Console.Write("Please enter a number (no decimals please): ");
                    x = convenience.Input64BitInteger();
                    Console.Write("Please enter a second number (again, no decimals please): ");
                    y = convenience.Input64BitInteger();
                    // Calculate the sum
                    sum = x + y;
                    Console.WriteLine("Your sum is " + sum + ".");
                } else if (operation == operations[0, 1] || operation == operations[1, 1] || operation == operations[2, 1]) {
                    /* <3 `Subtraction' <3 */
                    Console.WriteLine("You chose " + operations[2, 1] + ".");
                    // Initialise variables
                    long difference = 0;
                    // Explanation
                    Console.WriteLine("Subtraction subtracts one number from another.");
                    // Grab user input
                    Console.Write("Please enter a number (no decimals please): ");
                    x = convenience.Input64BitInteger();
                    Console.Write("Please enter the amount to take away (again, no decimals please): ");
                    y = convenience.Input64BitInteger();
                    // Calculate the difference
                    difference = x - y;
                    Console.WriteLine("Your difference is " + difference + ".");
                } else if (operation == operations[0, 2] || operation == operations[1, 2] || operation == operations[2, 2]) {
                    /* <3 `Multiplication' <3 */
                    Console.WriteLine("You chose " + operations[2, 2] + ".");
                    // Initialise variables
                    long product = 0;
                    // Explanation
                    Console.WriteLine("Multiplication multiplies a number by another number.");
                    // Grab user input
                    Console.Write("Please enter a number (no decimals please): ");
                    x = convenience.Input64BitInteger();
                    Console.Write("Please enter the number you want to multiply by (again, no decimals please): ");
                    y = convenience.Input64BitInteger();
                    // Calculate the product
                    product = x * y;
                    Console.WriteLine("Your product is " + product + ".");
                } else if (operation == operations[0, 3] || operation == operations[1, 3] || operation == operations[2, 3]) {
                    /* <3 `Division' <3 */
                    Console.WriteLine("You chose " + operations[2, 3] + ".");
                    // Initialise variables
                    double xDivide = 0.000000000000000;
                    double quotient = 0.000000000000000;
                    // Explanation
                    Console.WriteLine("Division divides one number by another.");
                    // Grab user input
                    Console.Write("Please enter a number: ");
                    xDivide = convenience.InputDouble();
                    Console.Write("Please enter the number you want divide by: ");
                    yDivide = convenience.InputDouble();
                    // Check if the divisor is 0
                    if (yDivide == 0) {
                        // You destroyed the universe...
                        Console.WriteLine("WARNING! USER ATTEMPTED TO DIVIDE BY ZERO!");
                        Console.WriteLine("...");
                        Console.WriteLine("Are you happy with yourself?");
                        Console.WriteLine("You just destroyed the entire universe by creating a singularity.");
                        goto DividedByZero;
                    } else if (yDivide != 0) {
                        // Calculate the quotient
                        quotient = xDivide / yDivide;
                        Console.WriteLine("Your quotient is " + quotient + ".");
                    }
                } else if (operation == operations[0, 4] || operation == operations[1, 4] || operation == operations[2, 4]) {
                    /* <3 `Modulus' <3 */
                    Console.WriteLine("You chose " + operations[2, 4] + ".");
                    // Initialise variables
                    long remainder = 0;
                    // Explanation
                    Console.WriteLine("Modulus takes the remainder from a division operation.");
                    // Grab user input
                    Console.Write("Please enter a number (no decimals please): ");
                    x = convenience.Input64BitInteger();
                    Console.Write("Please enter the number you want to divide by (again, no decimals please): ");
                    y = convenience.Input64BitInteger();
                    // Check if the divisor is 0
                    if (y == 0) {
                        // You destroyed the universe...
                        Console.WriteLine("WARNING! USER ATTEMPTED TO DIVIDE BY ZERO!");
                        Console.WriteLine("...");
                        Console.WriteLine("Are you happy with yourself?");
                        Console.WriteLine("You just destroyed the entire universe by creating a singularity.");
                        goto DividedByZero;
                    } else if (y != 0) {
                        // Retrieve the remainder
                        remainder = x % y;
                        Console.WriteLine("The remainder from " + x + " divided by " + y + " is " + remainder + ".");
                    }
                } else if (operation == "Exit" || operation == "EXIT" || operation == "exit") {
                    /* <3 `Exit' <3 */
                    Console.WriteLine("Exiting the calculator...");
                    break;
                } else {
                    /* <3 Invalid input <3 */
                    Console.WriteLine(operations[0, 7]); // #@%$!
                }
                DividedByZero:
                    if (yDivide == 0 || y == 0) {
                        Console.WriteLine("*ugh*");
                        Console.WriteLine("I'll restore the universe back to how it was.");
                        Console.WriteLine("Next time, DON'T DIVIDE BY ZERO!");
                    }
                /* oreZyBdediviD */
                // Ask the user what they want to do
                Console.Write("Would you like to perform another operation? [Y/n] ");
                response = convenience.InputCharacter();
            } while (response == 'Y' || response == 'y');
            // Sendoff
            if (response == 'N' || response == 'n') {
                Console.WriteLine("Have a nice day!");
            } else if (operation == "Exit" || operation == "EXIT" || operation == "exit") {
                Console.WriteLine("Hope you have a nice day, then.");
            } else {
                Console.WriteLine("Maybe hit your `n' or `y' key next time.");
                Console.WriteLine("Anyway, have a nice day.");
            }
        }
    }
}
