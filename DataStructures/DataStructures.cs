using DataStructures._01_Arrays;

namespace DataStructures
{
    public static class DataStructures
    {
        public static void Main()
        {
            TestArray();

            Console.ReadLine();
        }

        public static void TestArray()
        {
            var numbers = new CustomArray(3);

            Console.WriteLine("Testing the Insert method...\n");
            numbers.Insert(1);
            numbers.Insert(2);
            numbers.Insert(3);
            numbers.Print();

            Console.WriteLine("Testing the Increase method...\n");
            numbers.Insert(4);
            numbers.Print();

            Console.WriteLine("Testing the RemoveAt at method...\n");
            numbers.RemoveAt(0);
            numbers.Print();
            numbers.RemoveAt(1);
            numbers.Print();
            numbers.RemoveAt(1);
            numbers.Print();
            numbers.RemoveAt(0);
            numbers.Print();

            Console.WriteLine("Restoring the array...\n");
            numbers.Insert(1);
            numbers.Insert(2);
            numbers.Insert(3);
            numbers.Print();

            Console.WriteLine("Testing the IndexOf method...\n");
            Console.WriteLine($"Index of number 3: {numbers.IndexOf(3)}");
            Console.WriteLine($"Index of number 2: {numbers.IndexOf(2)}");
            Console.WriteLine($"Index of number 1: {numbers.IndexOf(1)}");
            Console.WriteLine($"Index of number 4: {numbers.IndexOf(100)}");
        }
    }
}
