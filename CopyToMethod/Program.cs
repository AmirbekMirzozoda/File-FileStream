try
{
    // Path to the source image
    string sourceImagePath = "files/demo.png";
    // Path to the destination image
    string destinationImagePath = "newfiles/demo.png";

    File.Copy(sourceImagePath, destinationImagePath, overwrite: true);

    Console.WriteLine("Image copied successfully.");
}
catch (IOException IOEx)
{
    Console.WriteLine("An IO error occurred: " + IOEx.Message);
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}






