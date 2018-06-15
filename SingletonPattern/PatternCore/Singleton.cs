using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton<T> where T : class
    {
        private static T _instance;
        private static readonly object Obj = new object(); static T instance;

        /// <summary>
        /// 单例模式
        /// </summary>
        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (Obj)
                    {
                        if (_instance == null)
                        {
                            _instance = Activator.CreateInstance<T>();  // 动态创建
                        }
                    }
                }
                return _instance;
            }


            //get
            //{
            //    if (_instance != null)
            //    {
            //        return _instance;
            //    }
            //    lock (Obj)
            //    {
            //        if (_instance == null)
            //        {
            //            _instance = Activator.CreateInstance<T>();  // 动态创建
            //        }
            //    }
            //    return _instance;
            //}
        }
    }
}
