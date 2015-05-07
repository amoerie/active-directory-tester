# active-directory-tester

Usage:

    activedirectorytester.exe myserver myport myusername mypassword
    
Example
    
    activedirectorytester.exe localhost 389 jeff blueberries
    
Example output

    SUCCESS
  
or
  
    ERROR
    System.DirectoryServices.Protocols.LdapException: The supplied credential is invalid.
        at System.DirectoryServices.Protocols.LdapConnection.BindHelper(NetworkCredential newCredential, Boolean needSetCredential)
        at System.DirectoryServices.Protocols.LdapConnection.Bind(NetworkCredential newCredential)
        at ActiveDirectoryTester.Program.Main(String[] args) in c:\Workspace\active-directory-tester\ActiveDirectoryTester\Program.cs:line 21
