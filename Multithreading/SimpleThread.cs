using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading {
    /// <summary>
    /// Running a method on another thread
    /// </summary>
    class SimpleThread {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);

                // this thread finishes immediately
                // replace 0 with 1000 and then everything is way slower (thread suspended for 1000ms)
                Thread.Sleep(0);
            }
        }

        public static void MainSimpleThread() {            
            // If ThreadMethod had an input argument, then we should have used ParametrizedThreadStart
            // and then call t.Start with the parameter value.
            // You can also use lambda expressions (a short-hand version for delegate) to initialize thread
            Thread t = new Thread(new ThreadStart(ThreadMethod));

            // Try foreground/background thread by changing this
            // true allows immediate killing of the thread when app is closed, not desirable
            t.IsBackground = false;

            t.Start();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("MainSimpleThread thread: Do some work. ");
                Thread.Sleep(0);
            }

            // wait until other thread finishes
            t.Join();

            Console.ReadKey();
        }
    }
}
