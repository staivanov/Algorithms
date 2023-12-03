namespace SortingAlgorithms.ComparisonBased
{   //O(n^2)
    public static class SelectionSort
    {
        public static int[] Sort(int[] numbers)
        {
            int numbersLen = numbers.Length,
                startIndex = 0;

            while (startIndex < numbersLen - 1)
            {
                int position = startIndex,
                    innerStartIndex = startIndex + 1;

                while (innerStartIndex < numbersLen)
                {
                    if (numbers[innerStartIndex] < numbers[position])
                    {
                        position = innerStartIndex;
                    }

                    innerStartIndex++;
                }

                int temp = numbers[position];
                numbers[position] = numbers[startIndex];
                numbers[startIndex] = temp;

                startIndex++;
            }

            return numbers;
        }
    }
}
