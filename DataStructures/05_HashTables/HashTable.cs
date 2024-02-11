namespace DataStructures._05_HashTables;

/// <summary>
/// Represents a hash table data structure.
/// </summary>
public class HashTable
{
    private readonly LinkedList<Entry>?[] _entries = new LinkedList<Entry>[5];

    /// <summary>
    /// Finds the entry with the specified key in the given bucket.
    /// </summary>
    /// <param name="key">The key to search for.</param>
    /// <param name="bucket">The bucket to search in.</param>
    /// <returns>The entry with the specified key, or null if not found.</returns>
    private static Entry? FindItem(int key, IEnumerable<Entry>? bucket)
    {
        return bucket?.FirstOrDefault(entry => entry.Key == key);
    }

    /// <summary>
    /// Retrieves the value associated with the specified key.
    /// </summary>
    /// <param name="key">The key to search for.</param>
    /// <returns>The value associated with the key, or null if the key is not found.</returns>
    public string? Get(int key)
    {
        return GetItem(key)?.Value;
    }

    /// <summary>
    /// Retrieves the bucket (linked list) at the specified index in the entries array.
    /// </summary>
    /// <param name="index">The index of the bucket.</param>
    /// <returns>The bucket at the specified index, or null if the index is out of range.</returns>
    private LinkedList<Entry>? GetBucket(int index)
    {
        return _entries[index];
    }

    /// <summary>
    /// Finds the entry with the specified key in the given bucket.
    /// </summary>
    /// <param name="key">The key to search for.</param>
    /// <returns>The entry with the specified key, or null if not found.</returns>
    private Entry? GetItem(int key)
    {
        var bucket = GetBucket(index: Hash(key));
        return FindItem(key, bucket);
    }

    /// <summary>
    /// Finds the entry with the specified key in the given bucket.
    /// </summary>
    /// <param name="key">The key to search for.</param>
    /// <param name="bucket">The bucket to search in.</param>
    /// <returns>The entry with the specified key, or null if not found.</returns>
    private static Entry? GetItem(int key, IEnumerable<Entry>? bucket)
    {
        return bucket?.Where(entry => entry.Key == key)
            .Take(1)
            .FirstOrDefault();
    }

    /// <summary>
    /// Calculates the hash value for the given key.
    /// </summary>
    /// <param name="key">The key to hash.</param>
    /// <returns>The hash value.</returns>
    private int Hash(int key)
    {
        return key % _entries.Length;
    }

    /// <summary>
    /// Adds a new key-value pair to the hash table or updates the value if the key already exists.
    /// </summary>
    /// <param name="key">The key of the entry.</param>
    /// <param name="value">The value of the entry.</param>
    public void Put(int key, string value)
    {
        var index = Hash(key);

        var bucket = _entries[index] ??= [];

        var item = GetItem(key, bucket);

        if (item == null)
        {
            bucket.AddLast(new Entry(key, value));
        }
        else
        {
            item.Value = value;
        }
    }

    /// <summary>
    /// Removes the entry with the specified key from the hash table.
    /// </summary>
    /// <param name="key">The key of the entry to remove.</param>
    /// <exception cref="ArgumentException">Thrown when the specified key does not exist in the hash table.</exception>
    public void Remove(int key)
    {
        var bucket = GetBucket(index: Hash(key)) ?? throw new ArgumentException("The item doesn't exist");

        if (!RemoveItem(key, bucket))
        {
            throw new ArgumentException("The item doesn't exist");
        }
    }

    /// <summary>
    /// Removes the entry with the specified key from the given bucket.
    /// </summary>
    /// <param name="key">The key of the entry to remove.</param>
    /// <param name="bucket">The bucket from which to remove the entry.</param>
    /// <returns>True if the entry was successfully removed, false otherwise.</returns>
    private static bool RemoveItem(int key, LinkedList<Entry>? bucket)
    {
        if (bucket == null)
        {
            return false;
        }

        var item = FindItem(key, bucket);

        if (item == null)
        {
            return false;
        }

        bucket.Remove(item);

        return true;
    }
}