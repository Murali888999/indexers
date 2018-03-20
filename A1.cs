using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class B
    {
        static void Main(string[] args)
        {
            Employee1 obj1 = new Employee1(1234, "mohan", "Testing", 30500.88);
            Console.WriteLine("eid:" + obj1["eid"]);
            Console.WriteLine("ename:" + obj1["enaMe"]);
            Console.WriteLine("job:" + obj1["job"]);
            Console.WriteLine("salary:" + obj1["salary"]);
            
            Console.WriteLine();
            obj1["eid"] = 4444;
            obj1["job"] = "administrator";
            obj1["salary"] = 39000.45;

            Console.WriteLine("eid:" + obj1["eid"]);
            Console.WriteLine("ename:" + obj1["eName"]);
            Console.WriteLine("job:" + obj1["joB"]);
            Console.WriteLine("salary:" + obj1["salary"]);
            Console.ReadKey();
        }
    }
}
