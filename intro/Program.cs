using System;

namespace bangazoncli
{
	class Program
	{
		public static void Main(string[] args)
		{

			DateTime purchaseDate = DateTime.Now;
			string lastName = "Smith";
			var firstName = "Bill";

			string[] products = new string[] {
				"Motorcycle",
				"Sofa",
				"Sandals",
				"Omega Watch",
				"iPhone"
			};

			foreach (string product in products) {
    		if (product.Length < 5) {
        	Console.WriteLine($"{product} has a short name");
    		} else if (product.Length < 10) {
        	Console.WriteLine($"{product} has a medium-sized name");
    		} else {
        	Console.WriteLine($"{product} has a long name");
    		}
			}

			Console.WriteLine($"{firstName} {lastName} purchased on {purchaseDate}");
		}
	}
}
