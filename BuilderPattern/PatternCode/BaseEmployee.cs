using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.PatternCode
{
    public abstract class BaseEmployee 
    {
     

        /// <summary>
        /// 按照固定的方法去组装
        /// </summary>
        public abstract void Construct();

        /// <summary>
        /// 组装完交给老板
        /// </summary>
        /// <returns></returns>
        public abstract List<Computer> Complete();
    }
}
