namespace SearchingAlgorithms
{
    public static class LinearSearch
    {
        public static int Search(int[] numbers, int number)
        {   //If number is not found at a specific index in our array, Search method return -1 to indicate the lack.
            int numberAtIndex = -1,
                index = 0;

            while (index < numbers.Length)
            {
                if (numbers[index] == number)
                {
                    numberAtIndex = index;

                    return numberAtIndex;
                }

                index++;
            }

            return numberAtIndex;
        }
    }
}
