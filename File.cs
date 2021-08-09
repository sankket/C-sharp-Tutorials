//various classess can be used to create file, directories, read and write the files, copy the files and many more releted to the file handling.

// File is a static class that provides different functionalities like copy, create, move, delete, open for reading or /writing, encrypt or decrypt

string dummyLines = "This is first line." + Environment.NewLine +
                    "This is second line." + Environment.NewLine +
                    "This is third line.";

//Opens DummyFile.txt and append lines. If file is not exists then create and open.
File.AppendAllLines(@"C:\DummyFile.txt", dummyLines.Split(Environment.NewLine.ToCharArray()).ToList<string>());

//the above code will create the file with the 3 lines.

//Check whether file is exists or not at particular location
bool isFileExists = File.Exists(@"C:\ DummyFile.txt"); // returns false

//Copy DummyFile.txt as new file DummyFileNew.txt
File.Copy(@"C:\DummyFile.txt", @"D:\NewDummyFile.txt");

//Get when the file was accessed last time 
DateTime lastAccessTime = File.GetLastAccessTime(@"C:\DummyFile.txt");

//get when the file was written last time
DateTime lastWriteTime = File.GetLastWriteTime(@"C:\DummyFile.txt");

// Move file to new location
File.Move(@"C:\DummyFile.txt", @"D:\DummyFile.txt");

//Open file and returns FileStream for reading bytes from the file
FileStream fs = File.Open(@"D:\DummyFile.txt", FileMode.OpenOrCreate);

//Open file and return StreamReader for reading string from the file
StreamReader sr = File.OpenText(@"D:\DummyFile.txt");
    
//Delete file
File.Delete(@"C:\DummyFile.txt");
