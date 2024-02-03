using System;
public class SmallestNumberFinder
{
  public static void Main(string[] args)
  {
     Console.WriteLine("Please input the first num:");
     int num1 = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Please input the second num:");
     int num2 = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Please input the third num:");
     int num3 = Convert.ToInt32(Console.ReadLine());
     int smallest = FindSmallest(num1, num2, num3);
     Console.WriteLine($"The smallest value is: {smallest}");
   }
  private static int FindSmallest(int a, int b, int c)
  {
      int smallest;
      if (a < b)
      {
          if (a < c)
          {
          smallest = a;
          }
          else
          {
          smallest = c;
    }
    }
    else
    {
      if (b < c)
      {
          smallest = b;
    }
      else
      {
          smallest = c;
          }
    } return smallest;
  }
}
