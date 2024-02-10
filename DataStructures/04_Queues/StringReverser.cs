using System.Text;

namespace DataStructures._04_Queues
{
    public static class StringReverser
    {
        public static void Reverse(Queue<string> queue)
        {
            var stack = new Stack<string>();

            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }

        public static string Print(Queue<string> queue)
        {
            var result = new StringBuilder();

            foreach (var item in queue)
            {
                result.Append(item);
            }

            return result.ToString();
        }
    }
}
