using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading {
    /// <summary>
    /// Thread pools are very useful as they cover the creation and reuse
    /// of threads, similar to DB connection pooling. Instead of killing a thread, 
    /// it just reuses it whenever needed.
    /// 
    /// One drawback, however, is since threads are reused, their local
    /// states are also reused. So states may become unreliable.
    /// 
    /// Another drwaback: there is no built-in way to know when the operation
    /// has finished and what the return value is. See "Tasks" as a solution to this.
    /// </summary>
    public static class ThreadPooling {
        public static void MainThreadPool()
        {
            ThreadPool.QueueUserWorkItem( a => Console.WriteLine("Thread from a thread pool"));

            Console.ReadLine();
        }
    }
}
