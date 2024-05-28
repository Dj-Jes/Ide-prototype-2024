namespace BlazorApp1.components;

public interface IFileService
{
    UploadedFile PostFile(int itemId, string name, byte[] content, string preview);

    List<UploadedFile> GetFiles();
    

}