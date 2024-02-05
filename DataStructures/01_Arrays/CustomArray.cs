namespace DataStructures._01_Arrays
{
    public class CustomArray(int size)
    {
        private int[] _array = new int[size];

        private int _length;

        public void Insert(int number)
        {
            if (_array.Length <= _length)
            {
                IncreaseSize();
            }

            _array[_length++] = number;
        }

        public void RemoveAt(int index)
        {
            if (index >= _length)
            {
                throw new IndexOutOfRangeException();
            }

            for (var i = index; i < _length - 1; i++)
            {
                _array[i] = _array[i + 1];
            }

            _length--;
        }

        public int IndexOf(int value)
        {
            for (var i = 0; i < _length; i++)
            {
                if (_array[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        private void IncreaseSize()
        {
            var relay = new int[_length * 2];

            for (var i = 0; i < _length; i++)
            {
                relay[i] = _array[i];
            }

            _array = relay;
        }

        public void Print()
        {
            Console.WriteLine(_length == 0 ? "[ ]" : string.Join(" - ", _array.Take(_length)));
            Console.WriteLine();
        }
    }
}
