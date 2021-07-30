// if we want to pass function as a parameter.
// The delegate is a reference type data type that defines the method signature.

public delegate void MyDelegate(string msg); // declare a delegate

// set target method
MyDelegate del = new MyDelegate(MethodA);
// or 
MyDelegate del = MethodA; 
// or set lambda expression 
MyDelegate del = (string msg) =>  Console.WriteLine(msg);

// target method
static void MethodA(string message)
{
    Console.WriteLine(message);
}


// Invoke Delegates.
del.Invoke("Hello World!");
// or 
del("Hello World!");
