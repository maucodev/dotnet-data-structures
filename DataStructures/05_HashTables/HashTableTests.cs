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
            TestMostFrequent();
            TestCountPairsWithKDifference();
            TestTwoSum();
        }

        private static void TestTheFindFirstNonRepeatingCharAlgorithm(string input)
        {
            ConsoleUtilities.PrintHeaderTitle("Find the First Non Repeating Char");

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
            ConsoleUtilities.PrintHeaderTitle("First Repeated Char");

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
            ConsoleUtilities.PrintHeaderTitle("Hash Table");

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

        private static void TestMostFrequent()
        {
            ConsoleUtilities.PrintHeaderTitle("Most Frequent");

            var input = new[] { 1, 2, 2, 3, 3, 3, 4 };
            
            var hashTable = new Dictionary<int, int>();

            foreach (var item in input)
            {
                if (!hashTable.TryAdd(item, 1))
                {
                    hashTable[item]++;
                }
            }

            Console.WriteLine($"The most frequent value is: {hashTable.MaxBy(item => item.Value).Value}");
        }

        private static void TestCountPairsWithKDifference(int k = 2)
        {
            ConsoleUtilities.PrintHeaderTitle("Count Pairs With 'K' Difference");

            var totalPairs = 0;
            var input = new[] { 1, 7, 5, 9, 2, 12, 3 };

            var hashTable = new HashSet<int>(input);

            foreach (var item in input)
            {
                if (hashTable.Contains(item + k))
                {
                    totalPairs++;
                }

                if (hashTable.Contains(item - k))
                {
                    totalPairs++;
                }

                hashTable.Remove(item);
            }

            Console.WriteLine($"The total pairs with difference of {k} is: {totalPairs}");
        }

        private static void TestTwoSum(int target = 9)
        {
            ConsoleUtilities.PrintHeaderTitle("Two SUM");

            var input = new[] { 2, 7, 11, 15 };

            var hashTable = new Dictionary<int, int>();

            for (var i = 0; i < input.Length; i++)
            {
                var complement = target - input[i];

                if (hashTable.TryGetValue(complement, out var value))
                {
                    var result = new [] { value, i };

                    Console.WriteLine($"The item at index'[{result[0]}]={input[result[0]]} + [{result[1]}]={input[result[1]]} is equal to {target}");

                    return;
                }

                hashTable.Add(input[i], i);
            }

            Console.WriteLine($"There are not two elements witch their sum is equal to {target}");
        }
    }
}
