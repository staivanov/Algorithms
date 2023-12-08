using SearchingAlgorithms;
namespace CommonAlgorithms
{
    public class Program
    {
        static void Main()
        {
            int[] numbs = { 3, 5, 7, 10, 15, 20, 55 };
            int seekingNumber = 10,
                secondSeekingNumer = 11,
                seekingNumberIndex,
                secondSeekingNumberIndex;

            seekingNumberIndex = BinarySearchIterative.Search(numbs, seekingNumber);
            secondSeekingNumberIndex = BinarySearchIterative.Search(numbs, secondSeekingNumer);

            Console.WriteLine($"Number is at index: {seekingNumberIndex}");
            Console.WriteLine($"Number is at index: {secondSeekingNumberIndex}");
        }
    }
}
