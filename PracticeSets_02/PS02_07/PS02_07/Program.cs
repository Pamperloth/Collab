using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS02_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.Write("Enter how many numbers do you want to add together: ");
            int input = Convert.ToInt32(Console.ReadLine());

            int[] Array = new int[input];

            Console.WriteLine("Enter numbers to fill Array: ");
            for (int i = 0; i < n; i++)
            {
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                sum = sum + Array[i];
            }

            Console.WriteLine($"The sum of numbers is {sum}");
        }
    }
}