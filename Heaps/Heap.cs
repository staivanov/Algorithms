namespace Heaps
{
    public class Heap
    {
        private int[] _data;
        private int _maxSize;
        private int _currentSize;
        private int _heapSize;


        public Heap()
        {
            _maxSize = 10;
            _data = new int[_maxSize];
            _currentSize = 0;

            for (int i = 0; i < _data.Length; i++)
            {
                _data[i] = -1;
            }
        }


        public void Insert(int element)
        {
            if (_currentSize == _maxSize)
            {
                return;
            }

            _currentSize++;
            _heapSize = _currentSize;

            while (_heapSize > 1 && element > _data[_heapSize / 2])
            {
                _data[_heapSize] = _data[_heapSize / 2];
                _heapSize /= 2;
            }

            _data[_heapSize] = element; 
        }


        public int Max()
        {
            if (IsEmpty())
            {
                return -1;
            }

            return _data[1];
        }


        public int Length() => _currentSize;
        public bool IsEmpty() => _currentSize == 0;
    }
}
