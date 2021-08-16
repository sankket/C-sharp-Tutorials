using System;
class SwapNums {
  static void Main() {
    int num1, num2, temp;
    Console.Write("Enter the First Number : ");
    num1 = int.Parse(Console.ReadLine());
    Console.Write("Enter the Second Number : ");
    num2 = int.Parse(Console.ReadLine());
    
    temp = num1;
    num1 = num2;
    num2 = temp;
    
    Console.Write("First number : ",num1);
    Console.Write("Second number : ",num2);
    Console.Read();
  }
}
