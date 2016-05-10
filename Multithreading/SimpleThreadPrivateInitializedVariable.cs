using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading {
    /// <summary>
    /// Usage of ThreadLocal<T> class
    /// (initialize each thread's own variable)
    /// </summary>
    public static class SimpleThreadPrivateInitializedVariable
    {
        public static ThreadLocal<int> _field =
            new ThreadLocal<int>(() =>
            {
                // apparently first (non-main) thread gets 2
                // and the other gets 3 as ID
                return Thread.CurrentThread.ManagedThreadId;
            });

        public static void MainSimpleThreadPrivInitVar()
        {
            new Thread(() => {
              for (int i = 0; i < _field.Value; i++) {                  
                  Console.WriteLine("Thread A: {0}", i);
              }
          }).Start();

            new Thread(() => {
                for (int i = 0; i < _field.Value; i++) {                    
                    Console.WriteLine("Thread B: {0}", i);
                }
            }).Start();

            Console.ReadKey();
        }
    }
}
