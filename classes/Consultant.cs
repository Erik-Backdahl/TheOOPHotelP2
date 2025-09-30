using System;


namespace TheOOPHotelP2
{
	internal class Consultant : Person
	{
		public decimal HourlyRate { get; set; }
		public string ConsultingFirm { get; set; }


		public Consultant(decimal hourlyRate, string consultingFirm)
		{
			HourlyRate = hourlyRate;
			ConsultingFirm = consultingFirm;
		}
		
		public void GiveAdvice()
		{
			Console.WriteLine($"{Name} gives advice on how the hotel may improve their routines and services.");
		}
	}
}