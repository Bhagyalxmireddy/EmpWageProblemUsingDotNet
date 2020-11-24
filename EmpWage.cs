using System;

namespace EmpWageProgram
{
    class EmpWage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome to Empolyee Wage Computation Program");
            EmpWageBuliderArray empWageBulider = new EmpWageBuliderArray();
            empWageBulider.addCompanyEmpWage("BridgeLabz", 20, 5, 60);
            empWageBulider.computeEmpWage();
        }
    }
}