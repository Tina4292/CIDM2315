namespace Homework4Q1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input two integers");
        int a = GetInteger();
        int b = GetInteger();
        int lrg_num = LargestNum(a, b);
        Console.WriteLine($"The largest number is: {lrg_num}");
    }
    static int GetInteger()
    {
        int int_input = Convert.ToInt16(Console.ReadLine());
        return int_input;
    }
    static int LargestNum(int a, int b)
    {
        if(a < b){
            return b;
        }
        else{
            return a;
        }
    }
}
