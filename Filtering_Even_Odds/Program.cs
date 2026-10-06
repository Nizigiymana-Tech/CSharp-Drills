using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 12, 7, 19, 42, 8, 3, 15, 20 };
        int evenCount = 0;
        int oddCount = 0;

        // TODO: Write a for loop to inspect each element.
        // Use the modulo operator (%) to increment evenCount or oddCount.

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                evenCount += 1;
            } else
            {
                oddCount += 1;
            }
        }

        Console.WriteLine($"Evens: {evenCount}, Odds: {oddCount}");
    }
}
