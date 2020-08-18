using System;

public class CircularBuffer<T>
{
    private readonly T[] _buffer;
    private readonly int _maxCapacity;
    private int _readPos = 0;
    private int _writePos = 0;
    private int _count = 0;
    
    public CircularBuffer(int capacity)
    {
        _buffer = new T[capacity];
        _maxCapacity = capacity;
    }

    public T Read()
    {
        if (_count == 0) throw new InvalidOperationException();
        
        var obj = _buffer[_readPos];
        _readPos = CircularIncrement(_readPos);
        _count--;

        return obj;
    }

    public void Write(T value)
    {
        if(_count == _maxCapacity) throw new InvalidOperationException();

        _buffer[_writePos] = value;
        _writePos = CircularIncrement(_writePos);
        _count++;
    }

    public void Overwrite(T value)
    {
        if (_count < _maxCapacity)
        {
            Write(value);
        }
        else
        {
            _buffer[_readPos] = value;
            _readPos = CircularIncrement(_readPos);
        }
    }

    private int CircularIncrement(int value) => (value + 1) % _maxCapacity;

    public void Clear()
    {
        _count = 0;
        _readPos = _writePos;
    }
}