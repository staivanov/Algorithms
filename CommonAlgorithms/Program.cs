using SearchingAlgorithms;
namespace CommonAlgorithms
{
    public class Program
    {
        static void Main()
        {
            int[] numbs = { 3, 5, 7, 10, 15, 20, 55 };
            int startIndex = 0,
                lastIndex = numbs.Length,
                seekingNumber = 10,
                secondSeekingNumer = 11,
                seekingNumberIndex,
                seekingSecondNumberIndex;

            seekingNumberIndex = BinarySearchRecursion.Search(numbs, seekingNumber, startIndex, lastIndex);
            seekingSecondNumberIndex = BinarySearchRecursion.Search(numbs, secondSeekingNumer, startIndex, lastIndex);
        }
    }
}
