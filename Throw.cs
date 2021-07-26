//An exception can be raised manually by using the throw keyword.
static void Main(string[] args)
{
    Student std = null;

    try
    {
        PrintStudentName(std);
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message );
    }                      

    Console.ReadKey();
}

private static void PrintStudentName( Student std)
{
    if (std  == null)
        throw new NullReferenceException("Student object is null.");
        
    Console.WriteLine(std.StudentName);
}
