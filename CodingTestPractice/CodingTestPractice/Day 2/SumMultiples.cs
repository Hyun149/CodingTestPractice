// SumMultiples.cs
namespace CodingTestPractice
{
    public static class SumMultiples
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = Enumerable.Range(1, n).Where(i => i % 3 == 0 || i % 5 == 0).Sum();
            Console.WriteLine(sum);
        }
    }
}