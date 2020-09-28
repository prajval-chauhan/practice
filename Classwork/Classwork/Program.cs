using System;

namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee wage computation program");
            var random = new Random();
            var randomBool = random.Next(2);
            String attendance;
            if (randomBool == 0)
                attendance = "Present";
            else
                attendance = "Absent";
            Console.WriteLine("Employee is : " + attendance);
        }
    }
}
