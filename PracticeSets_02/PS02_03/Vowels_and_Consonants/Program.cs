using System;
class Program 
{
    static void Main(string[] args)
    {
        Console.Write("Enter a character: ");
        string input = Console.ReadLine();
        string letter = input.ToLower();

        if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
        {
            Console.WriteLine("The character is a vowel.");
        }
        else
        {
            Console.WriteLine("The character is a consonant.");
        }
    }

}

