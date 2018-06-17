using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.PatternCode
{
    public class DirectorBox
    {

        public List<Computer> Construct(BaseEmployee employee)
        {
            return employee.Complete();
        }
    }
}
