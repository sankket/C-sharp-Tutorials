// split the implementation of the class into multiple .cs files.
// partial keyword is used in this case.
// one file contains one implementation of class and other can have different implemenrtation of it.

public partial class Employee
{
    public int EmpId { get; set; }
    public string Name { get; set; }
}
