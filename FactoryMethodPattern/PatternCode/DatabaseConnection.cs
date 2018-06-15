using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.PatternCode
{
    public abstract class DatabaseConnection
    {
        public abstract string GetDatabaseConnection();
    }
}
