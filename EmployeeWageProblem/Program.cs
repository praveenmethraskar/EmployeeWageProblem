using EmployeeWageProblem;
using System;

class Program
{
    
    public static void Main(string[] args)
    {
        //EmpWageBuilderObject dMart = new EmpWageBuilderObject("Dmart",20,2,10);
        //EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance",10,4,20);
        //dMart.computeEmpWage();
        //Console.WriteLine(dMart.toString());
        //reliance.computeEmpWage();
        //Console.WriteLine(reliance.toString());

        EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
        empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
        empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
        empWageBuilder.computeEmpWage();
    }
}