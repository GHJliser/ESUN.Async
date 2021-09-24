using BenchmarkDotNet.Running;
using System;

namespace ConcurrentBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var summary = BenchmarkRunner.Run<DictionaryTest>();
        }
    }
}
