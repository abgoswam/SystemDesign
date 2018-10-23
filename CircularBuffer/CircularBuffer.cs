using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularBuffer
{
    class CircularBuffer<T>
    {
        private T[] _buffer;
        private int _start;
        private int _end;

        public CircularBuffer()
        { }

        public CircularBuffer(int capacity)
        {
            _buffer = new T[capacity + 1];
            _start = 0;
            _end = 0;
        }

        public bool IsEmpty
        {
            get { return _start == _end;  }
        }

        public bool IsFull
        {
            get { return _start == (_end + 1) % _buffer.Length; }
        }

        public void Write(T value)
        {
            if (IsFull)
                return;

            _end = (_end + 1) % _buffer.Length;
            _buffer[_end] = value;
        }

        public T Read()
        {
            if(IsEmpty)
            {
                throw new InvalidOperationException("trying to read from empty circular buffer");
            }

            _start = (_start + 1) % _buffer.Length;
            return _buffer[_start];
        }
    }
}
