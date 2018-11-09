using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularBuffer_2
{
    class Program
    {
        public static void ConsoleWrite(double data)
        {
            Console.WriteLine(data);
        }

        static void Main(string[] args)
        {
            var buffer = new Buffer<double>();

            ProcessInput(buffer);

            var asInt = buffer.AsEnumerableOf<double, int>();

            //Printer console = x => Console.WriteLine(x);
            //buffer.Display(console);
            buffer.Display(x => Console.WriteLine(x));

            //Printer<double> console = ConsoleWrite;
            buffer.Display(ConsoleWrite);

            ProcessBuffer(buffer);
        }

        private static void ProcessBuffer(IBuffer<double> buffer)
        {
            var sum = 0.0;
            Console.WriteLine("Buffer: ");
            while (!buffer.IsEmpty)
            {
                sum += buffer.Read();
            }
            Console.WriteLine(sum);
        }

        private static void ProcessInput(IBuffer<double> buffer)
        {
            while (true)
            {
                var value = 0.0;
                var input = Console.ReadLine();

                if (double.TryParse(input, out value))
                {
                    buffer.Write(value);
                    continue;
                }
                break;
            }
        }
    }
}
