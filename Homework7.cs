namespace Homework7;

class Program
{
    static void Main(string[] args)
    {
        Customer cus1 = new Customer(cus_id : 110, cus_name : "Alice", cus_age : 28);
        cus1.PrintCusInfo();

        Customer cus2 = new Customer(cus_id : 111, cus_name : "Bob", cus_age : 30);
        cus2.PrintCusInfo();

        cus1.ChangeID(new_id : 220);
        cus1.PrintCusInfo();
        cus2.ChangeID(new_id : 221);
        cus2.PrintCusInfo();

        cus1.CompareAge(cus2);
    }
}

class Customer{
    public int cus_id {get;set;}
    public string cus_name {get;set;}
    public int cus_age {get;set;}
    public Customer(int cus_id, string cus_name, int cus_age){
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
    }
    public void ChangeID(int new_id){
        cus_id = new_id;
    }
    public void PrintCusInfo(){
        Console.WriteLine($"Customer: {cus_id}, name: {this.cus_name}, Age: {this.cus_age}");
    }
    public void CompareAge(Customer objCustomer){
        if(this.cus_age <= objCustomer.cus_age){
            Console.WriteLine($"{this.cus_name} is younger");
        }
        else{
            Console.WriteLine($"{objCustomer.cus_name} is younger");
        }
    }
}