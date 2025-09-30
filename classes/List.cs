using System;
using LabbTheOOPHotelP2;

public class List
{
    public static List<Person> GetDefaultList()
    {
        List<Person> hotelStaff = new List<Person>();

        hotelStaff.Add(new Manager() { Name = "Johnson", Age = 26, Department = "Operations", EmployeeId = "E001", Jobtitle = "Production", Salary = 400 });
        hotelStaff.Add(new Employee() { Name = "Bob Smith", Age = 20, Department = "Service", Jobtitle = "Receptionist", EmployeeId = "E004", Salary = 200 });
        hotelStaff.Add(new Housekeeper() { Name = "Malin", Age = 19, EmployeeId = "E003", Salary = 220 });
        hotelStaff.Add(new Consultant() { Name = "David Lee", Age = 20, ConsultingFirm = "MultiMinds", Salary = 600, Jobtitle = "Freelance", Department = "Service", EmployeeId = "E010" });
        hotelStaff.Add(new Employee() { Name = "Eva Green", EmployeeId = "E002", Jobtitle = "Chef", Age = 23, Department = "Kitchen", Salary = 200 });
        foreach (var person in hotelStaff)
        {
            person.PrintInfo();
            person.Introduce();

            if (person is Manager manager)
            {
                manager.HoldMeeting();
            }
            else if (person is Employee employee)
            {
                employee.Work();
            }
            else if (person is Housekeeper housekeeper)
            {
                housekeeper.Work();
            }
            else if (person is Consultant consultant)
            {
                consultant.GiveAdvice();
            }
        }
        return hotelStaff;
        /*
        List<Person> staff = new List<Person>();

        staff.Add(Alice Johnson);  //Manager
        staff.Add(Bob Smith);  //Employee
        staff.Add(Cathy Brown); //Housekeeper
        staff.Add(David Lee);  //Consultant
        staff.Add(Eva Green);  //Employee

        foreach (Person person in staff)
        {
            person.DoWork();
        }
        */
    }
}
