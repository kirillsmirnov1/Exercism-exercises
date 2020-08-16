using System;
using System.Collections.Generic;

public class CircularBuffer<T>
{
    private readonly Queue<T> _buffer;
    private readonly int _maxCapacity;
    
    public CircularBuffer(int capacity)
    {
        _buffer = new Queue<T>();
        _maxCapacity = capacity;
    }

    public T Read() => _buffer.Dequeue();

    public void Write(T value)
    {
        if(_buffer.Count == _maxCapacity) 
            throw new InvalidOperationException();
        
        _buffer.Enqueue(value);
    }

    public void Overwrite(T value)
    {
        if(_buffer.Count == _maxCapacity) _buffer.Dequeue();
        _buffer.Enqueue(value);
    }

    public void Clear() => _buffer.Clear();
}