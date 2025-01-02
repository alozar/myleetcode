public class MyCircularQueue
{
    private readonly int[] _array;
    private int _size;
    private int _head;
    private int _tail;

    public MyCircularQueue(int k)
    {
        _array = new int[k];
        _size = k;
        _head = -1;
        _tail = -1;
    }


    /// <summary>
    /// Вставляет элемент в циклическую очередь. 
    /// </summary>
    /// <returns>Возврат, true если операция прошла успешно.</returns>
    public bool EnQueue(int value)
    {
        if (IsFull())
        {
            return false;
        }

        if (IsEmpty())
        {
            _head = 0;
        }

        _tail = (_tail + 1) % _size;
        _array[_tail] = value;

        return true;
    }

    /// <summary>
    /// Удаляет элемент из циклической очереди.
    /// </summary>
    /// <returns>Возврат, true если операция прошла успешно.</returns>
    public bool DeQueue()
    {
        if (IsEmpty())
        {
            return false;
        }

        if (_head == _tail)
        {
            _head = -1;
            _tail = -1;
            return true;
        }

        _head = (_head + 1) % _size;

        return true;
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
        return _array[_head];
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
        return _array[_tail];
    }

    /// <summary>
    /// Проверяет, пуста ли кольцевая очередь.
    /// </summary>
    public bool IsEmpty()
    {
        return _head == -1;
    }

    /// <summary>
    /// Проверяет, заполнена ли кольцевая очередь.
    /// </summary>
    public bool IsFull()
    {
        return (_tail + 1) % _size == _head;
    }
}