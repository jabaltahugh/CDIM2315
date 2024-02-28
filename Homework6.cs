
using System;

class Professor
{
    public string profName;
    public string classTeach;
    private double salary;

    public void SetSalary(double salary)
    {
        this.salary = salary;
    }

    public double GetSalary()
    {
        return salary;
    }
}

class Student
{
    public string studentName;
    public string classEnroll;
    private double studentGrade;

    public void SetGrade(double newGrade)
    {
        studentGrade = newGrade;
    }

    public double GetGrade()
    {
        return studentGrade;
    }
}

class Program
{
    static void Main()
    {
        // Create professors
    
        Professor bob = new Professor();
        Professor alice = new Professor();
        Student lisa = new Student();
        Student tom = new Student();
        string professorName;
        string subject;
        double salary;
        
        string studentName;
        double grade;
        string classEnroll;
        
        // bob professor
        bob.profName = "Bob";
        bob.classTeach = "Math";
        bob.SetSalary(8000);

        // alice professor
        alice.profName = "Alice";
        alice.classTeach = "Java";
        alice.SetSalary(9000);

        // lisa student
        lisa.studentName = "Lisa";
        lisa.classEnroll = "Java";
        lisa.SetGrade(90);

        // tom student
        tom.studentName = "Tom";
        tom.classEnroll = "Math";
        tom.SetGrade(80);
        
        
        professorName = alice.profName;
        salary = alice.GetSalary();
        subject = alice.classTeach;
        Console.WriteLine($"Professor {professorName} teaches {subject}, and the salary is: {salary}");
        
        professorName = bob.profName;
        salary = bob.GetSalary();
        subject = bob.classTeach;
        Console.WriteLine($"Professor {professorName} teaches {subject}, and the salary is: {salary}");

        studentName = lisa.studentName;
        classEnroll = lisa.classEnroll;
        grade = lisa.GetGrade();
        Console.WriteLine($"Student {studentName} enrolls {classEnroll}, and the grade is: {grade}");
        
        
        studentName = tom.studentName;
        classEnroll = tom.classEnroll;
        grade = tom.GetGrade();
        Console.WriteLine($"Student {studentName} enrolls {classEnroll}, and the grade is: {grade}");

        // Salary difference of professors
        double salaryDiff = alice.GetSalary() - bob.GetSalary();
        
        Console.WriteLine($"The salary difference between {alice.profName} and {bob.profName} is: {salaryDiff}");

        // sum of grades
        double totalGrades = lisa.GetGrade() + tom.GetGrade();
        Console.WriteLine($"The total grade of {lisa.studentName} and {tom.studentName} is: {totalGrades}");
    }
}
