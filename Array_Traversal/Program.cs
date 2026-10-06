using System;

class Program
{
    static void Main()
    {
        string[] fruits = { "Apple", "Banana", "Cherry", "Dragonfruit" };

        for (int i = 0; i < fruits.Length; i++)
        {
            Console.WriteLine($"Index {fruits.Length - fruits.Length + i}: {fruits[i]}");
        }
    }
}