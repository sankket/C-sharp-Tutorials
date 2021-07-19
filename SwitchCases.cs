//The switch statement can be used instead of if else statement when you want to test a variable against three or more conditions.

int x = 10;

switch (x) //x is the matched expression. the result is specified in the curly braces.
{ 
    case 5:
        Console.WriteLine("Value of x is 5");
        break;
        //The break, return, or goto keyword is used to exit the program control from a switch case.
    case 10:
        Console.WriteLine("Value of x is 10");
        break;
    case 15:
        Console.WriteLine("Value of x is 15");
        break;
    default:
        Console.WriteLine("Unknown value");
        break;
}
