using System.Text;

namespace DataStructures._03_Stacks
{
    /// <summary>
    /// Represents a custom stack data structure.
    /// </summary>
    public class CustomStack
    {
        private int _length;
        private readonly int[] _stack = new int[5];

        /// <summary>
        /// Checks if the stack is empty.
        /// </summary>
        /// <returns>True if the stack is empty, otherwise false.</returns>
        public bool IsEmpty()
        {
            return _length == 0;
        }

        /// <summary>
        /// Checks if the stack is full.
        /// </summary>
        /// <returns>True if the stack is full, otherwise false.</returns>
        public bool IsFull()
        {
            return _length == _stack.Length;
        }

        /// <summary>
        /// Returns the top element of the stack without removing it.
        /// </summary>
        /// <returns>The top element of the stack.</returns>
        /// <exception cref="StackOverflowException">Thrown when the stack is empty.</exception>
        public int Peek()
        {
            if (IsEmpty())
            {
                throw new StackOverflowException();
            }

            return _stack[_length - 1];
        }

        /// <summary>
        /// Removes and returns the top element of the stack.
        /// </summary>
        /// <returns>The top element of the stack.</returns>
        /// <exception cref="StackOverflowException">Thrown when the stack is empty.</exception>
        public int Pop()
        {
            if (IsEmpty())
            {
                throw new StackOverflowException();
            }

            return _stack[--_length];
        }

        /// <summary>
        /// Adds an item to the top of the stack.
        /// </summary>
        /// <param name="item">The item to be added to the stack.</param>
        /// <exception cref="StackOverflowException">Thrown when the stack is full.</exception>
        public void Push(int item)
        {
            if (IsFull())
            {
                throw new StackOverflowException();
            }

            _stack[_length++] = item;
        }

        /// <summary>
        /// Returns a string representation of the stack.
        /// </summary>
        /// <returns>A string representation of the stack.</returns>
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
}
