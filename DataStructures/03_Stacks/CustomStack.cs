using System.Text;

namespace DataStructures._03_Stacks;

public class CustomStack
{
    private int _length;

    private readonly int[] _stack = new int[5];

    public bool IsEmpty()
    {
        return _length == 0;
    }

    public bool IsFull()
    {
        return _length == _stack.Length;
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            throw new StackOverflowException();
        }

        return _stack[_length - 1];
    }

    public int Pop()
    {
        if (IsEmpty())
        {
            throw new StackOverflowException();
        }

        return _stack[--_length];
    }

    public void Push(int item)
    {
        if (IsFull())
        {
            throw new StackOverflowException();
        }

        _stack[_length++] = item;
    }

    public override string ToString()
    {
        var result = new StringBuilder("[");

        for (var i = 0; i < _length; i++)
        {
            result.Append($" {_stack[i]} ");
        }

        result.Append(']');

        return result.ToString();
    }
}