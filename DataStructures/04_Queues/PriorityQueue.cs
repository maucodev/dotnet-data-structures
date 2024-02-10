using System.Text;

namespace DataStructures._04_Queues;

/// <summary>
/// Represents a custom priority queue implementation.
/// </summary>
public class PriorityQueue
{
    private int _totalItems;

    private int[] _items = new int[1];

    /// <summary>
    /// Inserts an item into the priority queue.
    /// </summary>
    /// <param name="item">The item to insert.</param>
    public void Insert(int item)
    {
        if (IsEmpty())
        {
            _items[_totalItems++] = item;
            return;
        }

        if (IsFull())
        {
            Increase();
        }

        var i = ShiftItemsToInsert(item);

        _items[i] = item;

        _totalItems++;
    }

    /// <summary>
    /// Removes and returns the item with the highest priority from the priority queue.
    /// </summary>
    /// <returns>The item with the highest priority.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the queue is empty.</exception>
    public int Remove()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        return _items[--_totalItems];
    }

    /// <summary>
    /// Checks if the priority queue is empty.
    /// </summary>
    /// <returns>True if the queue is empty, otherwise false.</returns>
    private bool IsEmpty()
    {
        return _totalItems == 0;
    }

    /// <summary>
    /// Checks if the priority queue is full.
    /// </summary>
    /// <returns>True if the queue is full, otherwise false.</returns>
    private bool IsFull()
    {
        return _totalItems == _items.Length;
    }

    /// <summary>
    /// Increases the capacity of the internal array.
    /// </summary>
    private void Increase()
    {
        var items = new int[_totalItems * 2];

        for (var i = 0; i < _totalItems; i++)
        {
            items[i] = _items[i];
        }

        _items = items;
    }

    /// <summary>
    /// Shifts items to make space for the new item to be inserted.
    /// </summary>
    /// <param name="item">The item to insert.</param>
    /// <returns>The index where the new item should be inserted.</returns>
    private int ShiftItemsToInsert(int item)
    {
        int i;

        for (i = _totalItems - 1; i >= 0; i--)
        {
            if (_items[i] > item)
            {
                _items[i + 1] = _items[i];
            }
            else
            {
                break;
            }
        }

        return i + 1;
    }

    /// <summary>
    /// Returns a string representation of the priority queue.
    /// </summary>
    /// <returns>A string representing the contents of the priority queue.</returns>
    public override string ToString()
    {
        if (IsEmpty())
        {
            return "[ ]\n";
        }

        var result = new StringBuilder("[ ");

        for (var i = 0; i < _totalItems; i++)
        {
            result.Append($" {_items[i]} ");
        }

        result.Append(" ]\n");

        return result.ToString();
    }
}
