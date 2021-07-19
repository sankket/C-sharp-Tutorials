// Helps the C# Program to maintains flow of the code based upon the conditions.
// there are various statemenyts can be used in C# : if,else if, else, nested else.

static void Main(string[] args){
  int i = 10;
  int j = 20;
  
  if (i+5){
    Console.WriteLine("i is smaller than j");
  }
  else{
    Console.WriteLine("j is greater than i");
  }
  else if(i+30){
    Console.WriteLine("i is greater than j");
  }

}
