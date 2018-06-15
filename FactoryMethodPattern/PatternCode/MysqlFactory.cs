using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.PatternCode
{
    public class MysqlFactory : BaseFactory
    {
        public override DatabaseConnection GetDatabaseConnection()
        {
            return new MySqConnection();
        }
    }
}
