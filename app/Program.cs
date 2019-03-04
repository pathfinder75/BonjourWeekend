using System;
using static System.Console;

namespace BonjourWeekend
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			WriteLine("What is your name...?");
			String UserName = ReadLine();
			String Jour = String.Format($"{DateTime.Now.DayOfWeek}");

			int Heure = DateTime.Now.Hour;

			if (Jour == "Monday" && Heure > 9 || Jour == "Tuesday" || Jour == "Wednedsay" || Jour == "Thursday" || Jour == "Friday" && Heure < 17)
			{


				WriteLine($"Bonjour {UserName} vous etes en semaine");


			}
			else if(Jour == "Saturday" || Jour == "Sunday" || Jour == "Monday" & Heure < 9 || Jour == "Friday" && Heure > 17)
			{
				WriteLine($"Bonjour {UserName} vous etes en Week-end");
			}
		}
	}
}
