using System;
using System.Collections.Generic;

namespace classes {

  public class Employee {

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Title { get; set; }

    public DateTime StartDate { get; set; }

  }

  public class Company {
    public Company(string name, DateTime dateCreated) {
      Name = name;
      CreatedOn = dateCreated;
      Employees = new List<Employee>();
    }
    public string Name { get; }
    public DateTime CreatedOn { get; }

    public List<Employee> Employees { get; set; }

    public void ListEmployees () {

      foreach (Employee employee in Employees) {
       Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {Name} as {employee.Title} since {employee.StartDate}");
      };
    }

  }

	class Program {
		static void Main() {

      Company rrInc = new Company ("rrInc", DateTime.Now);

			Employee newEmployee = new Employee() {
        FirstName = "Russ",
        LastName = "Reiter",
        Title = "Bossmamn",
        StartDate = new DateTime (20190101)
      };

      Employee newEmployee2 = new Employee() {
        FirstName = "Ashwin",
        LastName = "Prakash",
        Title = "Underling",
        StartDate = new DateTime (20190101)
      };

      Employee newEmployee3 = new Employee() {
        FirstName = "JD",
        LastName = "Wheeler",
        Title = "Underling",
        StartDate = new DateTime (20190101)
      };

      rrInc.Employees.Add(newEmployee);
      rrInc.Employees.Add(newEmployee2);
      rrInc.Employees.Add(newEmployee3);

      rrInc.ListEmployees();
		}
	}
}
