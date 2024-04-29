namespace SortingAlgorithms.IndexBased
{
    public static class CountSort
    {   //O(n) 
        public static int[] Sort(int[] numbers)
        {
            int[] countArray = new int[numbers.Max() + 1];
            int numbersLen = numbers.Length,
                index = 0;

            while (index < numbersLen)
            {
                int number = numbers[index],
                    countNumber = countArray[number] + 1;
                countArray[number] = countNumber;
                index++;
            }

            int indexTwo = 0,
                indexThree = 0;

            while (indexTwo <= numbersLen)
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
