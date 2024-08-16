using System;
using System.Linq;

namespace StacksProject;

/// <summary>
/// Represents a stack data structure with dynamic resizing capability.
/// </summary>
/// <typeparam name="T">The type of elements in the stack.</typeparam>
public class CustomStack<T>
{
    private int _totalItems;
    private T[] _items;

    /// <summary>
    /// Initializes a new instance of the <see cref="CustomStack{T}"/> class with a specified initial size.
    /// </summary>
    /// <param name="size">The initial size of the stack.</param>
    public CustomStack(int size)
    {
        _items = new T[size];
    }

    /// <summary>
    /// Gets a value indicating whether the stack is empty.
    /// </summary>
    /// <returns>True if the stack is empty; otherwise, false.</returns>
    public bool IsEmpty()
    {
        return _totalItems == 0;
    }

    /// <summary>
    /// Gets a value indicating whether the stack is full.
    /// </summary>
    private bool IsFull => _items.Length == _totalItems;

    /// <summary>
    /// Removes and returns the object at the top of the stack.
    /// </summary>
    /// <returns>The object removed from the top of the stack.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the stack is empty.</exception>
    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Cannot pop from an empty stack.");
        }

        return _items[--_totalItems];
    }

    /// <summary>
    /// Adds an object to the top of the stack.
    /// </summary>
    /// <param name="item">The object to push onto the stack.</param>
    /// <exception cref="InvalidOperationException">Thrown when the item is null.</exception>
    public void Push(T item)
    {
        if (item is null)
        {
            throw new InvalidOperationException("Cannot push a null item onto the stack.");
        }

        if (IsFull)
        {
            Resize();
        }

        _items[_totalItems++] = item;
    }

    /// <summary>
    /// Doubles the capacity of the stack when it is full.
    /// </summary>
    private void Resize()
    {
        var data = new T[_totalItems * 2];

        for (var i = 0; i < _totalItems; i++)
        {
            data[i] = _items[i];
        }

        _items = data;
    }

    /// <summary>
    /// Reverses the order of the elements in the stack.
    /// </summary>
    public void Reverse()
    {
        var data = new T[_totalItems];

        for (int i = _totalItems - 1, j = 0; i >= 0; i--, j++)
        {
            data[j] = _items[i];
        }

        _items = data;
    }

    /// <summary>
    /// Returns a string that represents the current stack.
    /// </summary>
    /// <returns>A string that represents the current stack.</returns>
    public override string ToString()
    {
        return $"[ {string.Join(", ", _items.Take(_totalItems))} ]";
    }
}