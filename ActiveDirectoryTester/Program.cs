using System;
using System.DirectoryServices.Protocols;
using System.Net;

namespace ActiveDirectoryTester {
  public class Program {
    public static void Main(string[] args) {
      string server = args[0];
      string port = args[1];
      string username = args[2];
      string password = args[3];

      string url = server;
      if (!string.IsNullOrEmpty(port))
        url = url + ":" + port;

      try {
        using (var connection = new LdapConnection(url)) {
          var credentials = new NetworkCredential(username, password);
          connection.AuthType = AuthType.Negotiate;
          connection.Bind(credentials);
        }
        Console.WriteLine("SUCCESS");
      }
      catch (Exception e) {
        Console.WriteLine("ERROR");
        Console.WriteLine(e);
      }
    }
  }
}
