using System;

class Program
{
    static void Main()
    {
        int a = 0;
        int b = 1;

        for (int i = 0; i < 25; i++)
        {
            int next = a + b;
            a = b;
            b = next;

            Console.Write($"{a}, ");
        }
    }
}