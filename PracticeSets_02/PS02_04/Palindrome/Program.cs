using System;
class Program
{
    static void Main(string[] args)
    {
        string input, revString = "";
        Console.Write("Enter string: ");
        input = Console.ReadLine();

        for (int i = input.Length - 1; i >= 0; i--)
        {
            revString = revString + input[i];
        }

        if (revString == input)
        {
            Console.WriteLine("The string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The string is not a palindrome.");
        }
    }

}
