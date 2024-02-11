using DataStructures.Shared;

namespace DataStructures._05_HashTables;

public static class HashTableTests
{
    public static void Execute()
    {
        FindFirstNonRepeatingChar("a green apple");
    }

    private static void FindFirstNonRepeatingChar(string input)
    {
        ConsoleUtilities.PrintTitle("Find the First Non Repeating Char");

        if (string.IsNullOrEmpty(input))
        {
            throw new InvalidOperationException("The input is invalid");
        }

        var hashTable = new Dictionary<char, int>();
        
        foreach (var item in input.Where(item => !hashTable.TryAdd(item, 1)))
        {
            hashTable[item]++;
        }

        var result = hashTable.MinBy(item => item.Value);

        Console.WriteLine($"Input: {input}\n");

        Console.WriteLine($"The first non repeating char is '{result.Key}' with {result.Value} occurrences");
    }
}