using System.Text;

namespace DataStructures._08_Heaps;

/// <summary>
/// Represents a heap data structure with an optional initial capacity.
/// </summary>
/// <param name="capacity">The initial capacity of the heap (default is 10).</param>
public class Heap(int capacity = 10)
{
    private int _size;
    private readonly int[] _items = new int[capacity];

    private static int GetIndexLeftChild(int index)
    {
        return index * 2 + 1;
    }

    private static int GetIndexRightChild(int index)
    {
        return index * 2 + 2;
    }

    private static int GetIndexParent(int index)
    {
        return (index - 1) / 2;
    }

    /// <summary>
    /// Checks whether the heap is empty.
    /// </summary>
    /// <returns><c>true</c> if the heap is empty; otherwise, <c>false</c>.</returns>
    public bool IsEmpty()
    {
        return _size == 0;
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

    /// <summary>
    /// Removes and returns the node with the largest value from the heap.
    /// </summary>
    /// <returns>The value of the removed node, which is the largest value in the heap.</returns>
    public int Remove()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("The heap is empty");
        }

        var root = _items[0];

        _items[0] = _items[--_size];

        BubbleDown();

        return root;
    }

    /// <inheritdoc/>>
    public override string ToString()
    {
        var result = new StringBuilder("[");

        for (var i = 0; i < _size; i++)
        {
            result.Append($" {_items[i]} ");
        }

        result.Append(']');

        return result.ToString();
    }

    private void BubbleDown()
    {
        var index = 0;

        while (index <= _size && !IsValidParent(index))
        {
            var largerChildIndex = GetLargerChildIndex(index);
            Swap(index, largerChildIndex);
            index = largerChildIndex;
        }
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

    private bool HasLeftChild(int index)
    {
        return GetIndexLeftChild(index) <= _size;
    }

    private bool HasRightChild(int index)
    {
        return GetIndexRightChild(index) <= _size;
    }

    private int GetLargerChildIndex(int index)
    {
        if (!HasLeftChild(index))
        {
            return index;
        }

        if (!HasRightChild(index))
        {
            return GetIndexLeftChild(index);
        }

        return GetLeftChild(index) > GetRightChild(index)
            ? GetIndexLeftChild(index)
            : GetIndexRightChild(index);
    }

    private int GetLeftChild(int index)
    {
        return _items[GetIndexLeftChild(index)];
    }

    private int GetRightChild(int index)
    {
        return _items[GetIndexRightChild(index)];
    }

    private bool IsValidParent(int index)
    {
        if (!HasLeftChild(index))
        {
            return true;
        }

        var isValid = _items[index] >= GetLeftChild(index);

        if (HasRightChild(index))
        {
            isValid &= _items[index] >= GetRightChild(index);
        }

        return isValid;
    }

    private void Swap(int first, int second)
    {
        (_items[first], _items[second]) = (_items[second], _items[first]);
    }
}