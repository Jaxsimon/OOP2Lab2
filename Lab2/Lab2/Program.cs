using System;

namespace Lab2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            List<Salaried> allSalaried = new List<Salaried>();
            List<Wages> allWaged = new List<Wages>();
            List<PartTime> allPartTime = new List<PartTime>();
            string[] allemploy = File.ReadAllLines("/Users/jaxso/source/repos/Lab2/Lab2/employees.txt");

            double sum = 0;

            foreach (string employ in allemploy )
            {
                string[] employeeData = employ.Split(":");

                if ((Char.ToString(employ[0]) == "0") || (Char.ToString(employ[0]) == "1") || (Char.ToString(employ[0]) == "2") || (Char.ToString(employ[0]) == "3") || (Char.ToString(employ[0]) == "4"))
                {
                    Salaried salaried = new Salaried(employeeData[0], employeeData[1], employeeData[2], employeeData[3], long.Parse(employeeData[4]), employeeData[5], employeeData[6], double.Parse(employeeData[7]));
                    employees.Add(salaried);
                    allSalaried.Add(salaried);
                    Console.WriteLine(salaried.ToString());
                    Console.WriteLine(salaried.GetPay());
                    sum += salaried.GetPay();
                }

                if ((Char.ToString(employ[0]) == "5") || (Char.ToString(employ[0]) == "6") || (Char.ToString(employ[0]) == "7"))
                {
                    Wages waged = new Wages(employeeData[0], employeeData[1], employeeData[2], employeeData[3], long.Parse(employeeData[4]), employeeData[5], employeeData[6], double.Parse(employeeData[7]), double.Parse(employeeData[8]));
                    employees.Add(waged);
                    allWaged.Add(waged);
                    Console.WriteLine(waged.ToString());
                    Console.WriteLine(waged.GetPay());
                    sum += waged.GetPay();
                }

                if ((Char.ToString(employ[0]) == "8") || (Char.ToString(employ[0]) == "9"))
                {
                    PartTime partTime = new PartTime(employeeData[0], employeeData[1], employeeData[2], employeeData[3], long.Parse(employeeData[4]), employeeData[5], employeeData[6], double.Parse(employeeData[7]), double.Parse(employeeData[8]));
                    employees.Add((partTime));
                    allPartTime.Add(partTime);
                    Console.WriteLine(partTime.ToString());
                    Console.WriteLine(partTime.GetPay());
                    sum += partTime.GetPay();
                }


            }
            //Calculate Average
            double average = sum / employees.Count;
            Console.WriteLine($"\nAverage wage is: {Math.Round(average, 2)} \n");

            //Highest Weekly Pay for Wage Employees
            double highWage = allWaged.Max(waged => waged.GetPay());

            foreach (Wages waged in allWaged)
            {
                if (waged.GetPay() == highWage)
                {
                    Console.WriteLine($"The person with the highest weekly pay is {waged.name} with a pay of {waged.GetPay()}\n");
                }
            }


            //Lowest Salary for Salaried Employees
            double lowSal = allSalaried.Min(salaried => salaried.salary);

            foreach (Salaried salaried in allSalaried)
            {
                if (salaried.salary == lowSal)
                {
                    Console.WriteLine($"The person with the lowest salary is {salaried.name} with a salary of {salaried.salary}\n");
                }
            }



            //Calculate percentage of employees in each category
            double allPer = employees.Count;
            double salPer = allSalaried.Count / allPer * 100;
            double wagePer = allWaged.Count / allPer * 100;
            double ptPer = allPartTime.Count / allPer * 100;

            Console.WriteLine($"The percentages of employess that belong to each category is:\n" +
                $"Salaried: {Math.Round(salPer,2)}%\n" +
                $"Waged: {Math.Round(wagePer,2)}%\n" +
                $"Part-Time: {Math.Round(ptPer,2)}%");

        }
    }
}
