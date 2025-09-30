using System;

namespace TheOOPHotelP2
{
	internal class Manager : Person
	{
		public string Department { get; set }


		public Manager(string department) : base(name)
		{
			Department = department;
			Name = name;
		}


		public void HoldMeeting()
		{
			Console.WriteLine($"{name} is hosting a meeting for the hotel personell.");
		}
	}
}