using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.PatternCode
{
    public class SqlServerConnection : DatabaseConnection
    {
        public override string GetDatabaseConnection()
        {
            return "Sql server Database Connection";
        }

    }
}
