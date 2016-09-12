using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Alphabits
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer speech = new SpeechSynthesizer();
            ConsoleKeyInfo enteredKey;         
            Alphas alpha = new Alphas();
            //bool winner = false;

            string beginMsg = "Type all the letters of the alphabet consecutively. Hit Esc if you want to quit.\n";
            Console.WriteLine(beginMsg);
            //speech.Speak(beginMsg);
            do 
            {
                enteredKey = Console.ReadKey();
                alpha.addChar(enteredKey.Key.ToString().ToLower());

                if (alpha.returnChar() == alpha.alphabet[alpha.returnCounter()-1])
                {
                    Console.WriteLine($"\n   Nice! You've gotten {alpha.returnCounter()} right so far. Keep it up. ");
                    //speech.Speak($"\n   Nice! You've gotten {alpha.returnCounter()} right so far. Keep it up. ");
                    alpha.returnAllEntries();
                    alpha.counterAdd();
                    if (alpha.returnChar() == "z")
                    {
                        alpha.returnAllEntries();
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n                      Winner winner, chicken dinner.");
                        speech.Speak("Winner winner, chicken dinner.");
                        //winner = true;
                        alpha.resetCounter();
                    }
                }
                else
                {
                    string startOverMsg = "\n   Lock it up sausage fingers. Time to start over.";
                    Console.WriteLine(startOverMsg);
                    speech.Speak(startOverMsg);
                    alpha.resetCounter();
                }
            } while (enteredKey.Key != ConsoleKey.Escape);
        }
    }
}
