﻿using System;

class Program
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;
    public const int EMP_RATE_PER_HOUR = 20;
    public static void Main(string[] args)
    {


        int empHrs = 0;
        int empWage = 0;

        Random random = new Random();

        int empCheck = random.Next(0,3);

        switch(empCheck)
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
        empWage = empHrs * EMP_RATE_PER_HOUR;
        Console.WriteLine("Emp Wage : "+empWage);


        //if(empCheck == IS_PART_TIME)
        //{
        //    empHrs = 4;
        //}
        //else if(empCheck == IS_FULL_TIME)
        //{
        //    empHrs = 8;
        //}
        //else
        //{
        //    empHrs=0;
        //}
    }
}