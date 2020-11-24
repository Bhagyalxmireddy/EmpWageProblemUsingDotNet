using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageProgram
{
    class CompanyEmpWage
    {
        public string companyName;
        public int empRatePerHr;
        public int numOfWorkingDays;
        public int maxHrsPerMonth;
        public int totalEmpWage;

        public CompanyEmpWage(String companyName, int empRatePerHr, int numOfWorkingDays, int maxHrsPerMonth)
        {
            this.companyName = companyName;
            this.empRatePerHr = empRatePerHr;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHrsPerMonth = maxHrsPerMonth;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "Total empwage for company : " + this.companyName + " is: " + this.totalEmpWage;
        }
    }
}
