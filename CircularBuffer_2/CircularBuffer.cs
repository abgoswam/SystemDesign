using System.Collections;
using System.Collections.Generic;

namespace CircularBuffer_2
{
    public class CircularBuffer<T> : Buffer<T>
    {
        private int _capacity;
        public CircularBuffer(int capacity)
        {
            _capacity = capacity;
        }

        public override void Write(T value)
        {
            _queue.Enqueue(value);
            if(_queue.Count > _capacity)
            {
                _queue.Dequeue();
            }
        }
    }
}
