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
            if (index < 0 || index >= _length)
            {
                throw new IndexOutOfRangeException();
            }

            for (var i = index; i < _length - 1; i++)
            {
                _array[i] = _array[i + 1];
            }

            _length--;
        }

        public void InsertAt(int index, int number)
        {
            if (index < 0 || index >= _length)
            {
                throw new IndexOutOfRangeException();
            }

            if (_length == _array.Length)
            {
                IncreaseSize();
            }

            for (var i = _length; i > index; i--)
            {
                _array[i] = _array[i - 1];
            }

            _array[index] = number;

            _length++;
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

        public int Max()
        {
            if (_length == 0)
            {
                return 0;
            }

            var result = _array[0];

            foreach (var number in _array)
            {
                if (result < number)
                {
                    result = number;
                }
            }

            return result;
        }

        public CustomArray Intersect(CustomArray relay)
        {
            var result = new CustomArray(relay.GetLength());

            for (var i = 0; i < relay.GetLength(); i++)
            {
                for (var j = 0; j < _length; j++)
                {
                    if (relay.ElementAt(i) == _array.ElementAt(j))
                    {
                        if (result.IndexOf(relay.ElementAt(i)) == -1)
                        {
                            result.Insert(relay.ElementAt(i));
                        }
                    }
                }
            }

            return result;
        }

        public CustomArray Reverse()
        {
            var result = new CustomArray(_length);

            for (int i = _length - 1; i >= 0; i--)
            {
                result.Insert(_array[i]);
            }

            return result;
        }

        public int ElementAt(int index)
        {
            if (index >= _length)
            {
                throw new IndexOutOfRangeException();
            }

            return _array[index];
        }

        public int GetLength()
        {
            return _length;
        }

        public void Print()
        {
            Console.WriteLine(_length == 0 ? "[ ]" : string.Join(" - ", _array.Take(_length)));
            Console.WriteLine();
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
    }
}
