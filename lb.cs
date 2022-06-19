using System;
using System.Threading;
using System.Collections;
using System.IO;


class Program {
    static void Main(string[] args) {
        
        static void ThreadMethod() => {
            Console.WriteLine("Да, я поток лодблнсeра :))");
            Thread.Sleep(5000);
        }
        
        // создаём потоки. в нашем случае их будет 6, но вы можете добавить ещё
        Thread A = new Thread(new ThreadStart(ThreadMethod));
        Thread B = new Thread(new ThreadStart(ThreadMethod));
        Thread C = new Thread(new ThreadStart(ThreadMethod));
        Thread D = new Thread(new ThreadStart(ThreadMethod));
        Thread E = new Thread(new ThreadStart(ThreadMethod));
        Thread F = new Thread(new ThreadStart(ThreadMethod));
        
        Thread[] Threads = new array[6] { A, B, C, D, E, F };
        
        Threads[0] = Thread A;
        Threads[1] = Thread B;
        Threads[2] = Thread C;
        Threads[3] = Thread D;
        Threads[4] = Thread E;
        Threads[5] = Thread F;
        
        while (Threads.IsAlive != true) {
            var Threads = Enum.Threads();
            if (Threads.IsAlive = true) {
                Threads.ThreadStart(ThreadMethod);
            }
        }
    }
}
