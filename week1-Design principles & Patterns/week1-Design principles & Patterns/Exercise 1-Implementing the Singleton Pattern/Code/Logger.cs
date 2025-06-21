public sealed class Logger
{
    // Private static instance
    private static readonly Lazy<Logger> _instance = 
        new Lazy<Logger>(() => new Logger());
    
    // Private constructor
    private Logger() {}
    
    // Public static accessor
    public static Logger Instance => _instance.Value;
    
    // Logging method
    public void Log(string message)
    {
        Console.WriteLine($"[LOG] {DateTime.Now}: {message}");
    }
}
