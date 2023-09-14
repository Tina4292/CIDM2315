namespace Homework3Q2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input an integer: ");
        int N = Convert.ToInt16(Console.ReadLine());
        for(int row = 1; row<=N; row++)
        {
            for(int col = 1; col<=N; col++)
            {
                Console.Write("#");
            }
        Console.WriteLine();
        }
    }
}
