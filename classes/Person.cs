using System;
namespace TheOOPHotelP2
{

    public class Person
    {
        public string Name { get; set};
        public int Age { get; set};
        public string EmployeId { get; set; }
        public DateTime StartDate { get; set; }
        public decimal Salary { get; set; }

        public Person()
        {
            Name = name:
            Age = age;
            EmployeId = employeId;
            StartDate = startDate;
            Salary = salary;
        }
         public void PrintInfo()
        {
         Console.Writeline($"Name: {Name}, Age: {Age}");
        }
    }
}
