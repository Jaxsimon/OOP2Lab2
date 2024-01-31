using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Salaried : Employee
    {

        public double salary {  get; set; }

        public Salaried()
        {

        }
        public Salaried(string id, string name, string address, string phone, long sin, string dob, string dept, double salary) 
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.sin = sin;
            this.dob = dob;
            this.dept = dept;
            this.salary = salary;
        }

        public double GetPay()
        {
            double pay = salary / 52;
            return Math.Round(pay, 2);
        }

        public override string ToString() 
        {
            return $"\nPerson ID: {this.id} \n" +
                $"Name: {this.name} \n" +
                $"Address: {this.address} \n" +
                $"Phone Number: {this.phone} \n" +
                $"SIN: {this.sin} \n" +
                $"Date of Birth: {this.dob} \n" +
                $"Department: {this.dept} \n" +
                $"Salary: {this.salary}";
        }

    }
}
