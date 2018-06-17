using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.PatternCode
{
    public class CellCleavage : Cell
    {
        public CellCleavage(string identifiy)
            : base(identifiy)
        { }

        public override Cell Clone()
        {
            return (Cell)this.MemberwiseClone();
        }
    }
}
