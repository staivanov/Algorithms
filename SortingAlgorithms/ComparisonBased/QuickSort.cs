namespace SortingAlgorithms.ComparisonBased
{
    public static class QuickSort
    {   //O (n log(n))
        public static int[]  Sort(int[] numbers, int low, int high)
        {
            if(low < high)
            {
                int pi = Partition(numbers, low, high);
                Sort(numbers, low, pi - 1);
                Sort(numbers, pi + 1, high);
            }

            return numbers;
        }


        private static int Partition(int[] numbers, int low, int high)
        {
            int pivot = numbers[low],
                i = low + 1,
                j = high;

            do
            {
                while(i <= j && numbers[i] <= pivot)
                {
                    i++;
                }

                while(i <= j && numbers[j] > pivot)
                {
                    j--;
                }

                if(i <= j)
                {
                    Swap(numbers, i, j);
                }
            }
            while (i < j);

            Swap(numbers, low, j);

            return j;
        }


        private static void Swap(int[] numbers, int i, int j)
        {
            (numbers[j], numbers[i]) = (numbers[i], numbers[j]);
        }
    }
}
