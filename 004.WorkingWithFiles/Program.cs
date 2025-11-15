
    for (int i = 1; i <= 100; i++)
    {
        using (FileStream sourceStream = File.OpenRead("videos\\myvideo.mp4")) 
        using (FileStream destinationStream = File.Create($"videos\\myvideo_copy({i}).mp4"))
        {
            sourceStream.CopyTo(destinationStream);
        }
    }
