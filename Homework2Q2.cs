namespace Homework2Q2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input the first number: ");
        string n1 = Console.ReadLine();
        int n1_int = Convert.ToInt16(n1);

        Console.WriteLine("Please input the second number: ");
        string n2 = Console.ReadLine();
        int n2_int = Convert.ToInt16(n2);

        Console.WriteLine("Please input the third number: ");
        string n3 = Console.ReadLine();
        int n3_int = Convert.ToInt16(n3);

        if(n1_int<n2_int){
            if(n1_int<n3_int){
                Console.WriteLine($"The smallest number is {n1_int}");
            }
            else{
                Console.WriteLine($"The smallest number is {n3_int}");
            }
        }
        else if(n2_int<n1_int){
            if(n2_int<n3_int){
                Console.WriteLine($"The smallest number is {n2_int}");
            }
            else{
                Console.WriteLine($"The smallest number is {n3_int}");
            }
        }
        else{
            Console.WriteLine($"The smallest number is {n3_int}");
        }

    }
}
