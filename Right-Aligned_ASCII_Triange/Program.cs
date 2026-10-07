using System;

class Program
{
    static void Main()
    {
        Console.Write("What's the height you wanna input: ");
        string? response = Console.ReadLine();
        int height = 0;

        if (int.TryParse(response, out int result))
        {
            height = result;
        }

        for (int i = 1; i < height; i++)
        {
            for (int j = 1; j < height - i; j++)
            {
                Console.Write(" ");
            }

            string star = string.Concat(Enumerable.Repeat("*", i));
            Console.WriteLine(star);
        }

    }
}