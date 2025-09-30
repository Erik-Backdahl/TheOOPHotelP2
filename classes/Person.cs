using System;
namespace TheOOPHotelP2
{

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string EmployeId { get; set; }
        public DateTime StartDate { get; set; }
        public decimal Salary { get; set; }

        public Person()
        {

        }
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");

            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
        public void Introduce()
        {
            Console.WriteLine($"Hej, mitt namn är: {Name} och jag ör: {Age} år gammal.");
        }
    }
}
