namespace DataStructures._04_Queues;

public class CustomQueueWithTwoStacks
{
    private readonly Stack<int> _stackEnqueue = new();

    private readonly Stack<int> _stackDequeue = new();

    public void Enqueue(int item)
    {
        _stackEnqueue.Push(item);
    }

    public int Dequeue()
    {
        if (IsStackEnqueueEmpty() && IsStackDequeueEmpty())
        {
            throw new ArgumentException("The queue is empty.");
        }

        if (!IsStackDequeueEmpty())
        {
            return _stackDequeue.Pop();
        }

        TranslateFromEnqueueToDequeueStack();

        return _stackDequeue.Pop();
    }

    public int Peek()
    {
        if (IsStackEnqueueEmpty() && IsStackDequeueEmpty())
        {
            throw new ArgumentException("The queue is empty.");
        }

        if (!IsStackDequeueEmpty())
        {
            return _stackDequeue.Pop();
        }

        TranslateFromEnqueueToDequeueStack();

        return _stackDequeue.Peek();
    }

    private void TranslateFromEnqueueToDequeueStack()
    {
        while (!IsStackEnqueueEmpty())
        {
            _stackDequeue.Push(_stackEnqueue.Pop());
        }
    }

    private bool IsStackDequeueEmpty()
    {
        return _stackDequeue.Count == 0;
    }

    private bool IsStackEnqueueEmpty()
    {
        return _stackEnqueue.Count == 0;
    }
}