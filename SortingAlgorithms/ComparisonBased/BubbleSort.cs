namespace SortingAlgorithms.ComparisonBased
{
    public static class BubbleSort
    {   //O(n^2)
        public static int[] Sort(int[] numbers)
        {
            int numbersLen = numbers.Length,
                rounds = numbersLen - 1;

            while (rounds >= 0)
            {
                int counter = 0;

                while (rounds > counter)
                {
                    if (numbers[counter] > numbers[counter + 1])
                    {
                        int temp = numbers[counter];
                        numbers[counter] = numbers[counter + 1];
                        numbers[counter + 1] = temp;
                    }

                    counter++;
                }

                rounds--;
            }

            return numbers;
        }
    }
}
