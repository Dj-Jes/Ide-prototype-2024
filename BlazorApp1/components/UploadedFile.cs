namespace BlazorApp1.components;

public class UploadedFile
{
    public string Name { get; set; }
    public byte[] Content { get; set; }
    public string Preview { get; set; }
    public string PredictedClass { get; set; }
}