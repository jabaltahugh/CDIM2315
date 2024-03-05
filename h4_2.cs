using System;

class Program
{
    static void Main()
    {
        
        Console.Write("N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.Write("shape is: ");
        string shape = Console.ReadLine().ToLower();

        // Call the method to print the triangle
        drawPattern(N, shape);
    }

    static void drawPattern(int N, string shape)
    {
        Console.WriteLine($"N: {N}, Shape = {shape}");

        if (shape == "left")
        {
        
            for (int i = 0; i <N; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
         else if (shape == "right")
        {
            
            for (int i = 0; i < N; i++)
            {
                for (int j = N - i-1; j >0; j--)
                {
                    Console.Write("+");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}