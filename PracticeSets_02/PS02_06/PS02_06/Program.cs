using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS02_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int input, remainder, sum = 0;
            Console.Write("Enter any number: ");
            input = Convert.ToInt32(Console.ReadLine());

            while (input != 0)
            {
                remainder = input % 10;
                input = input / 10;
                sum = sum + remainder;
            }

            Console.WriteLine($"The sum of digits: {sum}");
        }
    }
}