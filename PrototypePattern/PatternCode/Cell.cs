using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.PatternCode
{
    /// <summary>
    /// 细胞
    /// </summary>
    public abstract class Cell
    {
        public Cell(string identifiy)
        {
            this.Identifiy = identifiy;
        } 
        /// <summary>
        /// 标识
        /// </summary>
        public string Identifiy { get; set; }

        /// <summary>
        /// 细胞核
        /// </summary>
        public string CellNucleus { get; set; }

        /// <summary>
        /// 细胞液
        /// </summary>
        public string CellSap { get; set; }


        public abstract Cell Clone();
    }
}
