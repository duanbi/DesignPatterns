using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.PatternCore
{
    public class Singleton1
    {

        /*
         * 简单的 单例写法
         * 
         * 存在问题：如果遇到并行的时候,将会同时创建俩个或多个,不符合单例的设计理念, 升级后见Singleton2
         * 
         * */

        /// <summary>
        /// 私有的构造方法
        /// </summary>
        private Singleton1()
        {
        }

        private static Singleton1 _instance;

        /// <summary>
        /// 提供一个全局访问方法
        /// </summary>
        /// <returns></returns>
        public static Singleton1 Instance()
        {
            if (_instance == null )
            {
                _instance = new Singleton1();
            }
            return _instance;
        }
    }
}
