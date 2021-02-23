using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace D02._01.同步化Task
{
    class Program
    {
        static async Task Main(string[] args)
        {
            WriteLog("Main Start");
            await RunJob();
            WriteLog("Main End");
        }

        static Task RunJob()
        {
            WriteLog("Job Start");
            var task = new Task(() =>
            {
                Thread.Sleep(2000);
                WriteLog("in Job");
            });
            task.RunSynchronously();
            return task;
        }

        static void WriteLog(string msg)
        {
            Console.WriteLine($"Thread:{Thread.CurrentThread.ManagedThreadId} Say:{msg}");
        }
    }
}
