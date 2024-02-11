namespace DataStructures._05_HashTables;

/// <summary>
/// Initializes a new instance of the Entry class with the specified key and value.
/// </summary>
/// <param name="key">The key of the entry.</param>
/// <param name="value">The value of the entry.</param>
public class Entry(int key, string value)
{
    /// <summary>
    /// Gets or sets the key of the entry.
    /// </summary>
    public int Key { get; init; } = key;

    /// <summary>
    /// Gets or sets the value of the entry.
    /// </summary>
    public string Value { get; set; } = value;
}