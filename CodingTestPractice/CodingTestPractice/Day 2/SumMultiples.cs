using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    // 📝 문제:
    // 1부터 n까지의 수 중에서
    // 3의 배수 또는 5의 배수인 수를 모두 찾아
    // 그 수들의 합을 구하여 출력하는 프로그램입니다.
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 0; i <= n; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
            }
        }

        Console.WriteLine(sum);
    }
}