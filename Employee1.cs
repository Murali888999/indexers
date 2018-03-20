using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Employee1
    {
        int eid;
        string ename;
        string job;
        double salary;
        public Employee1(int eid, string ename, string job, double salary)
        {
            this.eid = eid;
            this.ename = ename;
            this.job = job;
            this.salary = salary;
        }
        public object this[string name]
        {
            get
            {
                if (name.ToUpper() == "EID")
                    return eid;
                else if (name.ToUpper() == "ENAME")
                    return ename;
                else if (name.ToUpper() == "JOB")
                    return job;
                else if (name.ToUpper() == "SALARY")
                    return salary;
                return null;
            }
            set
            {
                if (name.ToUpper() == "EID")
                    eid = (int)value;
                else if (name.ToUpper() == "ENAME")
                    ename = (string)value;
                else if (name.ToUpper() == "JOB") 
                    job = (string)value;
                else if (name.ToUpper() == "SALARY")
                    salary = (double)value;
            }
        }
    }
}