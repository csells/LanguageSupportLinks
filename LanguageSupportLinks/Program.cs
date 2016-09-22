using System;
using System.Linq;

namespace LanguageSupportLinks {
  class Program {
    /* use to form SO links for each language and each tech:
     * (multi-tag SO searches only work when you're logged in)
     * http://stackoverflow.com/questions/tagged/<tech>+<lang>
    <tech>+<lang> e.g. google-bigquery+c#
    <tech>+<lang> e.g. google-bigquery+go
    <tech>+<lang> e.g. google-bigquery+java
    <tech>+<lang> e.g. google-bigquery+node.js
    <tech>+<lang> e.g. google-bigquery+php
    <tech>+<lang> e.g. google-bigquery+python
    <tech>+<lang> e.g. google-bigquery+ruby
    */
    static string baseLink = "http://stackoverflow.com/questions/tagged/";
    // use "csharp" instead of "c#" -- SO returns "c" tagged questions when using "c#"
    static string[] langTags = new string[] { "csharp", "go", "java", "node.js", "php", "python", "ruby", };
    static string[] techTags = new string[] {
      "google-app-engine",
      "google-compute-engine",
      "google-container-engine",
      "kubernetes",
      "google-bigquery",
      "google-cloud-bigtable",
      "google-cloud-dataflow",
      "google-cloud-datastore",
      "gae-datastore",
      "google-cloud-pubsub",
      "google-cloud-sql",
      "google-cloud-storage",
      "google-prediction",
      "google-translate",
      "google-cloud-dns",
      "google-cloud-vision",
    };

    static void Main(string[] args) {
      foreach( var lang in langTags) {
        Console.WriteLine($"<h1>{lang}</h1><ul>");
        foreach (var tech in techTags) {
          var link = $"{baseLink}{tech}+{lang}";
          Console.WriteLine($"<li><a href='{link}'>{tech}</a></li>");
        }
        Console.WriteLine("</ul>");
      }
    }
  }
}
