using System;
using System.Collections.Generic;

namespace sets
{
	class Program {
		static void Main() {

			HashSet<string> showroom = new HashSet<string>(){"Camry", "F-150", "MDX"};

			Console.WriteLine("Showroom contains {0} cars", showroom.Count);
			showroom.Add("Camry");
			foreach (string vehicle in showroom){
					Console.WriteLine($"{vehicle}");
			}

			HashSet<string> usedLot = new HashSet<string>(){"Taurus", "Xterra", "Mustang"};

			showroom.UnionWith(usedLot);

			Console.WriteLine("Showroom contains {0} cars", showroom.Count);
			foreach (string vehicle in showroom){
					Console.WriteLine($"{vehicle}");
			}

			showroom.Remove("Taurus");

			Console.WriteLine("Showroom contains {0} cars", showroom.Count);
			foreach (string vehicle in showroom){
					Console.WriteLine($"{vehicle}");
			}

			HashSet<string> junkyard = new HashSet<string>(){"Taurus", "Xterra", "Mustang", "Suburban", "Santa Fe", "Escalade", "Xterra"};

			HashSet<string> clone = new HashSet<string>(showroom);

			clone.IntersectWith(junkyard);

			Console.WriteLine("Clone contains {0} cars", clone.Count);
			foreach (string vehicle in clone){
					Console.WriteLine($"{vehicle}");
			}

			showroom.UnionWith(junkyard);

			Console.WriteLine("Showroom contains {0} cars", showroom.Count);
			foreach (string vehicle in showroom){
					Console.WriteLine($"{vehicle}");
			}

			showroom.Remove("Taurus");
			showroom.Remove("Santa Fe");

			Console.WriteLine("Showroom contains {0} cars", showroom.Count);
			foreach (string vehicle in showroom){
					Console.WriteLine($"{vehicle}");
			}
    }
	}
}
