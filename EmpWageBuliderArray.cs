using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageProgram
{
    class EmpWageBuliderArray
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;

        private int numOfComapany = 0;
        private CompanyEmpWage[] companyEmpwageArray;

        public EmpWageBuliderArray()
        {
            this.companyEmpwageArray = new CompanyEmpWage[5];
        }
        public void  addCompanyEmpWage(String companyName, int empRatePerHr, int numOfWorkingDays, int maxHrsPerMonth)
        {
            companyEmpwageArray[this.numOfComapany] = new CompanyEmpWage(companyName, empRatePerHr, numOfWorkingDays, maxHrsPerMonth);
            numOfComapany++;
        }
        public void computeEmpWage()
        {
            for(int i = 0; i < numOfComapany; i++)
            {
                companyEmpwageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpwageArray[i]));
                Console.WriteLine(this.companyEmpwageArray[i].toString());
            }
        }

        /// <summary>
        /// Computes the emp wage.
        /// </summary>
        /// <returns></returns>
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= companyEmpWage.maxHrsPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
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
            return totalEmpHrs * companyEmpWage.empRatePerHr;
        }
        
    }
}
