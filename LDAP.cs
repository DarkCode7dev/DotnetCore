using System.DirectoryServices;

// create LDAP connection object
DirectoryEntry ldapConnection = new DirectoryEntry("LDAP://mydomain.com");

// set credentials for the connection
ldapConnection.Username = "myusername";
ldapConnection.Password = "mypassword";

// create LDAP search object
DirectorySearcher searcher = new DirectorySearcher(ldapConnection);

// set search criteria
searcher.Filter = "(objectClass=user)";
searcher.SearchScope = SearchScope.Subtree;

// execute search
SearchResultCollection resultCollection = searcher.FindAll();

// iterate over search results
foreach (SearchResult result in resultCollection)
{
    // get properties of search result
    ResultPropertyCollection properties = result.Properties;

    // iterate over properties
    foreach (string propertyName in properties.PropertyNames)
    {
        // get property values
        foreach (object propertyValue in properties[propertyName])
        {
            // do something with property value
            Console.WriteLine(propertyName + ": " + propertyValue);
        }
    }
}
===========.    

LDAP stands  for Lightweight
 Directory Access Protocol and 
it is used to access and manage directory information. In an ASP.NET application, LDAP can be used for authentication and authorization purposes. Here is an example code snippet showing how to use LDAP in an ASP.NET 
application :
Let's go through each line of this code snippet to understand what it does:

Line 1: Import the System.DirectoryServices namespace, which contains classes for working with directory services.
Line 4: Create a new DirectoryEntry object that represents the LDAP connection to the directory service. The LDAP://mydomain.com parameter specifies the LDAP server to connect to.
Line 7-8: Set the credentials for the LDAP connection. In this example, the username and password are hard-coded, but in a real-world application, you would retrieve these from a user input or a configuration file.
Line 11: Create a new DirectorySearcher object that represents the search operation to be performed on the directory service.
Line 14-15: Set the search criteria for the search operation. In this example, the filter specifies that only objects of class "user" should be returned, and the search scope is set to "subtree", meaning that the search should include all child objects of the search base.
Line 18: Execute the search operation and retrieve the results as a SearchResultCollection object.
Line 21-30: Iterate over the search results and their properties. For each property, iterate over its values and do something with each value (in this example, print it to the console).
