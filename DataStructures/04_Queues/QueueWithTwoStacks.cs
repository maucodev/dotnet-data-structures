namespace DataStructures._04_Queues
{
    /// <summary>
    /// Represents a queue implementation using two stacks.
    /// </summary>
    public class QueueWithTwoStacks
    {
        private readonly Stack<int> _stackEnqueue = new();
        private readonly Stack<int> _stackDequeue = new();

        /// <summary>
        /// Enqueues an item into the queue.
        /// </summary>
        /// <param name="item">The item to enqueue.</param>
        public void Enqueue(int item)
        {
            _stackEnqueue.Push(item);
        }

        /// <summary>
        /// Dequeues an item from the queue.
        /// </summary>
        /// <returns>The dequeued item.</returns>
        /// <exception cref="ArgumentException">Thrown when the queue is empty.</exception>
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

        /// <summary>
        /// Retrieves the item at the front of the queue without removing it.
        /// </summary>
        /// <returns>The item at the front of the queue.</returns>
        /// <exception cref="ArgumentException">Thrown when the queue is empty.</exception>
        public int Peek()
        {
            if (IsStackEnqueueEmpty() && IsStackDequeueEmpty())
            {
                throw new ArgumentException("The queue is empty.");
            }

            if (!IsStackDequeueEmpty())
            {
                return _stackDequeue.Peek();
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
}
