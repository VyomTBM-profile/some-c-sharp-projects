using System;
using System.IO;
using System.Threading;

namespace credtobase64 {
    class mainprogram {
        static void Main() {
            Console.WriteLine("Credentials to Base64 encrypter");
            Console.WriteLine("You have to enter your name, age and country name");
            Thread.Sleep(3000); // Loading
			Console.WriteLine("Name: ");
            string name = Console.ReadLine();
			Console.WriteLine("Age: ");
            string age = Console.ReadLine();
			Console.WriteLine("Country: ");
            string country = Console.ReadLine();
            Console.WriteLine("Your Base64 .txt file will be ready and downloaded in a sepcial random number as the file name");
			string input = (name + "\n " + age + "\n " + country);
            string basetext = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(input)); // Converts the entered details to a encrypted Base64 string
            var rand = new Random();
            int number = rand.Next(4000, 8000); // Picks a random number between 4000 and 8000
            File.WriteAllText(number + ".txt", basetext); // Exports
        }
    }
}
