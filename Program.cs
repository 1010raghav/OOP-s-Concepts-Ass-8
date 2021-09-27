using System;

namespace Employee_wage_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("UC8 output");
            
            UC8_ComputeEmpWageForMultipleCompanies obj = new UC8_ComputeEmpWageForMultipleCompanies();
            obj.ComputeEmpWage("TCS", 10, 2, 8);
            
           } 
     }         
} 
