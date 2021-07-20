//In C#, static means something which cannot be instantiated. You cannot create an object of a static class and cannot access static members using an object.
// static keyword is used.

public static class Calculator
{
    private static int _resultStorage = 0;
    
    public static string Type = "Arithmetic";

    public static int Sum(int num1, int num2)
    {
        return num1 + num2;
    }

    public static void Store(int result)
    {
        _resultStorage = result;
    }
}

// static class can be access directly using className.memberName.
