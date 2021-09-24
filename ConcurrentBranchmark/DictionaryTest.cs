using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Text;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;

namespace ConcurrentBenchmark
{
    public class DictionaryTest
    {
        [Benchmark]
        public void Test100_Dic() => CreateDic(100);
        [Benchmark]
        public void Test100_Con() => CreateConDic(100);
        [Benchmark]
        public void Test1000_Dic() => CreateDic(1000);
        [Benchmark]
        public void Test1000_Con() => CreateConDic(1000);
        [Benchmark]
        public void Test10000_Dic() => CreateDic(10000);
        [Benchmark]
        public void Test10000_Con() => CreateConDic(10000);

        private void CreateDic(int size)
        {
            var dic = new Dictionary<int, object>();
            for (int i = 0; i < size; i++)
            {
                dic.Add(i, new object());
            }
        }
        private void CreateConDic(int size)
        {
            var dic = new ConcurrentDictionary<int, object>();
            for (int i = 0; i < size; i++)
            {
                dic.TryAdd(i, new object());
            }
        }
    }
}
