// Object initializers allow you to assign values to the fields or properties at the time of creating an object without invoking a constructor.

public class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Student std = new Student() { StudentID = 06, 
                                      StudentName = "Sanket Godbole", 
                                      Age = 22, 
                                      Address = "Munich"   
                                    };
    }
}
