using System;

class Program
{
    static void Main()
    {
        string original = "DotNet";
        string reversed = "";

        for (int i = 1; i <= original.Length; i++)
        {
            Console.WriteLine(original.Length - i);
            reversed += (original[original.Length - i]);
        }

        Console.WriteLine($"Reversed: {reversed}");
    }
}
