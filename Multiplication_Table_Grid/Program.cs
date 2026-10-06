using System;

class Program
{
    static void Main()
    {
        int size = 13;

        // TODO: Write nested for loops:
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"{i * j}\t");
            } 

            Console.WriteLine();
        }
        // Outer loop controls rows (1 to size)
        // Inner loop controls columns (1 to size)
        // Use Console.Write($"{row * col}\t") to align cells horizontally
    }
}
