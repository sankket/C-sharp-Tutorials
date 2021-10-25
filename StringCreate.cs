using System;
using System.Collections.Generic;

public class CreateString {
  static void Main(string[] args)
        {
            Console.WriteLine(first_last("Sanket"));
            Console.WriteLine(first_last("Python"));
            Console.WriteLine(first_last("India"));
        }
       public static string first_last(string ustr)
        {
            return ustr.Length > 1
                ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
        }
}
