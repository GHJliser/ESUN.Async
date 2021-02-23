using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D06.使用Lock建立CriticalSection
{
    class Program
    {
        static int total = 0;
        static object countLock = new object();
        static async Task Main(string[] args)
        {
            await Task.WhenAll(Add(1000000), Add(1000000));
            Console.WriteLine($"Total:{total}");
        }

        static Task Add(int loop)
        {
            return Task.Run(() =>
            {
                for (int i = 0; i < loop; i++)
                {
                    lock (countLock)
                    {
                        total++;
                    }
                }
            });
        }
    }
}
