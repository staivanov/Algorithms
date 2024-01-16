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


        public int DeleteMax()
        {
            if (IsEmpty())
            {
                return -1;
            }

            int element = _data[1];
            _data[1] = _data[_currentSize];
            _data[_currentSize] = -1;
            _currentSize--;
            int i = 1,
                j = i * 2;

            while (j <= _currentSize)
            {
                if (_data[j] < _data[j + 1])
                {
                    j++;
                }

                if (_data[i] < _data[j])
                {
                    int temp = _data[i];
                    _data[i] = _data[j];
                    _data[j] = temp;
                    i = j;
                    j = i * 2;
                }
                else
                {
                    break;
                }         
            }

            return element;
        }



        public int Max()
        {
            if (IsEmpty())
            {
                return -1;
            }

            return _data[1];
        }


        public void HeapSort(int[] numbers)
        {
            int numbersLen = numbers.Length;
            Heap heap = new();

            for (int i = 0; i < numbersLen; i++)
            {
                heap.Insert(numbers[i]);
            }

            int k = numbersLen - 1;

            for (int j = 0; j < numbersLen; j++)
            {
                numbers[k] = heap.DeleteMax();
                k--;
            }          
        }


        public void Display(int[] numbers)
        {
            int index = 0;

            while(index < numbers.Length)
            {
                Console.Write(numbers[index] + " ");              
                index++;        
            }
        }


        public int Length() => _currentSize;
        public bool IsEmpty() => _currentSize == 0;
    }
}
