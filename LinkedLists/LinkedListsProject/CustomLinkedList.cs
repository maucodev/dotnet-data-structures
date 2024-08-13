﻿using System;

namespace LinkedListsProject;

/// <summary>
/// Represents a custom implementation of a singly linked list of integers.
/// </summary>
public class CustomLinkedList
{
    /// <summary>
    /// Gets or sets the first node in the linked list.
    /// </summary>
    private Node First { get; set; }

    /// <summary>
    /// Gets or sets the last node in the linked list.
    /// </summary>
    private Node Last { get; set; }

    /// <summary>
    /// Gets the number of elements in the linked list.
    /// </summary>
    public int Size { get; private set; }

    /// <summary>
    /// Adds an item to the end of the linked list.
    /// </summary>
    /// <param name="item">The value to add.</param>
    public void AddLast(int item)
    {
        var node = new Node(item);

        if (IsEmpty())
        {
            First = Last = node;
        }
        else
        {
            Last.Next = node;
            Last = node;
        }

        Size++;
    }

    /// <summary>
    /// Returns the index of the first occurrence of a specified value in the linked list.
    /// </summary>
    /// <param name="item">The value to search for.</param>
    /// <returns>The zero-based index of the first occurrence of <paramref name="item"/>; 
    /// or -1 if the value is not found.</returns>
    public int IndexOf(int item)
    {
        var index = 0;
        var currentNode = First;

        while (currentNode is not null)
        {
            if (currentNode.Value == item)
            {
                return index;
            }

            index++;
            currentNode = currentNode.Next;
        }

        return -1;
    }

    /// <summary>
    /// Adds an item to the beginning of the linked list.
    /// </summary>
    /// <param name="item">The value to add.</param>
    public void AddFirst(int item)
    {
        var node = new Node(item);

        if (IsEmpty())
        {
            First = Last = node;
        }
        else
        {
            node.Next = First;
            First = node;
        }

        Size++;
    }

    /// <summary>
    /// Determines whether the linked list contains a specific value.
    /// </summary>
    /// <param name="item">The value to locate in the linked list.</param>
    /// <returns><c>true</c> if <paramref name="item"/> is found; otherwise, <c>false</c>.</returns>
    public bool Contains(int item)
    {
        return IndexOf(item) is not -1;
    }

    /// <summary>
    /// Clears the list.
    /// </summary>
    public void Clear()
    {
        First = Last = null;
        Size = 0;
    }

    /// <summary>
    /// Removes the first node from the linked list.
    /// </summary>
    /// <exception cref="InvalidOperationException">Thrown when the linked list is empty.</exception>
    public void RemoveFirst()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException();
        }

        var secondNode = First.Next;

        if (secondNode is null)
        {
            First = Last = null;
        }
        else
        {
            First.Next = null;
            First = secondNode;
        }

        Size--;
    }

    /// <summary>
    /// Removes the last node from the linked list.
    /// </summary>
    /// <exception cref="InvalidOperationException">Thrown when the linked list is empty.</exception>
    public void RemoveLast()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException();
        }

        var previousNode = GetPrevious(Last);

        if (previousNode is null)
        {
            First = Last = null;
        }
        else
        {
            Last = previousNode;
            Last.Next = null;
        }

        Size--;
    }

    /// <summary>
    /// Reverses the order of the nodes in the list. 
    /// If the list is empty, the method returns without making any changes.
    /// </summary>
    public void Reverse()
    {
        if (IsEmpty())
        {
            return;
        }

        var a = First;
        var b = First.Next;

        while (b is not null)
        {
            var next = b.Next;

            b.Next = a;
            a = b;
            b = next;
        }

        Last = First;
        Last.Next = null;

        First = a;
    }

    /// <summary>
    /// Converts the linked list to an array.
    /// </summary>
    /// <returns>An array containing all elements of the linked list in sequence.</returns>
    public int[] ToArray()
    {
        var index = 0;
        var current = First;
        var result = new int[Size];

        while (current is not null)
        {
            result[index++] = current.Value;
            current = current.Next;
        }

        return result;
    }

    /// <summary>
    /// Retrieves the node that precedes the specified node in the linked list.
    /// </summary>
    /// <param name="node">The node to find the predecessor of.</param>
    /// <returns>The node that precedes <paramref name="node"/>; or <c>null</c> if the node is not found or is the first node.</returns>
    private Node GetPrevious(Node node)
    {
        var current = First;

        while (current is not null)
        {
            if (current.Next == node)
            {
                return current;
            }

            current = current.Next;
        }

        return null;
    }

    /// <summary>
    /// Returns the value of the node at the specified position from the end of the list.
    /// </summary>
    /// <param name="k">The position from the end of the list, where 1 represents the last element.</param>
    /// <returns>The value of the node at the specified position from the end.</returns>
    public int GetKthValueFromTheEnd(int k)
    {
        if (k <= 0 || k > Size || IsEmpty())
        {
            throw new InvalidOperationException();
        }

        var a = First;
        var b = First;

        for (var i = 0; i < k - 1; i++)
        {
            b = b.Next;

            // The value of K is greater than list size
            if (b is null)
            {
                throw new InvalidOperationException();
            }
        }

        while (b != Last)
        {
            a = a.Next;
            b = b.Next;
        }

        return a.Value;
    }

    /// <summary>
    /// Determines whether the linked list is empty.
    /// </summary>
    /// <returns><c>true</c> if the linked list contains no elements; otherwise, <c>false</c>.</returns>
    private bool IsEmpty()
    {
        return Size == 0;
    }
}
