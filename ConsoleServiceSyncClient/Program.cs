using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleServiceSyncClient.DMSUtility;

namespace ConsoleServiceSyncClient
{
    class Program
    {
        static void Main(string[] args)
        {
            DMSUtilityClient client = new DMSUtilityClient();
            Response r = client.DmsPing();
            Console.WriteLine(r);
        }
    }
}
