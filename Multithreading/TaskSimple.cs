using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading {
    public static class TaskSimple {
        /// <summary>
        /// In contrast to Thread pools (or threads), Task can tell
        /// if the work is completed and returns the result (if possible).
        /// 
        /// Task Scheduler, is responsible for starting the Task and managing it.
        /// It uses threads from the thread pool to execute the Task.
        /// 
        /// Task is good for responsiveness: as different threads can be used for different work 
        /// (sounds like threads).
        /// Task is NOT good for scalability: as starting a new Task is just consuming another thread 
        /// from the thread pool while the original thread waits for results.
        /// </summary>
        public static void MainTaskSimple()
        {
            Task t = Task.Run(() =>
            {
                Console.WriteLine("Task running");
            });

            t.Wait();
        }
    }
}
