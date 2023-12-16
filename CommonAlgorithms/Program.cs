using SearchingAlgorithms;
using SortingAlgorithms.IndexBased;
namespace CommonAlgorithms
{
    public class Program
    {
        static void Main()
        {
            int[] numbs = { 3, 5, 7, 10, 15, 20, 55 };
            int[] sortedNumbers = CountSort.Sort(numbs);

            foreach (var number in sortedNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
