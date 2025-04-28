using System;

class Program
{
    // 🎯 문제
    // 주어진 정수 배열에서 최댓값과 최솟값을 모두 찾아서 출력하세요.

    // 입력
    // [5, 9, 3, 7, 2, 8, 6]

    // 출력 예시
    // 최댓값: 9
    // 최솟값: 2
    static void Main()
    {
        int[] numbers = {5, 9, 3, 7, 2, 8, 6};
        int max = numbers[0];
        int min = numbers[0];

        for(int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];                           
            }
            if (numbers[i] > max)
            {
                max = numbers[i];
            }                
        }

        Console.WriteLine($"최댓값: {max}");
        Console.WriteLine($"최솟값: {min}");
    }
}