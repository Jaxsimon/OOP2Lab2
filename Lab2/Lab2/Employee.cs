using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Employee
    {
        public string id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public long sin { get; set; }
        public string dob { get; set; }
        public string dept { get; set; }

        public Employee()
        {

        }

        public Employee(string id, string name, string address, string phone, long sin, string dob, string dept)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.sin = sin;
            this.dob = dob;
            this.dept = dept;
        }


        public virtual string ToString()
        {
            return $"\nPerson ID: {this.id} \n" +
                $"Name: {this.name} \n" +
                $"Address: {this.address} \n" +
                $"Phone Number: {this.phone} \n" +
                $"SIN: {this.sin} \n" +
                $"Date of Birth: {this.dob} \n" +
                $"Department: {this.dept}";
        }

    }
     
}
