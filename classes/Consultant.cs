using System;


namespace LabbTheOOPHotelP2
{
	internal class Consultant : Employee
	{
		public required string ConsultingFirm { get; set; }

        public void GiveAdvice()
		{
			Console.WriteLine($"{Name} gives advice on how the hotel may improve their routines and services.");
		}
	}
}