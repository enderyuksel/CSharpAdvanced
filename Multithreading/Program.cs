using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading {
    class Program {
        /// <summary>
        /// In Visual Studio, F5 (start debugging) and 
        /// Ctrl-F5 (start without debugging) give different results
        /// Ctrl-F5 is best for trying these examples 
        /// </summary>
        static void Main()
        {
            //Console.WriteLine("Simple Threading");
            //Console.WriteLine("================================");
            //SimpleThread.MainSimpleThread();

            //Console.WriteLine("\n\n Simple Threading with shared variable");
            //Console.WriteLine("================================");
            //SimpleThreadSharedVariable.MainSimplethreadLamba();
            //Console.ReadKey();

            //Console.WriteLine("\n\n Simple Threading - threads' private variables");
            //Console.WriteLine("================================");
            //SimpleThreadPrivateVariable.MainSimpleThreadPrivateVariable();
            //Console.ReadKey();

            //Console.WriteLine("\n\n Simple Threading - threads' private initialized variables");
            //Console.WriteLine("================================");
            //SimpleThreadPrivateInitializedVariable.MainSimpleThreadPrivInitVar();
            //Console.ReadKey();

            //Console.WriteLine("\n\n Thread Pool - Threads are created and reused (but not killed) automatically");
            //Console.WriteLine("================================");
            //ThreadPooling.MainThreadPool();
            //Console.ReadKey();

            Console.WriteLine("\n\n Tasks");
            Console.WriteLine("================================");
            TaskSimple.MainTaskSimple();
            Console.ReadKey();
        }
    }
}
