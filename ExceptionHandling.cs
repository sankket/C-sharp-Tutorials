// Exceptions in the application must be handled to prevent crashing of the program and unexpected result. its an unexpected error which disrupts the normal execution of code.
// C# provides built-in support to handle the exception using try, catch & finally blocks.

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter a number: ");

            var num = int.parse(Console.ReadLine());

            Console.WriteLine($"Squre of {num} is {num * num}");
        }
        catch
        {
            Console.Write("Error occurred.");
        }
        finally
        {
            Console.Write("Re-try with a different number.");
        }
    }
}

