using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 12, 7, 19, 42, 8, 3, 15, 20 };
        HashSet<int> removedDups = new HashSet<int>(numbers);

        int largestNum = numbers[0];

        for (int i = 1; i < removedDups.Count; i++) {
            if (numbers[i] > largestNum) {
                largestNum = numbers[i];
            }
        }

        int secondBiggest = 0;

        foreach (int num in numbers)
        {
            if (num > secondBiggest && num != largestNum)
            {
                secondBiggest = num;
            } 
        }

        Console.WriteLine(secondBiggest);
    }
}