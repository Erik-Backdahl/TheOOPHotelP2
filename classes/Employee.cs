using LabbTheOOPHotelP2;

class Employee : Person
{
    public required string Jobtitle { get; set; }
    public required string Department { get; set; }
    public void Work()
    {
        Console.WriteLine("This person is working");
    }
}