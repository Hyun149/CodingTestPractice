namespace CodingTestPractice.Day_1
{
    public static class FindMaxMin
    {
        // 📝 문제: 최댓값과 최솟값 찾기
        //
        // 주어진 정수 배열(numbers)에서
        // 최댓값(Max)과 최솟값(Min)을 찾아 출력하는 프로그램을 작성하세요.
        //
        // ✨ 입력 조건:
        // - 정수 배열 numbers가 주어집니다.
        // - 배열은 비어있지 않으며, 정수 값으로만 구성됩니다.
        //
        // ✨ 출력 조건:
        // - 최댓값과 최솟값을 각각 한 줄씩 출력합니다.
        //
        // 📋 입력 예시:
        // numbers = [5, 9, 3, 7, 2, 8, 6]
        //
        // 📋 출력 예시:
        // 최댓값: 9
        // 최솟값: 2

        public static void Run()
        {
            int[] numbers = { 5, 9, 3, 7, 2, 8, 6 };
            int max = numbers[0];
            int min = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
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

            Console.WriteLine(max); // $"{}" 문자열 보간으로 최댓값: {max} 이런식으로 출력해주면 더 좋은 요소가 된다.
            Console.WriteLine(min);

            Console.WriteLine($"최댓값: {max}");
            Console.WriteLine($"최솟값: {min}");
        }
    }
}
