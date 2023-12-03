using SortingAlgorithms.ComparisonBased;

namespace CommonAlgorithms
{
    public class Program
    {
        static void Main()
        {
            int[] numbs = { 5, 3, 7, 4, 1 };
            int leftIndex = 0,
                rightIndex = numbs.Length - 1;


            int[] sortedNumbers = MergeSort.Sort(numbs, leftIndex, rightIndex);

            foreach (int number in sortedNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
