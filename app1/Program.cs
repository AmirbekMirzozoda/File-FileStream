using Newtonsoft.Json;

using System.IO;
using System.IO.Enumeration;
using System.Reflection.Metadata;



var currentDir = Directory.GetCurrentDirectory();
Console.WriteLine("currentDir: " + currentDir);



string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
Console.WriteLine("docPath: " + docPath);



// PATH 
Console.WriteLine($"files{Path.DirectorySeparatorChar}stores.json"); // stores\201 on Windows
// stores/201 on macOS

//Join paths
Console.WriteLine(Path.Combine("stores", "201")); // outputs: stores/201
Console.WriteLine(Path.Combine(Directory.GetCurrentDirectory(), "files", "demo", "stores.json")); // outputs: stores/201

//Determine filename extensions
Console.WriteLine(Path.GetExtension("Program.cs")); // outputs: .cs



string fileName = Path.Combine(Directory.GetCurrentDirectory(), "files", "salesTotalDir", "totals(1).txt");
FileInfo info = new FileInfo(fileName);
Console.WriteLine(@$"
        Full Name: {info.FullName}{Environment.NewLine}
        Directory: {info.Directory}{Environment.NewLine}
        Extension: {info.Extension}{Environment.NewLine}
        Create Date: {info.CreationTime}"
        ); // And many more



//Create Directory
var currentDirectory = Directory.GetCurrentDirectory();
var storesDirectory = Path.Combine(currentDirectory, "files");

var salesTotalDir = Path.Combine(storesDirectory, "salesTotalDir");
Directory.CreateDirectory(salesTotalDir);



//Create a file with empty string
File.WriteAllText(Path.Combine(salesTotalDir, "totals(1).txt"), "hello dear students\n this is new demo");


var alltext = File.ReadAllText(Path.Combine(salesTotalDir, "totals(1).txt"));
Console.WriteLine("alltext: " + alltext);
// {
//     "total": 20
// }

Console.ReadLine();

//dotnet add package Newtonsoft.Json - to serialize and deserialize json data
var studentsJson = File.ReadAllText(Path.Combine("files", "students.json"));
var studentsObject = JsonConvert.DeserializeObject<List<Student>>(studentsJson);
var serialized = JsonConvert.SerializeObject(studentsObject); //json
Console.WriteLine("serialized: " + serialized);


Console.ReadLine();


//overwrite entire text
File.WriteAllText(Path.Combine("files", "total.txt"), studentsObject.Count.ToString());
// totals.txt
// 3

//Append data to files
File.AppendAllText(Path.Combine("files", "total.txt"), "Хамаги донишчуён!");
Console.ReadLine();

// totals.txt
// 22385.32
// 22385.32

//delete the file
var path = Path.Combine("files", "total.txt");
if (File.Exists(path))
{
    File.Delete(path);
    Console.WriteLine("Deleted the file successfully.");
}

Console.ReadLine();

var response = File.Create(path);



class Student
{
    public string Name { get; set; }
}


