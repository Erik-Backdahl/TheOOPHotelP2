using System;

namespace LabbTheOOPHotelP2
{
	public class Housekeeper : Person
	{
		public Housekeeper()
		{

		}
		public void Work()
		{
			Console.WriteLine($"{Name} cleans the hotel rooms.");
		}
	}
}
