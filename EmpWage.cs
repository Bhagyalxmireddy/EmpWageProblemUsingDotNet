using System;

namespace EmpWageProgram
{
    class EmpWage
    {
        static void Main(string[] args)
        {
            int FULL_TIME = 1;
            int PART_TIME = 2;
            int NUM_OF_WORKING_DAYS = 20;
            int EMP_WAGE_PER_HR = 20;
            int empHrs = 0;
            int empWage = 0;
            int empWagePerMonth = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            Console.WriteLine("WelCome to Empolyee Wage Computation Program");

            switch (empcheck)
            {
                case 1:
                    Console.WriteLine("Employee is Present and Employee is Fulltime");
                    empHrs = 8;
                    break;
                case 2:
                    Console.WriteLine("Employee is Present and Employee is Parttime");
                    empHrs = 4;
                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    empHrs = 0;
                    break;

            }
            empWage = empHrs * EMP_WAGE_PER_HR;
            Console.WriteLine("Daily Employee wage is :" + empWage);
            empWagePerMonth = empWage * NUM_OF_WORKING_DAYS;
            Console.WriteLine("Monthly Employee wage is :" + empWagePerMonth);

        }
    }
}
