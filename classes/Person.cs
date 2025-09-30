using System;
namespace LabbTheOOPHotelP2
{

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public decimal Salary { get; set; }
        public Person(string name, string employeID)
        {
            Name = name;
            EmployeeId = employeID;
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
