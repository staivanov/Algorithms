namespace SortingAlgorithms.ComparisonBased
{
    public static class InsertionSort
    {   //O(n^2)
        public static int[] Sort(int[] numbers)
        {
            int numbersLen = numbers.Length,
                startIndex = 1;

            while (startIndex < numbersLen)
            {
                int currentValue = numbers[startIndex],
                    position = startIndex;

                while (position > 0 && numbers[position - 1] > currentValue)
                {
                    numbers[position] = numbers[position - 1];
                    position--;
                }

                numbers[position] = currentValue;
                startIndex++;
            }

            return numbers;
        }
    }
}
