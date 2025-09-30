using LabbTheOOPHotelP2;

class Employee : Person
{
    public Employee(string name, string employeID, string jobtitle, string department) : base(name, employeID)
    {
        Jobtitle = jobtitle;
        Department = department;
    }

    public string Jobtitle { get; set; }
    public string Department { get; set; }
    public void Work()
    {
        Console.WriteLine("This person is working");
    }
}