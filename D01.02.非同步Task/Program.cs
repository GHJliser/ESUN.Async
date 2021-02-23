using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace D01._02.非同步Task
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLog("Main Start");
            var t = RunJob();
            WriteLog("Main End");
            //t.Wait();
        }

        static Task RunJob()
        {
            WriteLog("Job Start");
            var task = new Task(() =>
            {
                Thread.Sleep(2000);
                WriteLog("in Job");
            });
            task.Start();
            return task;
        }

        static void WriteLog(string msg)
        {
            Console.WriteLine($"Thread:{Thread.CurrentThread.ManagedThreadId} Say:{msg}");
        }
    }
}
