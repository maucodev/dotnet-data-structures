namespace DataStructures._08_Heaps;

/// <summary>
/// Represents a heap data structure with an optional initial capacity.
/// </summary>
/// <param name="capacity">The initial capacity of the heap (default is 10).</param>
public class Heap(int capacity = 10)
{
    private int _size;
    private readonly int[] _items = new int[capacity];

    private static int GetIndexParent(int index)
    {
        return (index - 1) / 2;
    }

    /// <summary>
    /// Checks whether the heap is full.
    /// </summary>
    /// <returns><c>true</c> if the heap is full; otherwise, <c>false</c>.</returns>
    public bool IsFull()
    {
        return _size == _items.Length;
    }

    /// <summary>
    /// Inserts a value into the heap.
    /// </summary>
    /// <param name="value">The value to insert into the heap.</param>
    public void Insert(int value)
    {
        if (IsFull())
        {
            throw new InvalidOperationException("The heap is full");
        }

        _items[_size++] = value;

        BubbleUp();
    }

    private void BubbleUp()
    {
        var index = _size - 1;

        while (index > 0 && _items[index] > _items[GetIndexParent(index)])
        {
            Swap(index, GetIndexParent(index));

            index = GetIndexParent(index);
        }
    }

    private void Swap(int first, int second)
    {
        (_items[first], _items[second]) = (_items[second], _items[first]);
    }
}