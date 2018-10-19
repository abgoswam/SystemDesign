using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {
        bool done;
        static readonly object locker = new object();

        static void Main(string[] args)
        {
            Program tt = new Program();
            new Thread(tt.Go).Start();
            tt.Go();
        }

        void Go()
        {
            lock (locker)
            {
                if (!done)
                {
                    Console.WriteLine("Done..");
                    done = true;
                }
            }
        }
    }
}
