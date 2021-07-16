//An interface can contain declarations of methods, properties, indexers, and events.
// but it can not implement these method in the interface.

interface IFile
{
    void ReadFile();
    void WriteFile(string text);
}

class FileInfo : IFile
// in this code the FileInfo implements IFile.
{
    public void ReadFile()
    {
        Console.WriteLine("Reading File");
    }

    public void WriteFile(string text)
    {
        Console.WriteLine("Writing to file");
    }
}

//You cannot apply access modifiers to interface members.Interface cannot include private, protected, or internal members. All the members are public by default.
// You can implement one or more interfaces.
