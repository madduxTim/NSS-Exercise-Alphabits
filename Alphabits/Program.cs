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
            //int counter = 1;
            bool winner = false;

            Console.Write("Type all the letters of the alphabet consecutively. Hit Esc if you want to quit.\n");
            do 
            {
                enteredKey = Console.ReadKey();
                alpha.addChar(enteredKey.Key.ToString().ToLower());

                if (alpha.returnChar() == alpha.alphabet[alpha.returnCounter()-1])
                {
                    Console.WriteLine($"\n   Nice! You've gotten {alpha.returnCounter()} right so far. Keep it up. ");
                    alpha.listLength();
                    if (alpha.returnChar() == "z")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n                      Winner winner, chicken dinner.");
                        winner = true;
                        alpha.resetCounter();
                    }
                }
                else
                {
                    Console.WriteLine("\n   Lock it up sausage fingers. Time to start over.");
                    alpha.resetCounter();
                }
            } while (enteredKey.Key != ConsoleKey.Escape);
        }
    }
}
