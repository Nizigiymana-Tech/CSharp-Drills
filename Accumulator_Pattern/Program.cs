using System;

class Program
{
    static void Main()
    {
        int n = 5;
        int factorial = 1;

        // TODO: Write a for loop running from 1 up to n (inclusive)
        // Multiply 'factorial' by the current loop variable inside

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"{n}! = {factorial}");
    }
}
