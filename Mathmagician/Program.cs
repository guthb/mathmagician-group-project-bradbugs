using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                List<string> commands = new List<string>() { "Integers", "Primes", "Fibonacci", "even", "odd" };
                Console.WriteLine("What would you like for me to do?");
                for (int i = 0; i < commands.Count; i++)
                {
                    Console.WriteLine(commands[i]);
                }
                Console.Write("> ");
                string commandInput = Console.ReadLine();
                Console.WriteLine("How many should I print?");
                Console.Write("> ");
                string listAmountInput = Console.ReadLine();
                int listAmountParsed = Int32.Parse(listAmountInput);

                Console.WriteLine("Cool, I'm going to print {0} {1} numbers.", listAmountInput, commandInput);



                switch (commandInput)
                {
                    case "Integers":
                        Integer my_int = new Integer();
                        List<int> listIntToPrint = my_int.ListIntegers(listAmountParsed);
                        my_int.PrintList(listIntToPrint);
                        break;
                    case "Primes":
                        Primes my_prime = new Primes();
                        List<int> listPrimeToPrint = my_prime.ReturnPrimeNumbersList(listAmountParsed);
                        my_prime.PrintList(listPrimeToPrint);
                        break;
                    case "Fibonacci":
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
                        Console.WriteLine("Whoops!");
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


