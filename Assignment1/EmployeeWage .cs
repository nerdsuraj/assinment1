﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class EmployeeWage
    {

        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        public const int MAX_HR_IN_MONTH = 10;
        public static void EmployeeSalary()
        {
            
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int totalEmpHr = 0;
            int totalWorkingDays = 0;

            while (totalEmpHr <= MAX_HR_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                Random random = new Random();
                int num = random.Next(0, 3);
                switch (num)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHr += empHrs;
                Console.WriteLine("day#:" + totalWorkingDays + "Emp Hrs" + empHrs);
            }
            totalEmpWage = totalEmpHr * EMP_RATE_PER_HOUR;
            Console.WriteLine("total emp wage : " + totalEmpWage);
        }
        
    }
}
