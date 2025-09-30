class Employee : Person
{
    string Jobtitle { get; set; }
    string Department { get; set; }
    public void Work()
    {
        Console.WriteLine("This person is working");
    }
}