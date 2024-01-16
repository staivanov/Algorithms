namespace Heaps
{
    public class Program
    {
        static void Main()
        {
            Heap heap = new Heap();
            int[] numbers = { 20, 15, 2, 4, 99, 79, 63 };
            heap.Display(numbers);
            heap.HeapSort(numbers);
            Console.WriteLine();
            heap.Display(numbers);

        }
    }
}
