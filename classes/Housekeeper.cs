using System;

namespace LabbTheOOPHotelP2
{
	public class Housekeeper : Person
	{
		public Housekeeper(string name, string surname) : base(name, surname)
		{

		}


		public void Work()
		{
			Console.WriteLine($"{Name} cleans the hotel rooms.");
		}
	}
}
