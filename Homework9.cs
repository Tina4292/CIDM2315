namespace Homework9;

class Program
{
    static void Main(string[] args)
    {
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444, "David"); 

        Dictionary<string, double> gradebook = new Dictionary<string, double>();
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);

        if(gradebook.ContainsKey("Tom")==false){
            gradebook.Add("Tom", 3.3);
        }

        double totalGPA = 0;
        // calcuate total of the GPAs        
        foreach(KeyValuePair<string, double> stu in gradebook){
            totalGPA = totalGPA +stu.Value;
        }
        // calculate avgGPA
        double avgGPA = totalGPA/gradebook.Count;
        Console.WriteLine("The avg GPA is: "+avgGPA);

        foreach(Student stu in Student.student_list){
            if(gradebook[stu.studentName] > avgGPA){
                stu.PrintInfo();
            }
        }
    }
}
class Student
{
    public int studentID {get; set;}
    public string studentName {get; set;}

    
    
    public void PrintInfo(){
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }

    public static List<Student> student_list = new List<Student>();

    public Student(int inputID, string inputName){
        studentID = inputID;
        studentName = inputName;
        student_list.Add(this);
        
    }
    
}
