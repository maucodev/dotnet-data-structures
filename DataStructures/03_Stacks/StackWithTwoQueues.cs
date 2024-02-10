using System.Text;

namespace DataStructures._03_Stacks
{
    /// <summary>
    /// Represents a stack implemented using two queues.
    /// </summary>
    public class StackWithTwoQueues
    {
        private int _topValue;
        private Queue<int> _queue01 = new();
        private Queue<int> _queue02 = new();

        /// <summary>
        /// Pushes an item onto the stack.
        /// </summary>
        /// <param name="item">The item to push onto the stack.</param>
        public void Push(int item)
        {
            _queue01.Enqueue(item);
            _topValue = item;
        }

        /// <summary>
        /// Removes and returns the item at the top of the stack.
        /// </summary>
        /// <returns>The item at the top of the stack.</returns>
        /// <exception cref="InvalidOperationException">Thrown when the stack is empty.</exception>
        public int Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            while (Size() > 1)
            {
                _topValue = _queue01.Dequeue();
                _queue02.Enqueue(_topValue);
            }

            SwapQueues();

            return _queue02.Dequeue();
        }

        private void SwapQueues()
        {
            (_queue01, _queue02) = (_queue02, _queue01);
        }

        /// <summary>
        /// Checks whether the stack is empty.
        /// </summary>
        /// <returns>True if the stack is empty, otherwise false.</returns>
        public bool IsEmpty()
        {
            return _queue01.Count == 0;
        }

        /// <summary>
        /// Gets the number of items in the stack.
        /// </summary>
        /// <returns>The number of items in the stack.</returns>
        public int Size()
        {
            return _queue01.Count;
        }

        /// <summary>
        /// Returns the item at the top of the stack without removing it.
        /// </summary>
        /// <returns>The item at the top of the stack.</returns>
        /// <exception cref="InvalidOperationException">Thrown when the stack is empty.</exception>
        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            return _topValue;
        }

        /// <summary>
        /// Returns a string representation of the stack.
        /// </summary>
        /// <returns>A string representing the contents of the stack.</returns>
        public override string ToString()
        {
            if (IsEmpty())
            {
                return "[ ]\n";
            }

            var result = new StringBuilder("[ ");

            foreach (var item in _queue01)
            {
                result.Append($" {item} ");
            }

            result.Append(" ]\n");

            return result.ToString();
        }
    }
}
