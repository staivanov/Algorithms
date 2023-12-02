using SortingAlgorithms.ComparisonBased;

namespace CommonAlgorithms
{
    public class Program
    {
        static void Main()
        {
            int[] numbs = { 5, 3, 7, 4, 1 };


            int[] n = ShellSort.Sort(numbs);

            foreach (var item in n)
            {
                Console.WriteLine(item);
            }

        }
    }
}
