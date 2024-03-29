﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularBuffer_2
{
    public delegate void Printer<T>(T data);

    public static class BufferExtensions
    {
        public static void Display<T>(this IBuffer<T> buffer, Action<T> print)
        {
            foreach(var item in buffer)
            {
                print(item);
            }
        }

        public static IEnumerable<TOutput> AsEnumerableOf<T, TOutput>(this IBuffer<T> buffer)
        {
            var converter = TypeDescriptor.GetConverter(typeof(T));
            foreach (var item in buffer)
            {
                var result = converter.ConvertTo(item, typeof(TOutput));
                yield return (TOutput)result;
            }
        }
    }
}
