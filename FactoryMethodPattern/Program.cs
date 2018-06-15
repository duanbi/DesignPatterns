using FactoryMethodPattern.PatternCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var fac = new MysqlFactory();

            var result = fac.GetDatabaseConnection().GetDatabaseConnection();

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
