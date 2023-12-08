namespace SearchingAlgorithms
{
    public class BinarySearchRecursion
    {
        public static int Search(int[] numbers, int number, int leftSide, int rightSide)
        {
            int left = leftSide,
                right = rightSide,
                notFound = -1,
                middle = (left + right) / 2;

            if (left > right)
            {
                return notFound;
            }
            else if (number == numbers[middle])
            {
                return middle;
            }
            else if(number < numbers[middle])
            {
                return Search(numbers, number, left, middle - 1);
            }
            else if(number > numbers[middle])
            {
                return Search(numbers, number, middle + 1, right);
            }

            return notFound;
        }
    }
}
