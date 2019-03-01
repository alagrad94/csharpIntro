using System;
using System.Collections.Generic;

namespace dictionaries {
	class Program {
		static void Main() {

			Dictionary<string, string> stocks = new Dictionary<string, string>();
			stocks.Add("GM", "General Motors");
			stocks.Add("CAT", "Caterpillar");

			List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();
			purchases.Add(new Dictionary<string, double>(){ {"GM", 230.21} });
			purchases.Add(new Dictionary<string, double>(){ {"GM", 235.21} });
			purchases.Add(new Dictionary<string, double>(){ {"CAT", 580.98} });
			purchases.Add(new Dictionary<string, double>(){ {"CAT", 406.34} });


			Dictionary<string, double> stockReport = new Dictionary<string, double>();

			foreach (Dictionary<string, double> purchase in purchases) {

    		foreach (KeyValuePair<string, double> stock in purchase) {
					string key = $"{stock.Key}";
					string fullName = stocks[stock.Key];

					if(stockReport.ContainsKey(fullName)) {
						stockReport[fullName] += stock.Value;
    			} else {
						stockReport.Add($"{fullName}", stock.Value);
					}
				}
			}
			foreach (KeyValuePair<string, double> stock in stockReport)
			{
				Console.WriteLine($"The position in {stock.Key} is worth {stock.Value}");
			}

			List<string> planetList = new List<string>(){"Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune"};
			List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();
			probes.Add(new Dictionary<string, string>() { {"Mariner 10", "Mercury"}, {"Messenger", "Mercury"}, {"BepiColombo", "Mercury"}, {"Mariner 1", "Venus"}, {"Mariner 2", "Venus"},{"Mariner 5", "Venus"}, {"Pioneer", "Venus"}, {"Galileo", "Venus"}, {"Magellan", "Venus"}, {"Pioneer 10", "Jupiter"}, {"Voyager 1", "Jupiter"}, {"Voyager 2", "Jupiter"}, {"Ulysses", "Jupiter"}, {"Cassini-Huygens", "Jupiter"}, {"New Horizons", "Jupiter"}, {"Juno", "Jupiter"}, {"Pioneer 11", "Saturn"}, {"Cassini", "Saturn"}, {"Huygens", "Saturn"}, {"Viking", "Mars"}, {"Opportunity", "Mars"}, {"Curiosity", "Mars"}, {"Mariner 3", "Earth"}, {"Mariner 6", "Earth"}, {"Mariner 7", "Earth"}, {"Voyager", "Uranus"}, {"Voyager2", "Neptune"} });

			foreach (string planet in planetList) {

				List<string> matchingProbes = new List<string>();

				foreach (Dictionary<string, string> probe in probes) {

					foreach (KeyValuePair<string, string> craft in probe) {

						string planetName = craft.Value;
						string probeName = craft.Key;

						if(!matchingProbes.Contains(probeName) && planet == planetName) {
							matchingProbes.Add(probeName);
						}
					}
				}
				string probeList = String.Join(", ", matchingProbes);
				Console.WriteLine($"{planet}: {probeList}");
			}
		}
	}
}
