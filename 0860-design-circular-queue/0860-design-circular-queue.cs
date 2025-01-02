public class MyCircularQueue
{
    private readonly int[] _array;
    private int _count;
    private int _headIndex;
    private int _tailIndex;

    public MyCircularQueue(int k)
    {
        _array = new int[k];
        _count = 0;
        _headIndex = -1;
        _tailIndex = -1;
    }


    /// <summary>
    /// Вставляет элемент в циклическую очередь. 
    /// </summary>
    /// <returns>Возврат, true если операция прошла успешно.</returns>
    public bool EnQueue(int value)
    {
        if (_tailIndex < _array.Length - 1
            && (_headIndex <= _tailIndex || _tailIndex + 1 < _headIndex))
        {
            if (_headIndex < 0)
            {
                _headIndex++;
            }
            _tailIndex++;
            _count++;
            _array[_tailIndex] = value;
            return true;
        }

        if (_tailIndex == _array.Length - 1 && _headIndex > 0)
        {
            _tailIndex = 0;
            _count++;
            _array[_tailIndex] = value;
            return true;
        }

        return false;
    }

    /// <summary>
    /// Удаляет элемент из циклической очереди.
    /// </summary>
    /// <returns>Возврат, true если операция прошла успешно.</returns>
    public bool DeQueue()
    {
        if (_headIndex < 0)
        {
            return false;
        }

        if (_headIndex == _tailIndex)
        {
            _headIndex = -1;
            _tailIndex = -1;
            _count = 0;
            return true;
        }

        if (_headIndex < _tailIndex || _headIndex < _array.Length - 1)
        {
            _headIndex++;
            _count--;
            return true;
        }

        if (_headIndex == _array.Length - 1)
        {
            _headIndex = 0;
            _count--;
            return true;
        }

        return false;
    }

    /// <summary>
    /// Получает передний элемент из очереди. Если очередь пуста, вернуть -1
    /// </summary>
    public int Front()
    {
        if (IsEmpty())
        {
            return -1;
        }
        return _array[_headIndex];
    }

    /// <summary>
    /// Получает последний элемент из очереди. Если очередь пуста, вернуть -1.
    /// </summary>
    public int Rear()
    {
        if (IsEmpty())
        {
            return -1;
        }
        return _array[_tailIndex];
    }

    /// <summary>
    /// Проверяет, пуста ли кольцевая очередь.
    /// </summary>
    public bool IsEmpty()
    {
        return _count == 0;
    }

    /// <summary>
    /// Проверяет, заполнена ли кольцевая очередь.
    /// </summary>
    public bool IsFull()
    {
        return _count == _array.Length;
    }
}

/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */