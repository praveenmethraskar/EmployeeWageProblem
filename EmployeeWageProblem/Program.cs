using System;

class Program
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;
    
    public static int computeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHourSPerMonth)
    {

        int empHrs = 0; 
        int totalWorkingDays = 0;
        int totalEmphrs = 0;
        while (totalEmphrs <= maxHourSPerMonth && totalWorkingDays < numOfWorkingDays)
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
        int totalEmpWage = totalEmphrs * empRatePerHour;
        Console.WriteLine("Total Emp Wage : " +totalEmpWage);
        return totalEmpWage;
    }
    public static void Main(string[] args)
    {
        computeEmpWage("Dmart",20,2,10);
        computeEmpWage("Jio", 10, 5, 30);
    }
}