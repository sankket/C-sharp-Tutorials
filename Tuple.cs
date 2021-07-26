// A tuple is a data structure that contains a sequence of elements of different data types.
// A tuple can only include a maximum of eight elements.

tatic void Main(string[] args)
{
    var person = Tuple.Create(1, "Sanket", "Godbole");
    DisplayTuple(person);
}

static void DisplayTuple(Tuple<int,string,string> person)
{
    Console.WriteLine($"Id = { person.Item1}");
    Console.WriteLine($"First Name = { person.Item2}");
    Console.WriteLine($"Last Name = { person.Item3}");
}
