using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 📝 Day5 문제: 가장 많이 등장한 문자 찾기
///
/// 하나의 문자열 S가 주어질 때,  
/// 대소문자를 구분하지 않고 가장 많이 등장한 문자를 출력하는 프로그램을 작성하시오.
///
/// 만약 가장 많이 등장한 문자가 여러 개라면 `?`를 출력한다.
///
/// 📌 입력 조건:
/// - 문자열 S (1 ≤ S의 길이 ≤ 1,000,000)
///
/// 📌 출력 조건:
/// - 가장 많이 등장한 알파벳 (대문자 한 글자)
/// - 가장 많이 등장한 문자가 여러 개인 경우 `?`
///
/// ⛔ 대소문자 구분 없이 세야 하며, 출력은 대문자로 할 것!
///
/// 💡 입력 예시 1: `Mississipi`
/// 💡 출력 예시 1: `?`
///
/// 💡 입력 예시 2: `zZa`
/// 💡 출력 예시 2: `Z`
/// </summary>

namespace CoTe.DayX
{
    internal class Day5
    {
        public static void Run()
        {
            Console.WriteLine("문자열을 입력하세요: ");
            string input = Console.ReadLine().ToUpper();

            int[] alphabet = new int[26];

            foreach (char C in input)
            {
                if (char.IsLetter(C))
                {
                    alphabet[C - 'A']++;
                }
            }

            int max = 0;
            char result = '?';
            bool isDuplicated = false;

            for (int i = 0; i < 26; i++)
            {
                if (alphabet[i] > max)
                {
                    max = alphabet[i];
                    result = (char)(i + 'A');
                    isDuplicated = false;
                }
                else if (alphabet[i] == max)
                {
                    isDuplicated = true;
                }
            }

            Console.WriteLine(isDuplicated ?  "?" : result.ToString());
        }
    }
}
