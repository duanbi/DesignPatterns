using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.PatternCode
{
    public class Employee1 : BaseEmployee
    {
        private List<Computer> computerList = new List<Computer>();

        public override List<Computer> Complete()
        {
            return computerList;
        }

        public override void Construct()
        {
            computerList.Add(new Computer()
            {
                Constructer = "Employee1 Construct",
                CPU = "Inter 2.6HZ",
                Mainboard = "Think Paid",
                Other = "其他就不写了"
            });
        }
    }
}
