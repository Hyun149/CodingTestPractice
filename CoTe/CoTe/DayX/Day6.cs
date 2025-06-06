using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoTe.DayX
{
    internal class Day6
    {
        /// <summary>
        /// 📝 문제: 단어 빈도수 세기
        /// 
        /// 한 줄의 영문 문장이 입력으로 주어진다.
        /// 이 문장을 구성하는 **단어들의 빈도수**를 세어,
        /// 단어별로 알파벳 순서로 정렬된 결과를 출력하라.
        ///
        /// 📌 입력 조건:
        /// - 영어 소문자와 공백으로만 구성된 문장이 한 줄 주어진다.
        /// - 단어는 공백으로 구분된다.
        /// - 입력 문자열의 길이는 최대 1000자이다.
        ///
        /// 📌 출력 조건:
        /// - 각 단어와 해당 단어가 나온 횟수를 "단어: 횟수" 형태로 출력하되,
        ///   단어는 알파벳 순서로 정렬한다.
        ///
        /// 💡 예제 입력:
        /// the quick brown fox jumps over the lazy dog the dog
        ///
        /// 💡 예제 출력:
        /// brown: 1
        /// dog: 2
        /// fox: 1
        /// jumps: 1
        /// lazy: 1
        /// over: 1
        /// quick: 1
        /// the: 3
        ///
        /// 🔎 힌트:
        /// - Dictionary<string, int>를 활용해 보세요.
        /// - 입력은 Console.ReadLine()을 사용합니다.
        /// </summary>


        public static void Run()
        {
            string input = Console.ReadLine();
            var words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCount = new();

            foreach (var word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else // 키가 없다면
                {
                    wordCount[word] = 1; 
                }
            }

            foreach (var pair in wordCount.OrderBy(p => p.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
