using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.PatternCore
{
    public class Singleton2
    {
        /*
         * Singleton2 中先判断不为空则返回，目的是提高效率， lock 会影响效率
         * 
         * 问题：如果要使用单例， 每个类都需要样写吗？ 可以提供一个单例泛型， 见Singleton
         * 
         * */

        private static readonly object locker = new object();
        /// <summary>
        /// 私有的构造方法
        /// </summary>
        private Singleton2()
        {
        }

        private static Singleton2 _instance;

        /// <summary>
        /// 提供一个全局访问方法
        /// </summary>
        /// <returns></returns>
        public static Singleton2 Instance()
        {
            if (_instance != null)
            {
                return _instance;
            }
            lock (locker)
            {
                // 注：外面判断为null, 里面还进行判断null, 也是多线程是创建多个对象
                if (_instance == null)
                {
                    _instance = new Singleton2();
                }
                return _instance;
            }
            
        }
    }
}
