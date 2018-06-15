using SimpleFactoryPattern.NormalCode;
using SimpleFactoryPattern.PatternCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 未使用简单工厂，则需要手动创建类
            var result = string.Empty;
            DatabaseConnection conn;

            conn = new MySqConnection();
            result = conn.GetDatabaseConnection();
            Console.WriteLine(result);

            conn = new SqlServerConnection();
            result = conn.GetDatabaseConnection();
            Console.WriteLine(result);
            #endregion


            #region 简单工厂模式写法

            var factory = DatabaseSourceFactory.GetDatabaseConnection("Mysql");
            result = factory.GetDatabaseConnection();
            Console.WriteLine(result);
            #endregion 
            
            Console.ReadKey();

        }
    }
}
