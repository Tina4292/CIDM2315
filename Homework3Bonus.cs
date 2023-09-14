namespace Homework3Bonus;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input an integer");
        int N = Convert.ToInt16(Console.ReadLine());
        for(int row = 1; row <= N; row++)
        {
            for(int col = N - row; col >= 1; col--)
            {
                Console.Write(" ");
            }
            for(int i=1; i<=row; i++)
            {
                Console.Write($"{row}");
            }
            Console.WriteLine();
        }
    }
}
