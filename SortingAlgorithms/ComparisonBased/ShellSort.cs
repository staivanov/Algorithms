namespace SortingAlgorithms.ComparisonBased
{
    public static class ShellSort
    {
        public static int[] Sort(int[] numbers)
        {
            int numbersLen = numbers.Length,
                gap = numbersLen / 2;

            while (gap > 0)
            {
                int i = gap;

                while (i < numbersLen)
                {
                    int temp = numbers[i],
                        j = i - gap;

                    while(j >= 0 && numbers[j] > temp)
                    {
                        numbers[j + gap] = numbers[j];
                        j -= gap;
                    }

                    numbers[j + gap] = temp;
                    i++;
                }

                gap /= 2;

            }

            return numbers;
        }
    }
}
