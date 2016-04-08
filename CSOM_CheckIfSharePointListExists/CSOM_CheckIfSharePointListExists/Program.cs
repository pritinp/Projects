using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Client;
using System.Net;

namespace CSOM_CheckIfSharePointListExists
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Trying to get this code to do the following:
            //Loading existing sharepoint lists into an array using "context.load(lists)"
            //Then, checking the "title" property of each item in the array to see if it matches "Contacts from CSOM" list name
            //If it does match, don't create a new list
            //If it doesn't match, create the list

            ClientContext context = new ClientContext("http://sp16-app-beta/sites/PritinTest/");

            context.Credentials = CredentialCache.DefaultCredentials;

            Web site = context.Web;

            //creates a new instance of a ListCollection
            ListCollection lists = site.Lists;

            //Loads all properties for each list
            context.Load(lists);

            //Executes the query against SharePoint
            context.ExecuteQuery();

            //Outputs the specified properties of each list to the Console
            foreach (var list in lists)
            {
                Console.WriteLine(list.Title);
            }


            //bool alreadyExists = lists.Any(x => x.Title);

            foreach (var list in lists)
            {
                //if (alreadyExists != "Contacts from CSOM")
                if (lists, x => x.Title1);
                {
                    Console.WriteLine("List already exists");
                }
                else
                {
                    Console.WriteLine("List does not exist");
                }
            }


            //foreach (var list in lists)
            //{
            //    if (list.Title == "Contacts from CSOM")
            //    {
            //        Console.WriteLine("List already exists");
            //    }
            //    else
            //    {
            //        Console.WriteLine("List does not exist");
            //    }
            //}

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();


        }
    }
}
