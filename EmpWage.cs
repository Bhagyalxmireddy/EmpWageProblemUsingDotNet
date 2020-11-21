using System;

namespace EmpWageProgram
{
    class EmpWage
    {
        static void Main(string[] args)
        {
            int FULL_TIME = 1;
            int PART_TIME = 2;
            int EMP_WAGE_PER_HR = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            Console.WriteLine("WelCome to Empolyee Wage Computation Program");

            switch (empcheck) {
                case 1:
                    Console.WriteLine("Employee is Present and Employee is Fulltime");
                    empHrs = 8;
                    break;
                case 2:
                     Console.WriteLine("Employee is Present and Employee is Parttime");
                     empHrs = 4;
                    break;
                default:
                     Console.WriteLine("Employee is Absent");
                     empHrs = 0;
                    break;
          
        }
            empWage = empHrs * EMP_WAGE_PER_HR;
            Console.WriteLine("Employee wage is :" + empWage);
        }
    }
}
