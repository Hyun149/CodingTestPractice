using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoTe.DayX
{
    internal class Day7
    {
        /// <summary>
        /// 📝 문제: 구간 합 구하기
        /// 
        /// 정수 배열이 주어진다. 이 배열에서 여러 개의 구간에 대해 구간 합을 빠르게 구해야 한다.
        /// 즉, 여러 개의 질의 쌍 (i, j)에 대해, 배열의 i번째부터 j번째 원소까지의 합을 구하라.
        ///
        /// 📌 입력 조건:
        /// - 첫째 줄에 정수 N (1 ≤ N ≤ 100,000) 이 주어진다. (배열의 크기)
        /// - 둘째 줄에 N개의 정수 A₁, A₂, ..., Aₙ 이 공백으로 주어진다. (각 원소는 -1,000 ≤ Aᵢ ≤ 1,000)
        /// - 셋째 줄에 질의 개수 Q (1 ≤ Q ≤ 100,000) 이 주어진다.
        /// - 다음 Q줄에 각각 정수 i, j (1 ≤ i ≤ j ≤ N)가 주어진다.
        ///
        /// 📌 출력 조건:
        /// - Q개의 줄에 각각의 구간 합 결과를 출력하라.
        ///
        /// 💡 예제 입력:
        /// 5
        /// 10 20 30 40 50
        /// 3
        /// 1 3
        /// 2 5
        /// 3 3
        ///
        /// 💡 예제 출력:
        /// 60
        /// 140
        /// 30
        ///
        /// 🔎 설명:
        /// 첫 번째 질의: A[1] + A[2] + A[3] = 10 + 20 + 30 = 60
        /// 두 번째 질의: 20 + 30 + 40 + 50 = 140
        /// 세 번째 질의: 30 (혼자)
        /// 
        /// 💡 힌트:
        /// - 단순 for문은 시간초과!
        /// - 입력과 질의 수가 많을 땐 **누적합 배열**을 먼저 만들어야 함.
        /// </summary>

        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // 누적합 배열 (1-based index용으로 크기 n+1로 생성)
            int[] prefixSum = new int[n + 1];

            for (int i = 1; i <= n; i++)
            {
                prefixSum[i] = prefixSum[i - 1] + arr[i - 1];
            }

            int q = int.Parse(Console.ReadLine());

            for (int k = 0; k < q; k++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int i = input[0];
                int j = input[1];

                int sum = prefixSum[j] - prefixSum[i - 1];
                Console.WriteLine(sum);
            }
        }
    }
}
