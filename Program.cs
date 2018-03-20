using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class A
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee(1234,"Murali","development",30500.67);
            Console.WriteLine("eid:" +obj[1]);
            Console.WriteLine("ename:" + obj[2]);
            Console.WriteLine("job:" + obj[3]);
            Console.WriteLine("sal:" + obj[4]);
           
            obj[1] = 145;
            obj[2] = "Mohan";
           
            obj[4] = 38000.45;
            Console.WriteLine();
            Console.WriteLine("eid:" + obj[1]);
            Console.WriteLine("ename:" + obj[2]);
            Console.WriteLine("job:" + obj[3]);
            Console.WriteLine("sal:" + obj[4]);

            Console.ReadKey();

        }
    }
}
