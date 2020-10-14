using System;
using System.Diagnostics;

namespace Performance
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            long memorySize = Process.GetCurrentProcess().PrivateMemorySize64;

            var classes = new C[100000];
            for (int i = 0; i < classes.Length; i++)
            {
                classes[i] = new C (rand.Next());
            }

            long classesMemoryDelta = Process.GetCurrentProcess().PrivateMemorySize64 - memorySize;
            memorySize = Process.GetCurrentProcess().PrivateMemorySize64;
            Console.WriteLine ("Classes memory delta : " + classesMemoryDelta);

            var structs = new S[100000];
            for (int i = 0; i < structs.Length; i++)
            {
                structs[i] = new S (rand.Next());
            }

            long structsMemoryDelta = Process.GetCurrentProcess().PrivateMemorySize64 - memorySize;
            Console.WriteLine ("Structs memory delta : " + structsMemoryDelta);

            if (classesMemoryDelta > structsMemoryDelta)
            {
                Console.WriteLine ("Structures use " + (classesMemoryDelta - structsMemoryDelta) + " bytes less memory than classes");
            }
            else
            {
                Console.WriteLine ("Classes use " + (structsMemoryDelta - classesMemoryDelta) + " bytes less memory than structures");
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Array.Sort<C> (classes);

            double classesTimeDelta = stopwatch.Elapsed.TotalMilliseconds;
            stopwatch.Restart();
            Console.WriteLine ("Classes time delta : " + classesTimeDelta);

            Array.Sort<S> (structs);

            double structsTimeDelta = stopwatch.Elapsed.TotalMilliseconds;
            stopwatch.Stop();
            Console.WriteLine ("Structures time delta : " + structsTimeDelta);

            if (classesTimeDelta > structsTimeDelta)
            {
                Console.WriteLine ("Structures were sorted " + (classesTimeDelta - structsTimeDelta) + " milliseconds faster than classes");
            }
            else
            {
                Console.WriteLine ("Classes were sorted " + (structsTimeDelta - classesTimeDelta) + " milliseconds faster than structures");
            }
        }
    }
}
