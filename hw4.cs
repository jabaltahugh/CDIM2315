using System;

class Program
{
    static void Main()
    {
        
        Console.Write("a: ");
        double number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("b: ");
        double number2 = Convert.ToInt32(Console.ReadLine());

        double result = MaxBetweenTwo(number1, number2);

        // Print the result
	Console.WriteLine($"a: {number1}; b: {number2}");
        Console.WriteLine($"The largest number is: {result}");
    }

    
    static double MaxBetweenTwo(double num1, double num2)
    {

        return Math.Max(num1, num2);
    }
}