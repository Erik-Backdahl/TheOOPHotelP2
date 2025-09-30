using System;
namespace LabbTheOOPHotelP2
{

    public class Person
    {
        public required string Name { get; set; }
        public required int Age { get; set; }
        public required string EmployeeId { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public required decimal Salary { get; set; } = 0;
        public Person()
        {

        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        public void Introduce()
        {
            Console.WriteLine($"Hej, mitt namn är: {Name} och jag är: {Age} år gammal.");
        }
        
    }
}
