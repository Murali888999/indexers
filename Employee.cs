using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Employee
    {
        int eid;
        string ename;
        string job;
        double sal;
        public Employee(int eid, string ename, string job, double sal)
        {
            this.eid = eid;
            this.ename = ename;
            this.job = job;
            this.sal = sal;
        }
        public object this[int index]
        {
            get
            {
                if (index == 1)
                    return eid;
                else if (index == 2)
                    return ename;
                else if (index == 3)
                    return job;
                else if (index == 4)
                    return sal;
                return null;
            }
            set
            {
                if (index == 1)
                    eid = (int)value;
                else if (index == 2)
                    ename = (string)value;
                else if (index == 3)
                    job = (string)value;
                else if (index == 4)
                    sal = (double)value;
            }
        }

    }
}
