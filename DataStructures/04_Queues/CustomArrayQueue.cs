using System.Text;

namespace DataStructures._04_Queues
{
    /// <summary>
    /// Represents a circular queue implemented using an array.
    /// </summary>
    public class CustomArrayQueue(int capacity)
    {
        private int _indexBack;
        private int _indexFront;
        private int _totalItems;

        private readonly int[] _items = new int[capacity];

        /// <summary>
        /// Enqueues an item into the queue.
        /// </summary>
        /// <param name="item">The item to enqueue.</param>
        /// <exception cref="ArgumentException">Thrown when the queue is full.</exception>
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

        /// <summary>
        /// Dequeues an item from the queue.
        /// </summary>
        /// <returns>The dequeued item.</returns>
        /// <exception cref="ArgumentException">Thrown when the queue is empty.</exception>
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

        /// <summary>
        /// Returns a string representation of the queue.
        /// </summary>
        /// <returns>A string representing the contents of the queue.</returns>
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
}
