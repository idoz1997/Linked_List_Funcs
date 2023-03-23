using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndSemesterA
{
    internal class Worker : IComparable<Worker>
    {
        string name;
        int salary;

        public Worker(string name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public void setSalary(int salary)
        {
            this.salary = salary;
        }

        public int getSalary()
        {
            return salary;
        }

        public override string ToString()
        {
            string str = $"Worker's Name: {name}, Salary: {salary} NIS \n";
            return str;
        }

        public int CompareTo(Worker other)
        {
            if (this.salary > other.salary) return 1;
            if (this.salary < other.salary) return -1;
            return 0;
        }

        public override bool Equals(object other)
        {
            if (other is Worker)
            {
                if (this.name == ((Worker)other).name && this.salary == ((Worker)other).salary) return true;
            }
            return false;
        }



    }
}
