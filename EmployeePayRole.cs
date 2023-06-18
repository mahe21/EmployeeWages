using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRole
{
    internal class EmployeePayRole
    {
        public void EmployeeAttendence()
        {
            int IS_FULL_TIME = 1;
            
            Random random = new Random();
            int empCheck = random.Next(2);

            if (empCheck == IS_FULL_TIME)

            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }

        public void EmployeeWage()
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            
            int emp_Hrs = 0;
            int emp_Wages = 0;


            
            Random random = new Random();
            int empCheck = random.Next(2);

            if (empCheck == IS_FULL_TIME)

            {
                emp_Hrs = 8;
            }
            else
            {
                emp_Hrs = 0;
            }
            emp_Wages = emp_Hrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage is:" + emp_Wages);
        }
    }
}
