using System;

namespace LabbTheOOPHotelP2
{
	internal class Manager : Employee
	{
		public Manager()
		{
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