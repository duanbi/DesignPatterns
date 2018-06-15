using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.PatternCore
{
    public class DatabaseSource
    {

        public void GetDatabaseConnection()
        {
            Console.WriteLine("DatabaseSource -> GetDatabaseConnection");
        }

    }
}
