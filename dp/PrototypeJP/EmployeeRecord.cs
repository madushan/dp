using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypeJP
{
    class EmployeeRecord:IPrototype
    {
        private int id;
        private string name, designation;
        private double salary;
        private string address;

        public EmployeeRecord()
        {
            Console.WriteLine(" Employee records of oracle corporation ");
            Console.WriteLine(" -------------------------------------------- ");
            Console.WriteLine("Eid" + "\t" + "Ename" + "\t" + "Edesignation" + "\t" + "Esalary" + "\t\t" + "Eaddress");
        }

        public EmployeeRecord(int id, string name, string designation, double salary, string address)
        {
            this.id = id;
            this.name = name;
            this.designation = designation;
            this.salary = salary;
            this.address = address;
        }
        public void ShowRecord()
        {
            Console.WriteLine(id + "\t" + name + "\t" + designation + "\t" + salary + "\t" + address);
        }

        public IPrototype getClone()
        {
            return new EmployeeRecord(id,name,designation,salary,address);
        }
    }
}
