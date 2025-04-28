using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 42, 17, 88, 59, 34, 60 };
        int min = numbers[0];
        int index = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min) 
            {
                min = numbers[i];
                index = i;
            }
        }

        Console.WriteLine(min);
        Console.WriteLine(index + 1);
    }
}