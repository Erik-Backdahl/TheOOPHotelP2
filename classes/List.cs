using System;

public class List
{
	public List()
	{
        List<Person> hotelStaff = new List<Person>();

        hotelStaff.Add(new Manager("Operations", "Alice Johnson", "M001"));
        hotelStaff.Add(new Employee("Bob Smith", "E001", "Receptionist", "Front Desk"));
        hotelStaff.Add(new Housekeeper("Cathy Brown", "H001"));
        hotelStaff.Add(new Consultant("David Lee", "C001", 150.00m, "Hotel Consulting Inc."));
        hotelStaff.Add(new Employee("Eva Green", "E002", "Chef", "Kitchen"));
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
    }
}
