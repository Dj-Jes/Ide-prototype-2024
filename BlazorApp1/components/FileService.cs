namespace BlazorApp1.components;

public class FileService : IFileService
{
    public List<UploadedFile> Files { get; set; } = new List<UploadedFile>();

    public UploadedFile PostFile(int itemId, string name, byte[] content, string preview)
    {
        var file = new UploadedFile
        {
            ItemId = itemId,
            Name = name,
            Content = content,
            Preview = preview,
        };

        Files.Add(file);

        return file;
    }

    public List<UploadedFile> GetFiles()
    {
        return Files;
    }
}