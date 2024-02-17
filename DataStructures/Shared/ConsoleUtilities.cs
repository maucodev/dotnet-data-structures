namespace DataStructures.Shared;

/// <summary>
/// Provides utility methods for console output.
/// </summary>
public static class ConsoleUtilities
{
    /// <summary>
    /// Prints a title with visual formatting in the console.
    /// </summary>
    /// <param name="title">The title to print.</param>
    public static void PrintHeaderTitle(string title)
    {
        Console.WriteLine();
        Console.WriteLine(new string('-', 40));
        Console.WriteLine($"   {title.ToUpper()}   ");
        Console.WriteLine(new string('-', 40));
        Console.WriteLine();
    }
}