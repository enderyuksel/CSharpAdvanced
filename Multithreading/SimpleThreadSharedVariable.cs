using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading {
    class SimpleThreadSharedVariable {
        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }

        /// <summary>
        /// stopped is SHARED between the main thread and other threads
        /// </summary>
        public static void MainSimplethreadLamba()
        {
            bool stopped = false;
            // lambda expression used like a delegate
            // "()" before "=>" means that there is no input
            Thread t = new Thread(new ThreadStart(() =>
            {
                while (!stopped)
                {
                    Console.WriteLine("Running");
                    Thread.Sleep(1000);
                }
            }));

            t.Start();
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();

            stopped = true;
            t.Join();
        }
    }
}
