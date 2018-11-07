using System.Collections;
using System.Collections.Generic;

namespace CircularBuffer_2
{
    public class Buffer<T> : IBuffer<T>
    {
        protected Queue<T> _queue = new Queue<T>();

        public bool IsEmpty
        {
            get { return _queue.Count == 0; }
        }

        public T Read()
        {
            return _queue.Dequeue();
        }

        public virtual void Write(T value)
        {
            _queue.Enqueue(value);
        }
    }

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
