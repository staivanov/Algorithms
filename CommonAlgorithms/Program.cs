using SortingAlgorithms.ComparisonBased;

namespace CommonAlgorithms
{
    public class Program
    {
        static void Main()
        {
            int[] numbs = { 101, 14, 65, 5, 3, 7, 4, 1, 99, 99 };
            int lowestIndex = 0,
            highestIndex = numbs.Length - 1;

            int[] sortedNumbers = QuickSort.Sort(numbs, lowerIndex, higherIndex);

            foreach (int number in sortedNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
