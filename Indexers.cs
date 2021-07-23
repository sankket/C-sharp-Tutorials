//An indexer is a special type of property that allows a class or a structure to be accessed like an array for its internal collection.
class StringDataStore
{
    private string[] strArr = new string[10]; // internal data storage

public string this[int index] // can be defined as like the properties with this keyword and [] brackets.
    {
        get
        {
            if (index < 0 || index >= strArr.Length)
                throw new IndexOutOfRangeException("Index out of range");

                return strArr[index];
        }

        set
        {
            if (index < 0 ||  index >= strArr.Length)
                throw new IndexOutOfRangeException("Index out of range");

            strArr[index] = value;
        }
    }
}
