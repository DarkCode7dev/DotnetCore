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
