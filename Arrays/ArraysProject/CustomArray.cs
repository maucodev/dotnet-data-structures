using System;
using System.Linq;

namespace ArraysProject;

/// <summary>
/// Represents a custom dynamic array with various utility methods.
/// </summary>
public class CustomArray
{
    private int[] _items;
    private int _totalItems;

    /// <summary>
    /// Initializes a new instance of the <see cref="CustomArray"/> class with the specified initial capacity.
    /// </summary>
    /// <param name="length">The initial capacity of the array.</param>
    public CustomArray(int length)
    {
        _items = new int[length];
    }

    /// <summary>
    /// Inserts an item at the end of the array. Resizes the array if it is full.
    /// </summary>
    /// <param name="item">The item to insert.</param>
    public void Insert(int item)
    {
        if (_items.Length == _totalItems)
        {
            Resize();
        }

        _items[_totalItems++] = item;
    }

    /// <summary>
    /// Removes the item at the specified index, shifting all subsequent elements left. Throws an exception if the index is out of range.
    /// </summary>
    /// <param name="index">The zero-based index of the item to remove.</param>
    /// <exception cref="ArgumentNullException">Thrown when the index is out of range.</exception>
    public void RemoveAt(int index)
    {
        if (index < 0 || index >= _totalItems)
        {
            throw new ArgumentNullException(nameof(index), "Value out of range");
        }

        for (var i = index; i <= _totalItems - 1; i++)
        {
            _items[i] = _items[i + 1];
        }

        _totalItems--;
    }

    /// <summary>
    /// Returns the zero-based index of the first occurrence of the specified item in the array. Returns -1 if the item is not found.
    /// </summary>
    /// <param name="item">The item to locate in the array.</param>
    /// <returns>The zero-based index of the first occurrence of the item, or -1 if the item is not found.</returns>
    public int IndexOf(int item)
    {
        for (var i = 0; i < _totalItems; i++)
        {
            if (_items[i] == item)
            {
                return i;
            }
        }

        return -1;
    }

    /// <summary>
    /// Finds and returns the maximum value in the array.
    /// </summary>
    /// <returns>The maximum value in the array.</returns>
    public int Max()
    {
        var highest = int.MinValue;

        for (var i = 0; i < _totalItems; i++)
        {
            if (highest < _items[i])
            {
                highest = _items[i];
            }
        }

        return highest;
    }

    /// <summary>
    /// Returns a new <see cref="CustomArray"/> containing the intersection of elements between the current array and another array.
    /// </summary>
    /// <param name="other">The other array to intersect with.</param>
    /// <returns>A new <see cref="CustomArray"/> containing the intersected elements.</returns>
    public CustomArray Intersect(CustomArray other)
    {
        var result = new CustomArray(1);

        for (var i = 0; i < _totalItems; i++)
        {
            for (var j = 0; j < other._totalItems; j++)
            {
                if (_items[i] == other._items[j])
                {
                    result.Insert(_items[i]);
                }
            }
        }

        return result;
    }

    /// <summary>
    /// Returns a new <see cref="CustomArray"/> containing the elements of the current array in reverse order.
    /// </summary>
    /// <returns>A new <see cref="CustomArray"/> with elements in reverse order.</returns>
    public CustomArray Reverse()
    {
        var result = new CustomArray(_totalItems);

        for (var i = _totalItems - 1; i >= 0; i--)
        {
            result.Insert(_items[i]);
        }

        return result;
    }

    /// <summary>
    /// Inserts an item at the specified index, shifting the existing elements right. Resizes the array if it is full. Throws an exception if the index is out of range.
    /// </summary>
    /// <param name="item">The item to insert.</param>
    /// <param name="index">The zero-based index at which the item should be inserted.</param>
    /// <exception cref="ArgumentNullException">Thrown when the index is out of range.</exception>
    public void InsertAt(int item, int index)
    {
        if (index < 0 || index >= _totalItems)
        {
            throw new ArgumentNullException(nameof(index), "Value out of range");
        }

        if (IsFull())
        {
            Resize();
        }

        for (var i = _totalItems; i >= index && i > 0; i--)
        {
            _items[i] = _items[i - 1];
        }

        _items[index] = item;

        _totalItems++;
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return string.Join(" ", _items.Take(_totalItems));
    }

    /// <summary>
    /// Doubles the size of the array, copying the existing elements to the new array.
    /// </summary>
    private void Resize()
    {
        var data = new int[_totalItems * 2];

        for (var i = 0; i < _items.Length; i++)
        {
            data[i] = _items[i];
        }

        _items = data;
    }

    /// <summary>
    /// Determines whether the array is full.
    /// </summary>
    /// <returns><c>true</c> if the array is full; otherwise, <c>false</c>.</returns>
    private bool IsFull()
    {
        return _items.Length == _totalItems;
    }
}
