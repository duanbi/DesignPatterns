using SingletonPattern.PatternCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            Parallel.For(0, 1000, (i, state) =>
            {
                Singleton<DatabaseSource>.Instance.GetDatabaseConnection();
            });
            sw.Stop();

            Console.WriteLine(sw.Elapsed.TotalMilliseconds);
            Console.ReadKey();
        }
    }
}
