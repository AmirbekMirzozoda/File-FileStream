using (FileStream sourceStream = File.OpenRead("sourceFilePath"))
using (FileStream destinationStream = File.Create("destinationFilePath"))
{
    sourceStream.CopyTo(destinationStream);
}
