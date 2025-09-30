using System;


namespace LabbTheOOPHotelP2
{
	internal class Consultant(string name, string ssn, decimal hourlyRate, string consultingFirm) : Person(name, ssn)
	{
		public decimal HourlyRate { get; set; } = hourlyRate;
		public string ConsultingFirm { get; set; } = consultingFirm;

        public void GiveAdvice()
		{
			Console.WriteLine($"{Name} gives advice on how the hotel may improve their routines and services.");
		}
	}
}