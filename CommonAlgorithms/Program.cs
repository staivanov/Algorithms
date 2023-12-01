using SortingAlgorithms.ComparisonBased;

namespace CommonAlgorithms
{
    public class Program
    {
        static void Main()
        {
            int[] numbs = { 5, 3, 7, 4, 1 };

            int[] sortedNumbers = BubbleSort.Sort(numbs);

            foreach (var number in sortedNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
