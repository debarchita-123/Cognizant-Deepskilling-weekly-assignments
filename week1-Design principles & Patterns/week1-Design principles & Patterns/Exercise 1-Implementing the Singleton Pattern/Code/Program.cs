class Program
{
    static void Main()
    {
        // Get logger instances
        Logger logger1 = Logger.Instance;
        Logger logger2 = Logger.Instance;
        
        // Verify singleton behavior
        Console.WriteLine($"Same instance? {ReferenceEquals(logger1, logger2)}");
        
        // Use logging functionality
        logger1.Log("Application started");
        logger2.Log("Performing critical operation");
        
        // Attempt to create new instance (will fail)
        // Logger logger3 = new Logger(); // Compiler error
    }
}
