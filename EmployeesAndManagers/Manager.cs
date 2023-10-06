using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAndManagers2
{
    internal class Manager : Employee
    {
        public int numberOfWorker;
        public Manager(string name, string surName, string startJob, int salary,int numberOfWorker) : base(name, surName, startJob, salary)
        {
            this.numberOfWorker = numberOfWorker;
        }
    }
}
