using System;

namespace EmpWageProgram
{
    class EmpWage
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int EMP_RATE_PER_HR = 20;
        public const int MAX_HRS_IN_MONTH = 100;
        static void Main(string[] args)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            Console.WriteLine("WelCome to Empolyee Wage Computation Program");
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays <NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case 1:
                        empHrs = 8;
                        break;
                    case 2:                  
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day : " + totalWorkingDays + " Emp Hrs: " +empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Total Employee wage is :" + totalEmpWage);
        }
    }
}
