namespace DataStructures._01_Arrays
{
    public class CustomArray(int size)
    {
        private int _length;

        private int[] _array = new int[size];

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
            ValidateIndex(index);

            for (var i = index; i < _length - 1; i++)
            {
                _array[i] = _array[i + 1];
            }

            _length--;
        }

        public void InsertAt(int index, int number)
        {
            ValidateIndex(index);

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

        public CustomArray Intersect(CustomArray other)
        {
            var result = new CustomArray(other.GetLength());

            for (var i = 0; i < _length; i++)
            {
                if (other.IndexOf(_array[i]) != -1)
                {
                    result.Insert(_array[i]);
                }
            }

            return result;
        }

        public CustomArray Reverse()
        {
            var result = new CustomArray(_length);

            for (var i = _length - 1; i >= 0; i--)
            {
                result.Insert(_array[i]);
            }

            return result;
        }

        public int GetLength()
        {
            return _length;
        }

        public void Print()
        {
            Console.WriteLine(_length == 0 ? "[]" : string.Join(" - ", _array.Take(_length)));
            Console.WriteLine();
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= _length)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
        }

        private void IncreaseSize()
        {
            var result = new int[_length * 2];

            for (var i = 0; i < _length; i++)
            {
                result[i] = _array[i];
            }

            _array = result;
        }
    }
}
