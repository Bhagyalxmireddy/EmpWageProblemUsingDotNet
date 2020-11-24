using System;

namespace EmpWageProgram
{
    class EmpWage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome to Empolyee Wage Computation Program");
            EmpWageBulider empWageBulider = new EmpWageBulider();
            empWageBulider.addCompanyEmpWage("BridgeLabz", 20, 5, 60);
            empWageBulider.computeEmpWage();
            Console.WriteLine("Total Wage  for BridgeLabz company : " + empWageBulider.getTotalWage("BridgeLabz"));

        }
    }
}