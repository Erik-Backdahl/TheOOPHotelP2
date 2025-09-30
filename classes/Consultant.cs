using System;


namespace TheOOPHotelP2
{
	internal class Consultant
	{
		public decimal HourlyRate { get; set; }
		public string ConsultingFirm { get; set; }


		public Consultant(decimal hourlyRate, string consultingFirm) : base(name)
		{
			HourlyRate = hourlyRate;
			ConsultingFirm = consultingFirm;
		}
		
		public GiveAdvice()
		{
			Console.WriteLine($"{name} gives advice on how the hotel may improve their routines and services.");
		}
	}
}