using DataStructures.Shared;

namespace DataStructures._05_HashTables
{
    /// <summary>
    /// Provides methods to test hash table algorithms.
    /// </summary>
    public static class HashTableTests
    {
        /// <summary>
        /// Executes the hash table tests.
        /// </summary>
        public static void Execute()
        {
            TestTheFindFirstNonRepeatingCharAlgorithm("a green apple");
            TestTheFirstRepeatedCharAlgorithm("green apple");
            TestHashTable();
        }

        private static void TestTheFindFirstNonRepeatingCharAlgorithm(string input)
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

        private static void TestTheFirstRepeatedCharAlgorithm(string input)
        {
            ConsoleUtilities.PrintTitle("First Repeated Char");

            if (string.IsNullOrEmpty(input))
            {
                throw new InvalidOperationException("The input is invalid");
            }

            var hashTable = new HashSet<char>();

            var repeatedChar = input.FirstOrDefault(item => !hashTable.Add(item));

            Console.WriteLine($"Input: {input}\n");

            Console.WriteLine(repeatedChar == default
                ? "There are not repeated char"
                : $"The first repeated char is '{repeatedChar}'");
        }

        private static void TestHashTable()
        {
            ConsoleUtilities.PrintTitle("Hash Table");

            var hashTable = new HashTable();

            hashTable.Put(1, "a");
            hashTable.Put(2, "b");
            hashTable.Put(3, "c");
            hashTable.Put(4, "d");
            hashTable.Put(5, "e");
            hashTable.Put(6, "f");
            hashTable.Put(6, "g");
            hashTable.Put(11, "h");

            Console.WriteLine($"Key = {1}, Value = {hashTable.Get(1) ?? "?"}");
            Console.WriteLine($"Key = {6}, Value = {hashTable.Get(6) ?? "?"}");
            Console.WriteLine($"Key = {10}, Value = {hashTable.Get(10) ?? "?"}");
            Console.WriteLine($"Key = {11}, Value = {hashTable.Get(11) ?? "?"}");

            hashTable.Remove(3);
            Console.WriteLine($"Key = {6}, Value = {hashTable.Get(3) ?? "?"}");
        }
    }
}
