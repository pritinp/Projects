using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Client;
using Microsoft.Xrm.Client.Services;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleConnectToCRM
{
    class Program
    {
        static void Main(string[] args)
        {
            CrmConnection con = new CrmConnection("CRM");

            IOrganizationService service = new OrganizationService(con);

            var response = service.Execute(new WhoAmIRequest());



        }
    }
}
