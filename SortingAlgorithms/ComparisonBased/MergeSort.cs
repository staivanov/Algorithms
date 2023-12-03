
namespace SortingAlgorithms.ComparisonBased
{
    public static class MergeSort
    {
        //O(n log(n))
        public static int[] Sort(int[] numbers, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                Sort(numbers, left, mid);
                Sort(numbers, mid + 1, right);
                Merge(numbers, left, mid, right);
            }

            return numbers;
        }


        private static void Merge(int[] numbers, int left, int mid, int right)
        {
            int i = left,
                j = mid + 1,
                k = left;
            int[] tempArray = new int[right+1];


            while (i <= mid && j <= right)
            {
                if (numbers[i] < numbers[j])
                {
                    tempArray[k] = numbers[i];
                    i++;
                }
                else
                {
                    tempArray[k] = numbers[j];
                    j++;
                }

                k++;
            }


            while (i <= mid)
            {
                tempArray[k] = numbers[i];
                i++;
                k++;
            }

            while (j <= right)
            {
                tempArray[j] = numbers[j];
                j++;
                k++;
            }

            for (int m = left; m < right+1; m++)
            {
                numbers[m] = tempArray[m];
            }

        }
    }
}
