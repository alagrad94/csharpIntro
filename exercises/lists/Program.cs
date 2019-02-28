using System;
using System.Collections.Generic;

namespace lists
{
	public class Program {
		public static void Main(string[] args) {

			List<string> planetList = new List<string>() {"Mercury", "Mars"};
			Console.WriteLine("First List");
			foreach( string planet in planetList )
				{
					Console.WriteLine(planet);
				}

			planetList.Add("Jupiter");
			planetList.Add("Saturn");

			Console.WriteLine("\nSecond List");
			foreach( string planet in planetList )
				{
					Console.WriteLine(planet);
				}

			List<string> outerPlanets = new List<string>() {"Uranus", "Neptune"};

			planetList.AddRange(outerPlanets);

			Console.WriteLine("\nThird List");
			foreach( string planet in planetList )
				{
					Console.WriteLine(planet);
				}

			planetList.Insert(1, "Venus");
			planetList.Insert(2, "Earth");

			Console.WriteLine("\nFourth List");
			foreach( string planet in planetList )
				{
					Console.WriteLine(planet);
				}

			planetList.Add("Pluto");

			Console.WriteLine("\nFifth List");
			foreach( string planet in planetList )
				{
					Console.WriteLine(planet);
				}

			List<string> rockyPlanets = planetList.GetRange(0,3);

			Console.WriteLine("\nSixth List");
			foreach( string planet in rockyPlanets )
				{
					Console.WriteLine(planet);
				}

			planetList.Remove("Pluto");

			Console.WriteLine("\nSeventh List");
			foreach( string planet in planetList )
				{
					Console.WriteLine(planet);
				}
		}
	}
}
