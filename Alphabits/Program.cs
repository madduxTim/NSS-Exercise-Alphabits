using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabits
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo enteredKey;         
            Alphas alpha = new Alphas();
            int counter = 1;
            bool winner = false;

            Console.Write("Type all the letters of the alphabet consecutively. Hit Esc if you want to quit.\n");
            do 
            {
                enteredKey = Console.ReadKey();
                string input = enteredKey.Key.ToString().ToLower();

                if (input == alpha.alphabet[counter-1])
                {
                    Console.WriteLine($"\n   Nice! You've gotten {counter} right so far. Keep it up. ");
                    counter += 1;
                    if (input == "z")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n                      Winner winner, chicken dinner.");
                        winner = false;
                    }
                }
                else
                {
                    Console.WriteLine("\n   Lock it up sausage fingers. Time to start over.");
                    counter = 1;
                }
            } while (enteredKey.Key != ConsoleKey.Escape);
        }
    }
}
