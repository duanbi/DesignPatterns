using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.NormalCode
{
    public class MySqConnection : DatabaseConnection
    {
        public override string GetDatabaseConnection()
        {
            return "Mysql Database Connection";
        }
        
    }
}
