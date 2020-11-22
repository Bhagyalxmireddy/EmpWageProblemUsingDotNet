using System;

namespace EmpWageProgram
{
    class EmpWage
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int EMP_RATE_PER_HR = 20;
        static void Main(string[] args)
        {
            int empHrs = 0, empWage = 0, empWagePerMonth = 0;
            Console.WriteLine("WelCome to Empolyee Wage Computation Program");
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empcheck = random.Next(0, 3);

                switch (empcheck)
                {
                    case 1:
                       // Console.WriteLine("Employee is Present and Employee is Fulltime");
                        empHrs = 8;
                        break;
                    case 2:
                       // Console.WriteLine("Employee is Present and Employee is Parttime");
                        empHrs = 4;
                        break;
                    default:
                       // Console.WriteLine("Employee is Absent");
                        empHrs = 0;
                        break;

                }
                empWage = empHrs * EMP_RATE_PER_HR;
                empWagePerMonth += empWage;
                Console.WriteLine("Daily Employee wage is :" + empWage);
            }
            Console.WriteLine("Monthly Employee wage is :" + empWagePerMonth);
        }
    }
}
