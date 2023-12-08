namespace SearchingAlgorithms
{   //BinarySearch works only for sorter elements. 
    public static class BinarySearchIterative
    {
        public static int Search(int[] numbers, int number)
        {
            int left = 0,
                right = numbers.Length,
                notFound = -1;

            while (left < right)
            {
                int middle = (left + right) / 2;

                if (number == numbers[middle])
                {
                    return middle;
                }
                else if (number < numbers[middle])
                {
                    right = middle - 1;
                }
                else if (number > numbers[middle])
                {
                    left = middle + 1;
                }
            }

            return notFound;
        }
    }
}
