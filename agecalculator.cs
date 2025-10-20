using System;
using System.Threading;

namespace agecalc {
	class App {
		static void Main() {
			Console.WriteLine("Welcome to Age calculator!");
			int year = DateTime.Now.Year; // Stores Current Year
			Thread.Sleep(2000);
			Console.WriteLine("What is your birth year: ");
			int byear = Convert.ToInt32(Console.ReadLine());
			if (byear > year) {
				return; // If the birth year entered value is larger than the current year, the project will stop
			} else {
				Console.WriteLine("Was it your birthday this year (Answer in True or false): ");
				bool birthday = Convert.ToBoolean(Console.ReadLine());
				if (birthday == true) {
					Console.WriteLine(year - byear); // Gets the updated age
				} else if (birthday == false) {
					Console.WriteLine(year - byear - 1); // Get the age before a birthday
				}
			}
		}
	}
}
