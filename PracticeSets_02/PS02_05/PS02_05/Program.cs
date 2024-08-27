using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS02_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            string newString = input.ToUpper();
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in newString)
            {
                dict.TryGetValue(c, out int value);
                dict[c] = value + 1;
            }

            foreach (var x in dict)
            {
                Console.WriteLine($"Character {x.Key} is {x.Value}");
            }
        }
    }
}