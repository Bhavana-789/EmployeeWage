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
    }
}
        



































