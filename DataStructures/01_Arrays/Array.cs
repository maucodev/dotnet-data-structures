namespace DataStructures._01_Arrays;

/// <summary>
/// Represents a custom array data structure.
/// </summary>
public class Array(int size)
{
    private int _length;
    private int[] _array = new int[size];

    /// <summary>
    /// Inserts an element into the array.
    /// </summary>
    /// <param name="number">The element to be inserted.</param>
    public void Insert(int number)
    {
        if (_array.Length <= _length)
        {
            IncreaseSize();
        }

        _array[_length++] = number;
    }

    /// <summary>
    /// Removes the element at the specified index from the array.
    /// </summary>
    /// <param name="index">The index of the element to be removed.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the index is out of range.</exception>
    public void RemoveAt(int index)
    {
        ValidateIndex(index);

        for (var i = index; i < _length - 1; i++)
        {
            _array[i] = _array[i + 1];
        }

        _length--;
    }

    /// <summary>
    /// Inserts an element at the specified index in the array.
    /// </summary>
    /// <param name="index">The index at which to insert the element.</param>
    /// <param name="number">The element to be inserted.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the index is out of range.</exception>
    public void InsertAt(int index, int number)
    {
        ValidateIndex(index);

        if (_length == _array.Length)
        {
            IncreaseSize();
        }

        for (var i = _length; i > index; i--)
        {
            _array[i] = _array[i - 1];
        }

        _array[index] = number;

        _length++;
    }

    /// <summary>
    /// Returns the index of the first occurrence of the specified value in the array.
    /// </summary>
    /// <param name="value">The value to search for.</param>
    /// <returns>The index of the value if found; otherwise, -1.</returns>
    public int IndexOf(int value)
    {
        for (var i = 0; i < _length; i++)
        {
            if (_array[i] == value)
            {
                return i;
            }
        }

        return -1;
    }

    /// <summary>
    /// Returns the maximum value in the array.
    /// </summary>
    /// <returns>The maximum value in the array.</returns>
    public int Max()
    {
        if (_length == 0)
        {
            return 0;
        }

        var result = _array[0];

        foreach (var number in _array)
        {
            if (result < number)
            {
                result = number;
            }
        }

        return result;
    }

    /// <summary>
    /// Returns a new array containing the intersection of the current array with another array.
    /// </summary>
    /// <param name="other">The other array to intersect with.</param>
    /// <returns>A new array containing the intersection of the two arrays.</returns>
    public Array Intersect(Array other)
    {
        var result = new Array(other.GetLength());

        for (var i = 0; i < _length; i++)
        {
            if (other.IndexOf(_array[i]) != -1)
            {
                result.Insert(_array[i]);
            }
        }

        return result;
    }

    /// <summary>
    /// Returns a new array containing the elements of the current array in reverse order.
    /// </summary>
    /// <returns>A new array containing the elements in reverse order.</returns>
    public Array Reverse()
    {
        var result = new Array(_length);

        for (var i = _length - 1; i >= 0; i--)
        {
            result.Insert(_array[i]);
        }

        return result;
    }

    /// <summary>
    /// Gets the length of the array.
    /// </summary>
    /// <returns>The length of the array.</returns>
    public int GetLength()
    {
        return _length;
    }

    /// <summary>
    /// Prints the elements of the array.
    /// </summary>
    public void Print()
    {
        Console.WriteLine(_length == 0 ? "[]" : string.Join(" - ", _array.Take(_length)));
        Console.WriteLine();
    }

    private void ValidateIndex(int index)
    {
        if (index < 0 || index >= _length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
    }

    private void IncreaseSize()
    {
        var result = new int[_length * 2];

        for (var i = 0; i < _length; i++)
        {
            result[i] = _array[i];
        }

        _array = result;
    }
}