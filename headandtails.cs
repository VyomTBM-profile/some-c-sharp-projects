using System;

namespace headsandtails {
	class main {
		static void Main() {
			Console.WriteLine("Welcome to Head and Tails!");
			string h = "Heads";
			string t = "Tails";
			var rand = new Random();
			string values = rand.Next(2) == 0 ? h : t; // The picking random values
			Console.WriteLine($"Picked: " + values);
		}
	}
}
