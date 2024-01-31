using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Wages : Employee
    {

        public double rate {  get; set; }
        public double hours { get; set; } 

        public Wages()
        {

        }

        public Wages(string id, string name, string address, string phone, long sin, string dob, string dept, double rate, double hours)
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
            if (this.hours > 40)
            {
                double otHours = this.hours - 40;
                double pay = ((otHours + otHours/2 + 40) * this.rate);
                return pay;
            }
            else
            {
                double pay = this.hours * this.rate;
                return Math.Round(pay,2);
            }

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
