using LabbTheOOPHotelP2;
class Endpoints
{
    public static Person AddPerson()
    {
        string name = ValidateInput.ValidateString();
        int age = ValidateInput.ValidateInt();
        string employeeId = ValidateInput.ValidateString();
        int salary = ValidateInput.ValidateInt();
        var Person = new Person()
        {
            Name = name,
            Age = age,
            EmployeeId = employeeId,
            Salary = salary
        };
        return Person;
    }
    public static Manager AddManager()
    {
        string name = ValidateInput.ValidateString();
        int age = ValidateInput.ValidateInt();
        string employeeId = ValidateInput.ValidateString();
        int salary = ValidateInput.ValidateInt();
        string jobtitle = ValidateInput.ValidateString();
        string department = ValidateInput.ValidateString();
        var Manager = new Manager()
        {
            Name = name,
            Age = age,
            EmployeeId = employeeId,
            Salary = salary,
            Jobtitle = jobtitle,
            Department = department
        };
        return Manager;
    }
    public static Consultant AddConsultant()
    {
        string name = ValidateInput.ValidateString();
        int age = ValidateInput.ValidateInt();
        string employeeId = ValidateInput.ValidateString();
        int salary = ValidateInput.ValidateInt();
        string jobtitle = ValidateInput.ValidateString();
        string department = ValidateInput.ValidateString();
        string consultingFirm = ValidateInput.ValidateString();

        var consultant = new Consultant()
        {
            Name = name,
            Age = age,
            EmployeeId = employeeId,
            Salary = salary,
            Jobtitle = jobtitle,
            Department = department,
            ConsultingFirm = consultingFirm
        };
        return consultant;
    }
}
