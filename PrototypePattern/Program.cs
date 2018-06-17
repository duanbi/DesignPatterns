using PrototypePattern.PatternCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {

            // 细胞 原型
            Cell cell = new CellCleavage("cell_base");

            Console.WriteLine("Base:\t" + cell.GetHashCode());

            // 变一个
            Cell cloneCell = cell.Clone() as CellCleavage;
            Console.WriteLine("Cloned1:\t" + cloneCell.Identifiy);
            Console.WriteLine("Cloned1:\t" + cloneCell.GetHashCode());



            // 再变一个
            Cell cloneCell2 = cell.Clone() as CellCleavage;
            Console.WriteLine("Cloned2:\t" + cloneCell2.Identifiy);
            Console.WriteLine("Cloned2:\t" + cloneCell2.GetHashCode());

            Console.ReadKey();
        }
    }
}
