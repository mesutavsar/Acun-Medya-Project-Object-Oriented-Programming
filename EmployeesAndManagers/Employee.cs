using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAndManagers2
{
    internal class Employee
    {
        private string name;
        private string surName;
        private string startJob;
        private int salary;

        public Employee(string name, string surName, string startJob, int salary) //bir nesneyi oluşturmanın temellerini 
                                                                                   //belirleriz. Yani kullanıcıdan alacağımız
                                                                                   //özellikleri belirleriz.

        {
            this.Name = name;
            this.SurName = surName;
            this.StartJob = startJob;
            this.Salary = salary;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string SurName
        {
            get { return surName; }
            set { surName = value; }
        }

        public string StartJob
        {
            get { return startJob; }
            set { startJob = value; }
        }
             

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}
