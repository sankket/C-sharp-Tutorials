//generic means not specific to a particular data type.
//A generic type is declared by specifying a type parameter in an angle brackets after a type name, e.g. TypeName<T> where T is a type parameter.

class DataStore<T>
{
    public T Data { get; set; }
}

DataStore<string> store = new DataStore<string>();
