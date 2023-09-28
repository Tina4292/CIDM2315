namespace Homework5Q2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input four integers");
        int a = GetInteger();
        int b = GetInteger();
        int c = GetInteger();
        int d = GetInteger();
        int lrg_num = LargestNum(a, b, c, d);
        Console.WriteLine($"The largest number is: {lrg_num}");
    }
    static int GetInteger()
    {
        int int_input = Convert.ToInt16(Console.ReadLine());
        return int_input;
    }
    static int LargestNum(int a, int b, int c, int d)
    {
        if(a > b && a > c && a > d)
        {
            return a;
        }
        else if(b > a && b > c && b > d)
        {
            return b;
        }
        else if(c > a && c > b && c > d)
        {
            return c;
        }
        else
        {
            return d;
        }
    }
}
