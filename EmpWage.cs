using System;

namespace EmpWageProgram
{
    class EmpWage
    {
        static void Main(string[] args)
        {
            int FULL_TIME = 1;
            Console.WriteLine("WelCome to Empolyee Wage Computation Program");
            Random random = new Random();
            int empcheck = random.Next(0,2);
            if(empcheck == FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
