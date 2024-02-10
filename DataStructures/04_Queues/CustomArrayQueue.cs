using System.Text;

namespace DataStructures._04_Queues;

public class CustomArrayQueue(int capacity)
{
    private int _indexBack;
    private int _indexFront;
    private int _totalItems;

    private readonly int[] _items = new int[capacity];

    public void Enqueue(int item)
    {
        if (IsFull())
        {
            throw new ArgumentException("The queue is full.");
        }

        _items[_indexBack] = item;

        _indexBack = (_indexBack + 1) % _items.Length;

        _totalItems++;
    }

    public int Dequeue()
    {
        if (IsEmpty())
        {
            throw new ArgumentException("The queue is empty.");
        }

        var deletedItem = _items[_indexFront];

        _items[_indexFront] = 0;

        _indexFront = (_indexFront + 1) % _items.Length;

        _totalItems--;

        return deletedItem;
    }

    public override string ToString()
    {
        if (IsEmpty())
        {
            return "[ ]\n";
        }

        var result = new StringBuilder("[ ");

        foreach (var item in _items)
        {
            result.Append($" {item} ");
        }

        result.Append(" ]\n");

        return result.ToString();
    }

    private bool IsFull()
    {
        return _totalItems == _items.Length;
    }

    private bool IsEmpty()
    {
        return _totalItems == 0;
    }
}