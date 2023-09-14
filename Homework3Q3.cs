namespace Homework3Q3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input an integer: ");
        int N = Convert.ToInt16(Console.ReadLine());
        for(int row = 1; row <= N; row++)
        {
            for(int col=1; col<= row; col++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
