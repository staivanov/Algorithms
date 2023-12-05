using SearchingAlgorithms;
namespace CommonAlgorithms
{
    public class Program
    {
        static void Main()
        {
            int[] numbs = { 101, 14, 65, 5, 3, 7, 4, 1, 99, 99 };
<<<<<<< HEAD
            int seekingNumber = 5,
                indexOfSeekingNumber;
            indexOfSeekingNumber = LinearSearch.Search(numbs, seekingNumber);
=======
            int lowestIndex = 0,
            highestIndex = numbs.Length - 1;
>>>>>>> d3115eafbbfe911ac5b814dde7227e781d5998cb

            Console.WriteLine("The index of seeking number is: " + indexOfSeekingNumber);
        }
    }
}
