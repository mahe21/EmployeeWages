﻿namespace EmployeePayRole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeePayRole employeePayRole = new EmployeePayRole();
            employeePayRole.EmployeeAttendence();

            employeePayRole.EmployeeWage();

            employeePayRole.PartTimeWage();

            employeePayRole.PartTimeWageSwitchCase();

            employeePayRole.EmployeeMonthlyWage();

            employeePayRole.EmployeeWageMaxHours();
        }
    }
}