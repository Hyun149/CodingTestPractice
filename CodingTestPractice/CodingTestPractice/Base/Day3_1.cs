using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestPractice.Base
{
    /// <summary>
    /// 📝 문제: 배열에서 홀수만 찾아 합계 구하기
    ///
    /// 정수 배열이 주어졌을 때, 그 중에서 홀수(odd number)인 값들만 골라  
    /// 그 합을 구하는 프로그램을 작성하시오.
    ///
    /// 📌 입력 조건:
    /// - 첫째 줄에 배열의 길이 n이 주어진다. (1 ≤ n ≤ 100)
    /// - 둘째 줄에 n개의 정수가 공백으로 구분되어 주어진다. (각 수는 -1000 이상 1000 이하)
    ///
    /// 📌 출력 조건:
    /// - 배열에서 홀수인 정수들의 총합을 출력한다.
    ///
    /// 💡 예제 입력:
    /// 5
    /// 1 2 3 4 5
    ///
    /// 💡 예제 출력:
    /// 9
    /// </summary>

    internal class Day3_1
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            foreach (int num in numbers)
            {
                if (num % 2 != 0)
                {
                    sum += num;
                }
            }

            Console.WriteLine(sum);
        }

        /// 해설:
        /// 입력으로 배열 크기 n과 정수 n개를 받은 후
        /// 반복문(foreach)을 통해 배열을 하나씩 탐색한다.
        /// 그리고 num % 2 != 0 조건으로 홀수인지 판단 한 후에, 홀수값만 전부 더하고 출력한다.
    }
}
