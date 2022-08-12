﻿using System;

class Program
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;
    public const int EMP_RATE_PER_HOUR = 20;
    public const int NUM_OF_WORKING_DAYS = 20;
    public const int MAX_HRS_IN_MONTH = 100;
    public static void Main(string[] args)
    {


        int empHrs = 0;
        int empWage = 0; 
        int totalWorkingDays = 0;
        int totalEmphrs = 0;
        while(totalEmphrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
        {
            totalWorkingDays++;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            totalEmphrs += empHrs;
            Console.WriteLine("Days: " +totalWorkingDays + "Emp Hrs "+ empHrs); ;


        }
        int totalEmpWage = totalEmphrs * EMP_RATE_PER_HOUR;
        Console.WriteLine("Total Emp Wage : " +totalEmpWage);

 
    }
}