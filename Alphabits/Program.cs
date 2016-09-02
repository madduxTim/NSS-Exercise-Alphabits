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
            string[] alphabet = new string[26] {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
            ConsoleKeyInfo enteredKey;         
            Alphas alpha = new Alphas();
            int counter = 0;

            //bool winner = false;

            Console.Write("Please, begin typing all the letters of the alphabet. Hit Esc if you want to quit.\n");
            do 
            {
                enteredKey = Console.ReadKey();
                string input = enteredKey.Key.ToString().ToLower();

                for (int i = 0; i < alphabet.Length; i++)
                {
                    //Console.WriteLine($"\nYou pressed the {enteredKey.Key.ToString().ToLower()} key");
                    if (input == alphabet[i] && counter == i) 
                    {
                        Console.WriteLine("\nNice! you nailed it! Keep going" + "Here's i =" + i + "and counter " + counter);
                        counter += 1;
                        //break;
                    } else if (input != alphabet[i] || counter != i)
                    {
                        Console.WriteLine("Bummer");
                    }
                }
            } while (enteredKey.Key != ConsoleKey.Escape);
        }
    }
}
