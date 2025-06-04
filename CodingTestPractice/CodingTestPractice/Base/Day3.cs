using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestPractice
{
    internal class Day3
    {
        /// <summary>
        /// 📝 문제: 두 수의 공약수의 합 구하기
        /// 
        /// 두 개의 자연수 a, b가 주어진다.  
        /// 이 두 수의 공약수(공통된 약수)를 모두 찾아 그 합을 구하는 프로그램을 작성하시오.
        /// 
        /// 📌 입력 조건:
        /// - 첫째 줄에 두 자연수 a, b가 공백으로 구분되어 주어진다.
        /// - (1 ≤ a, b ≤ 10,000)
        /// 
        /// 📌 출력 조건:
        /// - 두 수의 공약수의 합을 출력한다.
        /// 
        /// 💡 예제 입력:
        /// 12 18
        /// 
        /// 💡 예제 출력:
        /// 12
        /// 
        /// 🔎 설명:
        /// 12의 약수: 1, 2, 3, 4, 6, 12  
        /// 18의 약수: 1, 2, 3, 6, 9, 18  
        /// 공약수: 1, 2, 3, 6 → 합: 12
        /// </summary>


        public static void Run()
        {
            var input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            int min = Math.Min(a, b);
            int sum = Enumerable.Range(1, min).Where(i => a % i == 0 && b % i == 0).Sum();

            Console.WriteLine(sum);
        }

        /// Split의 용도는? 
        /// 문자열을 쪼개서 배열로 만드는 용도.

        /// 여기서 Enumerable를 적은 이유는? 
        /// Enumerable.Range(1, min)의 의미: 1부터 min까지의 정수 열을 만든다.
        /// 왜 for 문 대신 Enumerable.Range를 썼나?
        /// 1. LINQ 문법을 활용해서 코드를 한줄로 깔끔하게 구성.
        /// 2. for문보다 가독성이 좋고, 부작용 없이 순수 계산이 가능하다.
    }
}
