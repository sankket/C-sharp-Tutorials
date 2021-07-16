// class is blueprint of the object.
// it has some methods,properties, fields and events.
// A class enables you to create your custom types by grouping variables of other types, methods, and events.

// public is access modifier, there are 4 access modifier : public, private, protected, and internal in c#.
public class MyClass 
{
    public string  myField = string.Empty;

    public MyClass()
    {
        // The constructor is called when you create an instance of the class.
    }

    public void MyMethod(int parameter1, string parameter2)
    {
        Console.WriteLine("First Parameter {0}, second parameter {1}", 
                                                    parameter1, parameter2);
    }

    // A property can be defined using getters and setters. it is an auto implemented property.
    public int MyAutoImplementedProperty { get; set; }

    private int myPropertyVar;
    
    public int MyProperty
    {
        get { return myPropertyVar; }
        set { myPropertyVar = value; }
    } 
}
