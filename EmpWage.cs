using System;

namespace EmpWageProgram
{
    class EmpWage
    {
        static void Main(string[] args)
        {
            int FULL_TIME = 1;
            int EMP_WAGE_PER_HR = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            Console.WriteLine("WelCome to Empolyee Wage Computation Program");
            
            if(empcheck == FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = empHrs * EMP_WAGE_PER_HR;
            Console.WriteLine("Employee wage is :" + empWage);
        }
    }
}
