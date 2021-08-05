// Extension methods allow you to inject additional methods without modifying, deriving or recompiling the original class, struct or interface.
using ExtensionMethods;

class Program
{
    static void Main(string[] args)
    {
        int i = 10;

        bool result = i.IsGreaterThan(100); 

        Console.WriteLine(result);
    }
}

// here the IsGreaterThan method is extension method.
// the extension method has special intellisense symbol in the IDE.
