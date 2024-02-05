namespace DataStructures._01_Arrays
{
    public static class CustomArrayTests
    {
        public static void Execute()
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

            Console.WriteLine("Testing the IndexOf method...\n");
            Console.WriteLine($"Index of number 3: {numbers.IndexOf(3)}");
            Console.WriteLine($"Index of number 2: {numbers.IndexOf(2)}");
            Console.WriteLine($"Index of number 1: {numbers.IndexOf(1)}");
            Console.WriteLine($"Index of number 4: {numbers.IndexOf(100)}\n");

            Console.WriteLine("Testing the Max method...\n");
            numbers.Insert(10);
            numbers.Insert(8);
            numbers.Insert(7);
            numbers.Insert(9);
            numbers.Print();
            Console.WriteLine($"Max number: {numbers.Max()}\n");

            Console.WriteLine("Testing the Intersect method...\n");
            var intersectTest = new CustomArray(5);
            intersectTest.Insert(1);
            intersectTest.Insert(3);
            intersectTest.Insert(14);
            intersectTest.Insert(12);
            intersectTest.Insert(9);
            numbers.Print();
            intersectTest.Print();
            numbers.Intersect(intersectTest).Print();

            Console.WriteLine("Testing the Reverse method...\n");
            var reverseTest = new CustomArray(5);
            reverseTest.Insert(1);
            reverseTest.Insert(2);
            reverseTest.Insert(3);
            reverseTest.Insert(4);
            reverseTest.Insert(5);
            reverseTest.Reverse().Print();
            reverseTest.Print();

            Console.WriteLine("Testing the InsertAt method...\n");
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
