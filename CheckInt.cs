using System;
using System.Collections.Generic;

public class CheckInt {
  static void Main(string[] args)
        {
           Console.WriteLine("\nInput first integer:");  
           int x = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Input second integer:");  
           int y = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Check if one is negative and one is positive:");
           Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));
        }
}
//enter two number and the code will check if the entered number is Positive or Negetive.
