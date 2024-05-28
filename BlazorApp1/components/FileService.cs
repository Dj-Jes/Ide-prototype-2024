namespace BlazorApp1.components;

public class FileService : IFileService
{
    private readonly List<UploadedFile> Files = new List<UploadedFile>();

    public UploadedFile PostFile(int itemId, string name, byte[] content, string preview)
    {
        Console.WriteLine("Entering PostFile method...");
        Console.WriteLine($"Item ID: {itemId}, File Name: {name}, Content Length: {content.Length}, Preview Length: {preview.Length}");

        var file = new UploadedFile
        {
            ItemId = itemId,
            Name = name,
            Content = content,
            Preview = preview,
        };

        Files.Add(file);

        Console.WriteLine("File added to the list.");
        Console.WriteLine($"Total number of files: {Files.Count}");

        return file;
    }

    public List<UploadedFile> GetFiles()
    {
        Console.WriteLine("Entering GetFiles method...");
        Console.WriteLine($"Number of files retrieved: {Files.Count}");
        return Files;
    }
}


    
