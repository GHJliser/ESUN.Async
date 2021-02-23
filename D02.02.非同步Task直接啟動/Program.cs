using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace D02._02.非同步Task直接啟動
{
    class Program
    {
        static async Task Main(string[] args)
        {
            WriteLog("Main Start");
            await RunJobAsync();
            WriteLog("Main End");
        }

        static Task RunJobAsync()
        {
            WriteLog("Job Start");
            var task = Task.Run(() =>
            {
                Thread.Sleep(2000);
                WriteLog("in Job");
            });
            return task;
        }

        static void WriteLog(string msg)
        {
            Console.WriteLine($"Thread:{Thread.CurrentThread.ManagedThreadId} Say:{msg}");
        }
    }
}
