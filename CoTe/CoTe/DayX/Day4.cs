using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoTe.DayX
{
    internal class Day4
    {
        public static void Run()
        {
            Console.Write("자연수 N을 입력하세요:");
            int n = int.Parse(Console.ReadLine());

            int count = 0;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                count++;
                sum += i;
                }
            }

            Console.WriteLine($"{count} {sum}");
        }
    }

    /// <summary>
    /// 📝 Day4 문제: 약수의 개수와 합 구하기
    /// 
    /// 하나의 자연수 N이 주어질 때,
    /// 1부터 N까지의 약수의 개수와 약수의 총합을 구하는 프로그램을 작성하시오.
    /// 
    /// 📌 입력 조건:
    /// - 자연수 N (1 ≤ N ≤ 10,000)
    /// 
    /// 📌 출력 조건:
    /// - 약수의 개수와 약수의 총합을 한 줄에 공백으로 구분하여 출력
    /// 
    /// 💡 예제 입력:
    /// 12
    /// 
    /// 💡 예제 출력:
    /// 6 28
    /// 
    /// 🔎 설명:
    /// 12의 약수는 [1, 2, 3, 4, 6, 12] → 개수: 6개, 합: 28
    /// </summary>
}
