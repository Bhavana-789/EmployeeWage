using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Employee1
    {
        public void UC1Employee()
        {
            Console.WriteLine("Welcome to UC1");
            Random random = new Random();
            int num = random.Next(0, 2);
            if (num == 0)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");


            }


        }
        public void UC2DailyEmployeeWage()
        {
            Console.WriteLine("Welcome to UC2");
            int totalWorkingHour = 8;
            int wagePerHour = 20;
            int dailyWage = 0; 
            Random random = new Random();
            int num = random.Next(0, 2);
            if (num == 0)
            {
                Console.WriteLine("Employee is Present");
                dailyWage = totalWorkingHour * wagePerHour;
                Console.WriteLine("Total Daily wage is:" + dailyWage);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                Console.WriteLine("Total daily wage is:" + dailyWage);
            }

        }
        public void UC3()
        {
            int totalWorkingHour = 8;
            int partTimeHour = 4;
            int wagePerHour = 20;
            int dailywage = 0;
            Random random = new Random();
            int EmpWorkingTime = random.Next(0, 3);
            if (EmpWorkingTime == 0)
            {
                Console.WriteLine("Employee is present for full time");
                dailywage = totalWorkingHour * wagePerHour;
                Console.WriteLine("Total Daily wage is:" + dailywage);
            }
            else if (EmpWorkingTime == 1)
            {
                Console.WriteLine("Employee is present for part time");
                dailywage = partTimeHour * wagePerHour;
                Console.WriteLine("Total Daily Wage is:" + dailywage);
            }
            else
            {
                Console.WriteLine("Employee is absent");
                Console.WriteLine("Total Daily Wage is:" + dailywage);
            }
        }
        public void UC4()
        {
            int isPartTime = 1;
            int isFullTime = 2;
            int wagePerHour = 20;
            int empHrs;
            int dailywage = 0;
            Random random = new Random();
            int EmpWorkingTime = random.Next(0, 3);

            switch (EmpWorkingTime)
            {
                case 1:
                    empHrs = 8;
                    Console.WriteLine("Employee is present for full time");
                    break;
                case 2:
                    empHrs = 4;
                    Console.WriteLine("Employee is present for part time");
                    break;
                default:
                    empHrs = 0;
                    Console.WriteLine("Employee is absent");
                    break;
            }
            dailywage = empHrs * wagePerHour;
            Console.WriteLine("Total daily wage of employee is:");
        }
    }
}
        



































