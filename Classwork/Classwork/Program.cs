﻿using System;

namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee wage computation program");
            var random = new Random();
            int leave = 0; int present = 0;
           
            for (int i=1; i<=30; i++)
            {
                var randomBool = random.Next(2);
                switch(randomBool)
                {
                    case 0:
                        leave = leave + 1;
                        break;
                    case 1:
                        present = present + 1;
                        break;
                }
                   
                    
            }
                Console.WriteLine("Total Attendance = " + present +"Total Leaves = " + leave);
            int wph = 20; int fdh = 8;
            int regular_wage = present * wph * fdh;
            int pth = 8;
            int part_time_salary = pth * wph;
            Console.WriteLine("Monthly wage of the employee is : Rs. " +regular_wage);
            Console.WriteLine("Total Monthly wage of the employee is: Rs. " +(regular_wage + part_time_salary));
        }
    }
}
