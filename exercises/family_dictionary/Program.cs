using System;
using System.Collections.Generic;

namespace family_dictionary {

  class Program {

    static void Main() {

      Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

      myFamily.Add("sister", new Dictionary<string, string>(){
      {"name", "Maridell"},
      {"age", "54"}
      });

      myFamily.Add("brother", new Dictionary<string, string>(){
      {"name", "Richard"},
      {"age", "47"}
      });

      myFamily.Add("mother", new Dictionary<string, string>(){
      {"name", "Judith"},
      {"age", "77"}
      });

      myFamily.Add("father", new Dictionary<string, string>(){
      {"name", "Calvin"},
      {"age", "78"}
      });

      foreach(KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily) {

        string Name = "";
        string Age = "";

        foreach (KeyValuePair<string, string> detail in familyMember.Value) {

          if (detail.Key == "name") {
            Name = detail.Value;
          } else if (detail.Key == "age") {
            Age = detail.Value;
          }
        }

        Console.WriteLine($" {Name} is my {familyMember.Key} and is {Age} years old");
      }
    }
  }
}
