// covariance allows you to use a derived class where a base class is expected.
// usually you can not create instance of base class with the derived class , but using covariance you can do that.

public delegate Small covarDel(Big mc);

public class Program
{
    public static Big Method1(Big bg)
    {
        Console.WriteLine("Method1");
    
        return new Big();
    }
    public static Small Method2(Big bg)
    {
        Console.WriteLine("Method2");
    
        return new Small();
    }
        
    public static void Main(string[] args)
    {
        covarDel del = Method1;
        // here we used covariance.
        Small sm1 = del(new Big());

        del= Method2;
        Small sm2 = del(new Big());
    }
}

