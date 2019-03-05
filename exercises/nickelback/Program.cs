using System;
using System.Collections.Generic;

namespace nickelback {

  class Program {

    static void Main() {

      List<Dictionary<string, string>> goodSongs = new List<Dictionary<string, string>>();

      HashSet<Dictionary<string, string>> allSongs = new HashSet<Dictionary<string, string>>();
      allSongs.Add(new Dictionary<string, string>(){{"The Eagles", "Seven Bridges Road"}});
      allSongs.Add(new Dictionary<string, string>(){{"Jimmy Buffet", "Margaritaville"}});
      allSongs.Add(new Dictionary<string, string>(){{"Jimmy Buffet", "Come Monday"}});
      allSongs.Add(new Dictionary<string, string>(){{"The Eagles", "Hotel California"}});
      allSongs.Add(new Dictionary<string, string>(){{"Nickelback", "Lullaby"}});
      allSongs.Add(new Dictionary<string, string>(){{"Nickelback", "Rockstar"}});
      allSongs.Add(new Dictionary<string, string>(){{"Nickelback", "Photograph"}});

      foreach (Dictionary<string, string> song in allSongs) {
        foreach (KeyValuePair<string, string> item in song) {
          if(item.Key != "Nickelback") {
            goodSongs.Add(song);
          }
        }
      }

      foreach (Dictionary<string, string> song in goodSongs) {
        foreach (KeyValuePair<string, string> item in song) {
          Console.WriteLine($"{item.Value} is an awesome song by {item.Key}");
        }
      }
    }
  }
}
