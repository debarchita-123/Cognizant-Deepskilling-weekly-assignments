public class PdfDocument : IDocument
{
    public void Open() => Console.WriteLine("Opening PDF document");
    public void Close() => Console.WriteLine("Closing PDF document");
}
