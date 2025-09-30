using System;

namespace LabbTheOOPHotelP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Hotellmanagment");

            Manager manager = new Manager()
            {
                manager.Name = "Anna"
                manager.Age = 45
                manager.EmployeeId = "M001"                
                manager.StartDate = new DateOnly(2015, 3, 1)
                manager.Salary = 60000m
                manager.Department = "Admnistration"
            }
            Employee employee = new Employee()
            {
                employee.Name = "Erik"
                employee.Age = 30
                employee.EmployeeId = "E001"
                employee.StartDate = new DateOnly(2020, 6, 15)
                employee.Salary = 30000m
                employee.Jobtitle = "Receptionist"
                employee.Department = "Front Desk"
            }
            Console.WriteLine(Manager);


        }
    }
}