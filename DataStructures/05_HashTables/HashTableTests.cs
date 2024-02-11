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
        }

        /// <summary>
        /// Tests the FindFirstNonRepeatingCharAlgorithm method.
        /// </summary>
        /// <param name="input">The input string.</param>
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

        /// <summary>
        /// Tests the FirstRepeatedCharAlgorithm method.
        /// </summary>
        /// <param name="input">The input string.</param>
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
    }
}
