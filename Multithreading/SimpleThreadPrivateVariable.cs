using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading {
    /// <summary>
    /// Usage of [ThreadStatic]
    /// (each thread has its own version of _field)
    /// </summary>
    class SimpleThreadPrivateVariable
    {
        // if you remove the ThreadStatic attribute then _field becomes 20
        [ThreadStatic] public static int _field;
        //public static int _field;

        public static void MainSimpleThreadPrivateVariable()
        {
            new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine("Thread A: {0}", _field);
                }   
            }).Start();

            new Thread(() => 
            {
                for (int i = 0; i < 10; i++) 
                {
                    _field++;
                    Console.WriteLine("Thread B: {0}", _field);
                }
            }).Start();

            Console.ReadKey();
        }
    }
}
