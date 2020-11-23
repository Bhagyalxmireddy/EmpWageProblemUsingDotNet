using System;

namespace EmpWageProgram
{
    class EmpWage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome to Empolyee Wage Computation Program");
            EmpWageObject bridgeLabz = new EmpWageObject("BridgeLabz", 20, 10, 40);
            bridgeLabz.computeEmpWage();
            Console.WriteLine(bridgeLabz.toString());
        }
    }
}