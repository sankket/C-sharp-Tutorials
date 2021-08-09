//various classess can be used to create file, directories, read and write the files, copy the files and many more releted to the file handling.

// File is a static class that provides different functionalities like copy, create, move, delete, open for reading or /writing, encrypt or decrypt

string dummyLines = "This is first line." + Environment.NewLine +
                    "This is second line." + Environment.NewLine +
                    "This is third line.";

//Opens DummyFile.txt and append lines. If file is not exists then create and open.
File.AppendAllLines(@"C:\DummyFile.txt", dummyLines.Split(Environment.NewLine.ToCharArray()).ToList<string>());

//the above code will create the file with the 3 lines.
