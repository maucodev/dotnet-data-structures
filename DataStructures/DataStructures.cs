using DataStructures._01_Arrays;
using DataStructures._02_LinkedLists;
using DataStructures._03_Stacks;

namespace DataStructures
{
    public static class DataStructures
    {
        public static void Main()
        {
            switch (GetOption().KeyChar)
            {
                case '1':
                    CustomArrayTests.Execute();
                    break;

                case '2':
                    CustomLinkedListTests.Execute();
                    break;

                case '3':
                    CustomStackTests.Execute();
                    break;
            }

            Console.ReadLine();
        }

        private static ConsoleKeyInfo GetOption()
        {
            Console.Write("What data structure do you want to run? ");

            var input = Console.ReadKey();

            Console.Clear();

            return input;
        }
    }
}
