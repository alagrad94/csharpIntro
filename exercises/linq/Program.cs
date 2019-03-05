using System;
using System.Collections.Generic;
using System.Linq;

namespace linq {

  public class Bank {
    public string Symbol { get; set; }
    public string Name { get; set; }
  }

  public class Customer {
    public string Name { get; set; }
    public double Balance { get; set; }
    public string Bank { get; set; }
  }

  public class BankReportEntry{
    public string BankEntry { get; set; }
    public int BankCount { get; set; }
  }

  public class ReportItem {
    public string CustomerName { get; set; }
    public string BankName { get; set; }
  }

  class Program {

    static void Main() {

      // Find the words in the collection that start with the letter 'L'
      List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

      IEnumerable<string> LFruits = from fruit in fruits
        where fruit[0] == 'L'
        select fruit;

      Console.WriteLine("The fruits tha begin with L are: ");
      foreach (string fruit in LFruits) {
          Console.WriteLine(fruit);
      }
      Console.WriteLine("--------------------------------------------");

      // Which of the following numbers are multiples of 4 or 6
      List<int> numbers = new List<int>(){15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96};

      IEnumerable<int> fourSixMultiples = numbers.Where(number => number % 4 == 0 || number % 6 == 0).OrderBy(n => n);
      Console.WriteLine("The numbers that are multiples of 4 or 6 are: ");
      foreach (int number in fourSixMultiples) {
          Console.WriteLine(number);
      }
      Console.WriteLine("--------------------------------------------");

      // Order these student names alphabetically, in descending order (Z to A)
      List<string> names = new List<string>(){
        "Heather", "James", "Xavier", "Michelle", "Brian", "Nina", "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice", "Theodora", "William", "Svetlana", "Charisse", "Yolanda", "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline", "Francisco", "Tre"};

      IEnumerable<string> descend = from name in names
        orderby name descending
        select name;

      Console.WriteLine("The names in reverse alphabetical order are: ");
      foreach (string name in descend) {
          Console.WriteLine(name);
      }
      Console.WriteLine("--------------------------------------------");

      // Build a collection of these numbers sorted in ascending order
      List<int> numbers2 = new List<int>() {15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96};
      IEnumerable<int> orderedNum = from number2 in numbers2
        orderby number2 ascending
        select number2;

      Console.WriteLine("The numbers in order are: ");
      foreach (int number in orderedNum) {
          Console.WriteLine(number);
      }
      Console.WriteLine("--------------------------------------------");

      // Output how many numbers are in this list
      List<int> numbers3 = new List<int>() {15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96};
      Console.WriteLine($"There are {numbers3.Count()} numbers in the list");
      Console.WriteLine("--------------------------------------------");

      // How much money have we made?
      List<double> purchases = new List<double>() {2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65};
      Console.WriteLine($"We have made ${purchases.Sum()}.");
      Console.WriteLine("--------------------------------------------");

      // What is our most expensive product?
      List<double> prices = new List<double>(){879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76};
      Console.WriteLine($"The most expensive product costs ${prices.Max()}.");
      Console.WriteLine("--------------------------------------------");

      //Store each number in the following List until a perfect square is detected.
      List<int> wheresSquaredo = new List<int>(){66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14};
      IEnumerable<int> notSquares = wheresSquaredo.TakeWhile(number => ((Math.Sqrt(number)*Math.Sqrt(number)) != number));
      Console.WriteLine("The numbers occuring before the first perfect square are: ");
      foreach (int number in notSquares) {
          Console.WriteLine(number);
      }
      Console.WriteLine("--------------------------------------------");

      // Build a collection of customers who are millionaires
      // Create some customers and store in a List
      List<Customer> customers = new List<Customer>() {
        new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
        new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
        new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
        new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
        new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
        new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
        new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
        new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
        new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
        new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
      };

      IEnumerable<BankReportEntry> millionairesReport = (from customer in customers
        where customer.Balance >= 1000000
        group customer by customer.Bank into bankGroup
        select new BankReportEntry {
          BankEntry = bankGroup.Key,
          BankCount = bankGroup.Count(customerObj => customerObj.Bank == bankGroup.Key)
        });

      Console.WriteLine("The number of millionaires at each bank is: ");
      foreach (BankReportEntry entry in millionairesReport) {
          Console.WriteLine($"{entry.BankEntry}: {entry.BankCount}");
      }
      Console.WriteLine("--------------------------------------------");

      //Output the millionaires, but you will also display the full name of the bank. You also need to sort the millionaires' names, ascending by their LAST name.

      List<Bank> banks = new List<Bank>() {
        new Bank(){ Name="First Tennessee", Symbol="FTB"},
        new Bank(){ Name="Wells Fargo", Symbol="WF"},
        new Bank(){ Name="Bank of America", Symbol="BOA"},
        new Bank(){ Name="Citibank", Symbol="CITI"},
      };


      IEnumerable<ReportItem> millionaireReport2 = (from customer in customers
        where customer.Balance >= 1000000
        orderby customer.Name.Split(' ')[1]
        join bank in banks on customer.Bank equals bank.Symbol
        select new ReportItem {
          CustomerName = customer.Name,
          BankName = bank.Name
        });

      Console.WriteLine("The the names of the millionaires and thier banks are: ");
      foreach (ReportItem item in millionaireReport2) {
        Console.WriteLine($"{item.CustomerName} at {item.BankName}");
      }
    }
  }
}
