using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRole
{
    internal class EmployeePayRole
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;

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

        public void PartTimeWage()
        {
            int IS_FULL_TIME = 2;
            int IS_PART_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            
            int emp_Hrs = 0;
            int emp_Wage = 0;
            
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            if (empCheck == IS_PART_TIME)

            {
                emp_Hrs = 4;

            }
            else if (empCheck == IS_FULL_TIME)
            {
                emp_Hrs = 8;
            }
            else
            {
                emp_Hrs = 0;
            }
            emp_Wage = emp_Hrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wage:" + emp_Wage);
        }

        public void PartTimeWageSwitchCase()
        {
            int emp_Hrs = 0;
            int emp_Wage = 0;
            

        Random random = new Random();
            int empCheck = random.Next(0, 3);

            switch (empCheck)
            {
                case IS_PART_TIME:
                    emp_Hrs = 4;
                    break;
                case IS_FULL_TIME:
                    emp_Hrs = 8;
                    break;
                default:
                    emp_Hrs = 0;
                    break;
            }
            emp_Wage = emp_Hrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wage:" + emp_Wage);
        }

        public void EmployeeMonthlyWage()
        {
            int emp_Hrs = 0;
            int emp_Wage = 0;
            int total_emp_wage = 0;

            //random function
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        emp_Hrs = 4;
                        break;
                    case IS_FULL_TIME:
                        emp_Hrs = 8;
                        break;
                    default:
                        emp_Hrs = 0;
                        break;
                }
                emp_Wage = emp_Hrs * EMP_RATE_PER_HOUR;
                total_emp_wage += emp_Wage;
                Console.WriteLine("Employee wage:" + emp_Wage);
            }
            Console.WriteLine("Total Employee Wage:" + total_emp_wage);
        }
    }
}
