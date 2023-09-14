namespace Homework3Q1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input a number: ");
        int n = Convert.ToInt16(Console.ReadLine());
        int num_divisor = 0;
        for(int i = 1; i<=n; i++){
            if(n % i ==0){
                num_divisor++;
            }
            
        }
        if(num_divisor ==2){
            Console.WriteLine("N is prime");
        }
        else{
            Console.WriteLine("N is non-prime");
        }
    }
}
