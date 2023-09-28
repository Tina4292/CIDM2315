namespace Homework5Q3;

class Program
{
    static void Main(string[] args)
    {
        CreateAccount();
    }
    static void CreateAccount()
    {
        Console.WriteLine("Please enter your username");
        string user_name = Console.ReadLine();
        Console.WriteLine("Please enter your password");
        string password = Console.ReadLine();

        Console.WriteLine("Please enter your password again");
        string check_password = Console.ReadLine();

        Console.WriteLine("Please enter your birth year");
        int birth_year = Convert.ToInt16(Console.ReadLine());
        
        if(CheckAge(birth_year))
        {
            if(password == check_password)
            {
                Console.WriteLine("Account is created successfully");
            }
            else{
                Console.WriteLine("Wrong password");
            }
        }
        else{
            Console.WriteLine("Could not create an account");
        }
        
    }
    static bool CheckAge(int birth_year)
    {
        int age = 2023 - birth_year;
        if(age >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
