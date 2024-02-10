using System.Collections;
using System.Text;

namespace DataStructures._04_Queues
{
    /// <summary>
    /// Provides methods to reverse a portion of elements in a queue.
    /// </summary>
    public static class QueueReverser
    {
        /// <summary>
        /// Reverses the first K elements in the queue.
        /// </summary>
        /// <param name="k">The number of elements to reverse.</param>
        /// <param name="queue">The queue to reverse.</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="k"/> is negative or greater than the queue size.</exception>
        public static void Reverse(int k, Queue<int> queue)
        {
            if (k < 0 || k > queue.Count)
            {
                throw new ArgumentException("The value of k must be less or equal to the queue size.");
            }

            var stack = new Stack<int>();

            // Dequeue the first K elements from the queue
            // and push them onto the stack
            for (var i = 0; i < k; i++)
            {
                stack.Push(queue.Dequeue());
            }

            // Enqueue the content of the stack at the
            // back of the queue
            while (!IsEmpty(stack))
            {
                queue.Enqueue(stack.Pop());
            }

            // Add the remaining items in the queue (items
            // after the first K elements) to the back of the
            // queue and remove them from the beginning of the queue
            for (var i = 0; i < queue.Count - k; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }
        }

        /// <summary>
        /// Prints the elements of the queue.
        /// </summary>
        /// <param name="queue">The queue to print.</param>
        /// <returns>A string representation of the queue.</returns>
        public static string Print(Queue<int> queue)
        {
            if (IsEmpty(queue))
            {
                return "[ ]\n";
            }

            var result = new StringBuilder("[ ");

            foreach (var item in queue)
            {
                result.Append($" {item} ");
            }

            result.Append(" ]\n");

            return result.ToString();
        }

        private static bool IsEmpty(ICollection collection)
        {
            return collection.Count == 0;
        }
    }
}
