using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageProgram
{
    public interface IComputeEmpWage
    {
        public void addCompanyEmpWage(String companyName, int empRatePerHr, int numOfWorkingDays, int maxHrsPerMonth);
        public void computeEmpWage();
        public int getTotalWage(string companyName);

    }
}
