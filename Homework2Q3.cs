namespace Homework2Q3;
class Program
{
 static void Main()
 {
    Console.Write("Assign an int value to N: ");
    int N = int.Parse(Console.ReadLine());
    for (int i = 1; i <= N; i++)
    {
       for (int j = 1; j <= i; j++)
       {
          Console.Write("*");
       }
        Console.WriteLine();
    }
  }
}