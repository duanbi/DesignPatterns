using SimpleFactoryPattern.NormalCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.PatternCode
{
    public class DatabaseSourceFactory
    {
        //public static string GetDatabaseConnection(string type)
        //{
        //    var result = string.Empty;

        //    DatabaseConnection conn;

        //    switch (type)
        //    {
        //        case "Mysql":
        //            conn = new MySqConnection();
        //            result = conn.GetDatabaseConnection();
        //            break;
        //        case "Sql Server":
        //            conn = new SqlServerConnection();
        //            result = conn.GetDatabaseConnection();
        //            break;
        //        default:
        //            break;
        //    }
        //    return result;
        //}


        public static DatabaseConnection GetDatabaseConnection(string type)
        {

            DatabaseConnection conn = null; 

            switch (type)
            {
                case "Mysql":
                    conn = new MySqConnection();
                    break;
                case "Sql Server":
                    conn = new SqlServerConnection();
                    break;
                default:
                    break;
            }
            return conn;
        }
    }
}
