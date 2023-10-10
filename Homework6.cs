using System.Security.Cryptography.X509Certificates;

namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        Professor p1 = new Professor();
        p1.profName = "Alice";
        p1.classTeach = "Java";
        p1.SetSalary(9000);
        p1.PrintInfo();

        Professor p2 = new Professor();
        p2.profName = "Bob";
        p2.classTeach = "Math";
        p2.SetSalary(8000);
        p2.PrintInfo();

        Student s1 = new Student();
        s1.studentName = "Lisa";
        s1.classEnroll = "Java";
        s1.SetGrade(90);
        s1.PrintStudentInfo();

        Student s2 = new Student();
        s2.studentName = "Tom";
        s2.classEnroll = "Math";
        s2.SetGrade(80);
        s2.PrintStudentInfo();

        double profSalaryOne = p1.GetSalary();
        double profSalaryTwo = p2.GetSalary();
        double difference = profSalaryOne - profSalaryTwo;
        Console.WriteLine($"The salary difference between {p1.profName} and {p2.profName} is: {difference}");

        double stuGradeOne = s1.GetGrade();
        double stuGradeTwo = s2.GetGrade();
        double gradeSum = stuGradeOne + stuGradeTwo;
        Console.WriteLine($"The total grade of {s1.studentName} and {s2.studentName} is: {gradeSum}");
    }
}

class Student{
    public string studentName;
    public string classEnroll;
    
    // student grade is a private variable
    private double studentGrade;

    public void SetGrade(double newGrade)
    {
        //code here
        studentGrade = newGrade;
    }
    public double GetGrade()
    {
        //code here
        return studentGrade;
    }
    public void PrintStudentInfo()
    {
        Console.WriteLine($"Student {studentName} enrolls {classEnroll}, and the grade is: {studentGrade}");
        
    }
}

class Professor{
    public string profName;
    public string classTeach;

    //salary is a private variable
    private double salary;

    public void SetSalary(double salary_amount)
    {
        //code here
        salary = salary_amount;
    }
    public double GetSalary()
    {
        //code here
        return salary;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Professor {profName} teaches {classTeach}, and the salary is: {salary}");
        
    }
}