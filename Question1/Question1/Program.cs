using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a few words separated by a space:");
        string input = Console.ReadLine();

        string pascalCase = ConvertToPascalCase(input);

        Console.WriteLine("PascalCase variable name: " + pascalCase);
    }

    static string ConvertToPascalCase(string input)
    {
        string[] words = input.ToLower().Split(' ');
        string pascalCase = "";

        foreach (string word in words)
        {
            pascalCase += char.ToUpper(word[0]) + word.Substring(1);
        }

        return pascalCase;
    }
}

