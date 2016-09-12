using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabits
{
    public class Alphas
    {
        List<string> entries = new List<string>();
        private string input;
        private int counter = 1;
        public string[] alphabet = new string[26] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

        public void addChar(string entry)
        {
            input = entry;
            entries.Add(entry);
            //Console.WriteLine("From addChar = " + entry);
        }
        public void counterAdd()
        {
            counter += 1;
        }
        public void resetCounter()
        {
            counter = 1;
        }
        public string returnChar()
        {
            //return input;
            return entries.Last();
        }
        public string returnAllEntries()
        {
            string allEntries = "";
            foreach (string entry in entries)
            {
                allEntries += entry;
            }
            return allEntries;
        }
        public int returnCounter()
        {
            return counter;
        }
    }
}
