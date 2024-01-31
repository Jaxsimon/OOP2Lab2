using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class PartTime : Employee
    {

        public double rate {  get; set; }
        public double hours { get; set; }

        public PartTime()
        {

        }

        public PartTime(string id, string name, string address, string phone, long sin, string dob, string dept, double rate, double hours) 
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.sin = sin;
            this.dob = dob;
            this.dept = dept;
            this.rate = rate;
            this.hours = hours;
        }

        public double GetPay()
        {
            double pay = this.rate * this.hours;
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
                $"Wage: {this.rate} \n" +
                $"Hours Worked: {this.hours}";
        }

    }
}
