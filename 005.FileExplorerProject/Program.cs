using System.Text;

Console.WriteLine("Simple File Explorer");
Console.WriteLine("Enter the path of the directory:");
string directoryPath = Console.ReadLine();

// Display files in the directory
string[] files = Directory.GetFiles(directoryPath);
Console.WriteLine("Files:");
for (int i = 0; i < files.Length; i++)
{
    Console.WriteLine($"{i + 1}. {Path.GetFileName(files[i])}");
}

// Create a new file
Console.WriteLine("Enter the name of the new file (e.g., myfile.txt):");
string newFileName = Console.ReadLine();
string newFilePath = Path.Combine(directoryPath, newFileName);
using (FileStream fs = File.Create(newFilePath))
{
    Console.WriteLine("New file created.");
}

// Read content from a file
Console.WriteLine("Enter the number of the file to read:");
int fileToReadIndex = Convert.ToInt32(Console.ReadLine()) - 1;
string fileToReadPath = files[fileToReadIndex];
using (FileStream fs = File.OpenRead(fileToReadPath))
{
    byte[] b = new byte[1024];
    UTF8Encoding temp = new UTF8Encoding(true);
    while (fs.Read(b, 0, b.Length) > 0)
    {
        Console.WriteLine(temp.GetString(b));
    }
}

// Write content to a file
Console.WriteLine("Enter the number of the file to write/append:");
int fileToWriteIndex = Convert.ToInt32(Console.ReadLine()) - 1;
string fileToWritePath = files[fileToWriteIndex];
Console.WriteLine("Enter the text to write/append:");
string textToWrite = Console.ReadLine();
using (FileStream fs = File.OpenWrite(fileToWritePath))
{
    byte[] info = new UTF8Encoding(true).GetBytes(textToWrite);
    fs.Seek(0, SeekOrigin.End); // To append text to the file
    fs.Write(info, 0, info.Length);
}

Console.WriteLine("Operation completed.");