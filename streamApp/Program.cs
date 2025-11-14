try
{
    // Path to the source image
    string sourceImagePath = "files/demo.png";

    // Path to the destination image
    string destinationImagePath = "newfiles/demo.png";
    if (!Directory.Exists("newfiles"))
        Directory.CreateDirectory("newfiles");
    // Read the source image into a byte array
    byte[] imageBytes = File.ReadAllBytes(sourceImagePath);

    // Write the byte array to a new file
    using (FileStream stream = new FileStream(destinationImagePath, FileMode.Create))
    {
        stream.Write(imageBytes, 0, imageBytes.Length);
    }

    Console.WriteLine("Image copied successfully.");
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}





