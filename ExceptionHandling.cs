// Exceptions in the application must be handled to prevent crashing of the program and unexpected result. its an unexpected error which disrupts the normal execution of code.
// C# provides built-in support to handle the exception using try, catch & finally blocks.

class Program
{
    static void Main(string[] args)
    {
        // The code which you think might throw an error should be placed into the try block.
        try
        {
            Console.WriteLine("Enter a number: ");

            var num = int.parse(Console.ReadLine());

            Console.WriteLine($"Squre of {num} is {num * num}");
        }
        // if the exception occurs then catch block will be exwcuted.
        catch
        {
            Console.Write("Error occurred.");
        }
        // finally block a;ways executes.
        finally
        {
            Console.Write("Try again with a different number.");
        }
    }
}

