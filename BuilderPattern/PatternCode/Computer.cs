using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.PatternCode
{
    public class Computer
    {
        public string Mainboard { get; set; }

        public string CPU { get; set; }

        public string Other { get; set; }

        /// <summary>
        /// 组装者
        /// </summary>
        public string Constructer { get; set; }

    }
}
