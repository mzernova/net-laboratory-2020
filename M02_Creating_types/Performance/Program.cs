using System;
using System.Diagnostics;

namespace Performance
{
    class Program
    {
        private static C[] createClassesArray()
        {
            var rand = new Random();
            var classes = new C[100000];

            for (int i = 0; i < classes.Length; i++)
            {
                classes[i] = new C (rand.Next());
            }

            return classes;
        }

        private static S[] createStructsArray()
        {
            var rand = new Random();
            var structs = new S[100000];

            for (int i = 0; i < structs.Length; i++)
            {
                structs[i] = new S (rand.Next());
            }

            return structs;
        }

        private static double calculateClassesTimeDelta (ref C[] classes)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Array.Sort<C> (classes);
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        private static double calculateStructsTimeDelta (ref S[] structs)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Array.Sort<S> (structs);
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        static void Main(string[] args)
        {
            long memorySize = Process.GetCurrentProcess().PrivateMemorySize64;
            C[] classes = createClassesArray();
            long classesMemoryDelta = Process.GetCurrentProcess().PrivateMemorySize64 - memorySize;
            Console.WriteLine ("Classes memory delta : " + classesMemoryDelta);

            memorySize = Process.GetCurrentProcess().PrivateMemorySize64;
            S[] structs = createStructsArray();
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

            double classesTimeDelta = calculateClassesTimeDelta (ref classes);
            Console.WriteLine ("Classes time delta : " + classesTimeDelta);

            double structsTimeDelta = calculateStructsTimeDelta (ref structs);
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
