public class ExcelDocument : IDocument
{
    public void Open() => Console.WriteLine("Opening Excel document");
    public void Close() => Console.WriteLine("Closing Excel document");
}
