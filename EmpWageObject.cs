using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageProgram
{
    class EmpWageObject
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        // public const int NUM_OF_WORKING_DAYS = 20;
        // public const int EMP_RATE_PER_HR = 20;
        // public const int MAX_HRS_IN_MONTH = 100;
        public int totalEmpWage;
        private string companyName;
        private int empRatePerHr;
        private int numOfWorkingDays;
        private int maxHrsPerMonth;
        public EmpWageObject(String companyName, int empRatePerHr, int numOfWorkingDays, int maxHrsPerMonth)
        {
            this.companyName = companyName;
            this.empRatePerHr = empRatePerHr;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHrsPerMonth = maxHrsPerMonth;
        }
        /// <summary>
        /// Computes the emp wage.
        /// </summary>
        /// <returns></returns>
        public void computeEmpWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= this.maxHrsPerMonth && totalWorkingDays < this.numOfWorkingDays)
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
                Console.WriteLine("Day : " + totalWorkingDays + " Emp Hrs: " + empHrs);
            }
            totalEmpWage = totalEmpHrs * this.empRatePerHr;
            Console.WriteLine("Total Employee wage is :" + totalEmpWage);
        }
        public string toString()
        {
            return "Total EmpWage for Company: " + this.companyName + " is: " + totalEmpWage;
        }
        
    }
}
