using System.ComponentModel;

namespace Homework4Q2;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Please input a number");
       int num = Convert.ToInt16(Console.ReadLine());
       Console.WriteLine("Please input right or left");
       string _shape = Console.ReadLine();
       CheckShape(num, _shape);
    }
    static void CheckShape(int N, string shape)
    {
        if(shape == "left")
        {
            for(int row = 1; row <= N; row++)
            {
                for(int col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else if(shape == "right")
        {
            for(int row = 1; row <= N; row++)
            {
                for(int col = N - row; col >= 1; col--)
                {
                    Console.Write(" ");
                }
                for(int i = 1; i <= row; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Incorrect direction");
        }
    }
}
