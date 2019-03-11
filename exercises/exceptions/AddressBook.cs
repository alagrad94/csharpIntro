
using System;
using System.Collections.Generic;

namespace exceptions {

  public class AddressBook {

    public Dictionary<string, Contact> contacts = new Dictionary<string, Contact>();

    public Contact GetByEmail (string email) {

      try {

        Contact contactToReturn = contacts[email];

        return contactToReturn;

      }
      catch (KeyNotFoundException) {

      return null;
      }
    }

    public void AddContact (Contact contact) {

      try {

        contacts.Add(contact.Email, contact);
        Console.WriteLine($"{contact.FullName} was added to your address book");
      }
      catch (ArgumentException) {

        Console.WriteLine($"{contact.FullName} is already in your address book.");
      }
    }

    public void PrintContacts () {
      foreach (KeyValuePair<string, Contact> cntc in contacts) {
        Console.WriteLine(cntc.Key);
      }
    }
  }
}