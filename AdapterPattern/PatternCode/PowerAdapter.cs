using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.PatternCode
{
    public class PowerAdapter : TwoPin, IThreePin
    {
        public string ThreePinMethod()
        {
            return this.TwoPinMethod();
        }
    }
}
