using System;
using Lesson3;
using BenchmarkDotNet.Running;


namespace Lesson3_Benchmark_
{
    class Program
    {
        static void Main(string[] args)
        {
    

            BenchmarkRunner.Run<Benchmark>();
            
        }



   
    }
}
