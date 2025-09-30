using System;

namespace TheOOPHotelP2
{
	internal class Manager : Person
	{
		public string Department { get; set }


		public Manager(string department)
		{
			Department = department;
			Name = name;
		}


		public void HoldMeeting()
		{
			Console.WriteLine($"{Name} is hosting a meeting for the hotel personell.");
		}
		public void PlanBudget()
		{
			Console.WriteLine($"{Name} is planning the hotel budget.");
		}
	}
}