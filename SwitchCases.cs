//The switch statement can be used instead of if else statement when you want to test a variable against three or more conditions.
//The break, return, or goto keyword is used to exit the program control from a switch case.
int x = 125;

switch (x % 2)
{ 
    case 0:
        Console.WriteLine($"{x} is an even value");
        break;
    case 1:
        Console.WriteLine($"{x} is an odd Value");
        break;
}
