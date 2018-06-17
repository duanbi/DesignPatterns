using BuilderPattern.PatternCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * 老板就是：DirectorBox
             * 建造方法就是：BaseEmployee
             * 每个员工都应该会改方法：Employee1
             * 
             * 为什么不把 BaseEmployee 写出接口呢？
             * 
             * 是的，在我工作的几年中， 发现抽象方法和接口差不不多，而大多数喜欢用接口。
             * 其实接口和抽象类还是有本质的区别。
             * 
             * */



            DirectorBox box = new DirectorBox();
            BaseEmployee employee = new Employee1();

            var result = box.Construct(employee);

            foreach (var item in result)
            {
                Console.WriteLine(item.Constructer);
            }
            
            Console.ReadKey();
        }
    }
}
