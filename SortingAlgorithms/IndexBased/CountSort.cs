namespace SortingAlgorithms.IndexBased
{
    public static class CountSort
    {   //O(n) 
        public static int[] Sort(int[] numbers)
        {
            int[] countArray = new int[numbers.Max()+1];
            int numbersLen = numbers.Length,
                index = 0;

            while (index < numbersLen)
            {
                countArray[numbers[index]] = countArray[numbers[index]] + 1;
                index++;
            }

            int indexTwo = 0,
                indexThree = 0;

            while(indexTwo < numbersLen + 1)
            {
                if (countArray[indexTwo] > 0)
                {
                    numbers[indexThree++] = indexTwo;
                    countArray[indexTwo] = countArray[indexTwo] - 1;
                }
                else
                {
                    indexTwo++;
                }
            }

            return numbers;
        }
    }
}
