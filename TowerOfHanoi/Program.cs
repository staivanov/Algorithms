using static System.Console;

namespace TowerOfHanoi
{
    public class Program
    {
        public static void Main()
        {
            Hanoi(3, 'A', 'B', 'C');
        }

        private static void Hanoi(int n, char from, char middle,
            char destination)
        {
            if (n == 1)
            {
                WriteLine($"Moving disk {n} from {from} to {destination}");
                return;
            }

            Hanoi(n - 1, from, destination, middle);
            WriteLine($"Moving disk {n} from {from} to {destination}");
            Hanoi(n - 1, middle, from, destination);
        }
    }
}
