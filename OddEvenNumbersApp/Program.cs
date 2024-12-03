namespace OddEvenNumbersApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print("Numbers", numbers);
            Print("Numbers Even", numbers.Where(x=>IsEven(x)));
            Print("Numbers Odd", numbers.Where(x=>IsOdd(x)));

        }
        static void Print(string Title,IEnumerable<int> numbers)
        {
            Console.WriteLine($"{Title}");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------------");
        }
        static bool IsEven(int n)
        {
            return n % 2 == 0;
        } 
        static bool IsOdd(int n)
        {
            return n % 2 != 0;
        }
    }
}
