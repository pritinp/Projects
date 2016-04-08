using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint; // needed for interacting with SharePoint
using Microsoft.SharePoint.Client; // needed for interacting with SharePoint


namespace SharePointCSOMExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new instance of Client Context
            ClientContext context = new ClientContext("http://sp16-app-beta/sites/PritinTest/"); //creates an instance of ClientContext called context
            
            //Specify the credentials to use with the Client Context
            context.Credentials = CredentialCache.DefaultCredentials; // gets the credentials of the logged in user


            //creates an instance of the "Web" object to represent the specified Site Collection in Client Context
            Web site = context.Web;

            // retrieves the  Title and Language properties of the "site" object from the server
            //context.Load(site, x => x.Title, y => y.Language); 
            context.Load(site); //// retrieves all site properties
            context.ExecuteQuery(); //Executes the query
            Console.WriteLine("Site Title: " + site.Title);
            Console.WriteLine("Site Language: " + site.Language);


            
            
            
            
            ////Tryingt to check if a list exists first before executing code
            //ListCollection listExist = site.Lists;
            //ListCreationInformation lci2 = new ListCreationInformation()
            //site.Lists.TryGetList();

            ////SPList listExist = Web.Lists.TryGetList("Contacts from CSOM");
            //using (SPSite site = new SPSite("http://servername:000"))
            //{
            //    using (SPWeb web = site.OpenWeb())
            //    {
            //        SPList list = web.Lists.TryGetList(value);
            //        if (list != null)
            //        {
            //            // list exists, so do something meaningful here...
            //        }
            //        else
            //        {
            //            // list doesn't exist
            //        }
            //    }
            //}


            ////comment out this code if the list has already been created - start
            //ListCreationInformation lci = new ListCreationInformation()
            //{
            //    Title = "Contacts from CSOM",
            //    Url = "Lists/ContactsFromCsom",
            //    QuickLaunchOption = QuickLaunchOptions.On,
            //    TemplateType = (int)ListTemplateType.Contacts
            //};
            //site.Lists.Add(lci);
            ////comment out this code if the list has already been created - end

            //creates a new instance of a ListCollection
            ListCollection lists = site.Lists;

            ////Loads all properties for each list
            //context.Load(lists);
            //Loads only the properties of each list as specified by the Include parameters
            context.Load(lists, listProperties => listProperties.Include(listItem => listItem.Title, listItem => listItem.EnableVersioning));
            //Executes the query against SharePoint
            context.ExecuteQuery();

            //Outputs the specified properties of each list to the Console
            foreach (var list in lists)
            {
                Console.WriteLine(list.Title);
                Console.WriteLine(list.EnableVersioning);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
