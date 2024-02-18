using DataStructures.Shared;

namespace DataStructures._08_Heaps;

/// <summary>
/// Contains methods for testing the functionality of the Heap class.
/// </summary>
public static class HeapTests
{
    /// <summary>
    /// Executes tests to verify the functionality of the Heap class.
    /// </summary>
    public static void ExecuteTests()
    {
        TestHeap();
    }

    private static void TestHeap()
    {
        ConsoleUtilities.PrintHeaderTitle("Heap");

        var heap = new Heap();

        heap.Insert(10);
        heap.Insert(5);
        heap.Insert(17);
        heap.Insert(4);
        heap.Insert(22);
    }
}