using DataStructures.Shared;

namespace DataStructures._01_Arrays
{
    /// <summary>
    /// Contains methods to test the functionality of the CustomArray class.
    /// </summary>
    public static class CustomArrayTests
    {
        /// <summary>
        /// Executes the tests for the CustomArray class.
        /// </summary>
        public static void Execute()
        {
            var numbers = new CustomArray(3);

            TestInsert(numbers);
            TestIncrease(numbers);
            TestRemoveAt(numbers);
            TestIndexOf(numbers);
            TestMax(numbers);
            TestIntersect(numbers);
            TestReverse();
            TestInsertAt();
        }

        private static void TestInsert(CustomArray numbers)
        {
            ConsoleUtilities.PrintTitle("Testing the Insert method");

            numbers.Insert(1);
            numbers.Insert(2);
            numbers.Insert(3);
            numbers.Print();
        }

        private static void TestIncrease(CustomArray numbers)
        {
            ConsoleUtilities.PrintTitle("Testing the Increase method");

            numbers.Insert(4);
            numbers.Print();
        }

        private static void TestRemoveAt(CustomArray numbers)
        {
            ConsoleUtilities.PrintTitle("Testing the RemoveAt method");

            numbers.RemoveAt(3);
            numbers.Print();
            numbers.RemoveAt(2);
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
        }

        private static void TestIndexOf(CustomArray numbers)
        {
            ConsoleUtilities.PrintTitle("Testing the IndexOf method");

            Console.WriteLine($"Index of number 3: {numbers.IndexOf(3)}");
            Console.WriteLine($"Index of number 2: {numbers.IndexOf(2)}");
            Console.WriteLine($"Index of number 1: {numbers.IndexOf(1)}");
            Console.WriteLine($"Index of number 4: {numbers.IndexOf(100)}\n");
        }

        private static void TestMax(CustomArray numbers)
        {
            ConsoleUtilities.PrintTitle("Testing the Max method");

            numbers.Insert(10);
            numbers.Insert(8);
            numbers.Insert(7);
            numbers.Insert(9);

            numbers.Print();

            Console.WriteLine($"Max number: {numbers.Max()}\n");
        }

        private static void TestIntersect(CustomArray numbers)
        {
            ConsoleUtilities.PrintTitle("Testing the Intersect method");

            var intersectTest = new CustomArray(5);
            
            intersectTest.Insert(1);
            intersectTest.Insert(3);
            intersectTest.Insert(14);
            intersectTest.Insert(12);
            intersectTest.Insert(9);
            
            numbers.Print();
            
            intersectTest.Print();
            
            numbers.Intersect(intersectTest).Print();
        }

        private static void TestReverse()
        {
            ConsoleUtilities.PrintTitle("Testing the Reverse method");

            var reverseTest = new CustomArray(5);

            reverseTest.Insert(1);
            reverseTest.Insert(2);
            reverseTest.Insert(3);
            reverseTest.Insert(4);
            reverseTest.Insert(5);
            
            reverseTest.Reverse().Print();
            
            reverseTest.Print();
        }

        private static void TestInsertAt()
        {
            ConsoleUtilities.PrintTitle("Testing the InsertAt method");

            var insertAtTest = new CustomArray(3);

            insertAtTest.Insert(1);
            insertAtTest.Insert(3);
            insertAtTest.Insert(4);

            insertAtTest.Print();

            Console.WriteLine("Index: 1, Value: 2...\n");

            insertAtTest.InsertAt(1, 2);

            insertAtTest.Print();

            Console.WriteLine("Index: 0, Value: 0...\n");

            insertAtTest.InsertAt(0, 0);

            insertAtTest.Print();

            Console.WriteLine("Index: 4, Value: 5...\n");

            insertAtTest.InsertAt(4, 5);

            insertAtTest.Print();

            Console.WriteLine("Index: 5, Value: 1...\n");

            insertAtTest.InsertAt(5, 1);

            insertAtTest.Print();
        }
    }
}
