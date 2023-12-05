using SearchingAlgorithms;
namespace CommonAlgorithms
{
    public class Program
    {
        static void Main()
        {
            int[] numbs = { 101, 14, 65, 5, 3, 7, 4, 1, 99, 99 };
            int seekingNumber = 5,
                indexOfSeekingNumber;
            indexOfSeekingNumber = LinearSearch.Search(numbs, seekingNumber);

            Console.WriteLine("The index of seeking number is: " + indexOfSeekingNumber);
        }
    }
}
