using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please input a letter grade: ");
        string grade = Console.ReadLine().ToUpper();
        switch (grade)
        { 
            case 'A':
                gpaPoints = 4;
                break;
            case 'B':
                gpaPoints = 3;
                break;
            case 'C':
                gpaPoints = 2;
                break;
            case 'D':
                gpaPoints = 1;
                break;
            case 'F':
                gpaPoints = 0;
                break;
            default:
                Console.WriteLine("Wrong Letter Grade!");
                break;
        }

        Console.WriteLine($"GPA Points: {gpaPoints}");
    }
}    
        
