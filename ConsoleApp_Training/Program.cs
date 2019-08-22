using System;
using System.Diagnostics;

namespace ConsoleApp_Training
{
    class Program
    {
      
        static void Main(string[] args)
        {

            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Reset();
            stopwatch1.Start();

            //Merge_Sorted_Array.subMain();
            Group_Anagrams.subMain(1);

            stopwatch1.Stop();
            Console.WriteLine(stopwatch1.ElapsedMilliseconds);

            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Reset();
            stopwatch2.Start();

            Group_Anagrams.subMain(2);

            stopwatch2.Stop();
            Console.WriteLine(stopwatch2.ElapsedMilliseconds);

        }
    }
}
