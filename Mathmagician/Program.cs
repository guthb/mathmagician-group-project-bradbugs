using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathmagician.Extras;

namespace Mathmagician
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduce Math Wizard.
            Console.WriteLine(ASCII.Wizard());
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Greetings. I am the math wizard. Give me the ingredients and I will concoct a splendid list of numbers for you.");
            Console.WriteLine("If you would like to quit at any time, simply tell me to 'shut up'.");
            Console.ResetColor();


            //List of possible commands for users.
            List<string> commands = new List<string>() { "Integers", "Primes", "Fibonacci", "even", "odd" };

            //Repeats until user quits.
            bool running = true;
            while (running)
            {
                
                //Ask user what they would like to do, then possible commands.
                Console.WriteLine("What would you like for me to do?");
                for (int i = 0; i < commands.Count; i++)
                {
                    Console.WriteLine(commands[i] );
                }

                //Prompt user for command input.
                Console.Write("> ");
                string commandInput = Console.ReadLine();
                if (commandInput == "shut up")
                {
                    Environment.Exit(0);
                }

                //Prompt user for iteration input.
                bool responseUnverified = true;
                string listAmountInput = "";
                int listAmountParsed = 0;
                while (responseUnverified)
                {
                    Console.WriteLine("How many should I print?");
                    Console.Write("> ");
                    listAmountInput = Console.ReadLine();

                    //Checks to see if user entered valid number, if they instruct to quit, then exit loop and close program, if not, then throw error and repeat instruction.
                    if (Int32.TryParse(listAmountInput, out listAmountParsed))
                    {
                        responseUnverified = false;
                    }
                    else
                    {
                        if (listAmountInput.ToLower() == "shut up")
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Enter a valid number, fool.");
                            Console.ResetColor();
                        }
                    }
                }
                

                //All valid responses.
                Console.WriteLine("Cool, I'm going to print {0} {1} numbers.", listAmountInput, commandInput);

                //Decide which list to print based on user command selection.
                switch (commandInput.ToLower())
                {
                    case "integers":
                        Integer my_int = new Integer();
                        List<int> listIntToPrint = my_int.ListIntegers(listAmountParsed);
                        my_int.PrintList(listIntToPrint);
                        break;
                    case "primes":
                        Primes my_prime = new Primes();
                        List<int> listPrimeToPrint = my_prime.ReturnPrimeNumbersList(listAmountParsed);
                        my_prime.PrintList(listPrimeToPrint);
                        break;
                    case "fibonacci":
                        Fibonacci my_fib = new Fibonacci();
                        List<int> listFibToPrint = my_fib.ReturnFibonacciSequence(listAmountParsed);
                        my_fib.PrintList(listFibToPrint);
                        break;
                    case "even":
                        Even my_even = new Even();
                        List<int> listEvenToPrint = my_even.ReturnEvenNumbersList(listAmountParsed);
                        my_even.PrintList(listEvenToPrint);
                        break;
                    case "odd":
                        Console.WriteLine("Under Construction");
                        break;
                    default:
                        Console.WriteLine("Whoops.");
                        break;
                }
            }
        }
    }
}


//What would you like for me to do?
//User enters a command, then presses enter. > How many should I print?
//User enters how many numbers should be printed. > Cool, I'm going to print [some amount] [some command] numbers.
//If an unknown command is entered, then the Mathmagician will say, "Whoops!".


