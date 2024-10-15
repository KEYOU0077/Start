// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Reading and Writing data from and to files

// Make sure the example file exists
const string filename = "TestFile.txt";
// 1: WriteAllText overwrites a file with the given content
if (!File.Exists(filename)) {
File.WriteAllText(filename, "This is a text file. ");
}
// 3: AppendAllText adds text to an existing file
File.AppendAllText(filename, "This text gets appended to the file. ");
// 4: A FileStream can be opened and written to until closed
using (StreamWriter sw = File.AppendText(filename)) {
sw.WriteLine("Line 1");
sw.WriteLine("Line 2");
sw.WriteLine("Line 3");
}
// 2: ReadAllText reads all the content from a file
string content;
content = File.ReadAllText(filename);
Console.WriteLine(content);

//creating new directories
const string dirname = "TestDir";
if (!Directory.Exists(dirname)) {
 Directory.CreateDirectory(dirname);
}
else {
 Directory.Delete(dirname);
}

//get and print current directory
string curpath = Directory.GetCurrentDirectory();
Console.WriteLine($"Current directory is {curpath}");

//
DirectoryInfo di = new DirectoryInfo(curpath);
Console.WriteLine($"{di.Name}");
Console.WriteLine($"{di.Parent}");
Console.WriteLine($"{di.CreationTime}");
Console.WriteLine("---------------");

//enumerate the contents of directories

Console.WriteLine("Just directories:");
List<string> thedirs = new
List<string>(Directory.EnumerateDirectories(curpath));
foreach (string dir in thedirs) {
 Console.WriteLine(dir);
}
Console.WriteLine("---------------");
