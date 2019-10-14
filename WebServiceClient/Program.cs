using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceClient.ServiceReference1;

namespace WebServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            TestServiceClient client = new TestServiceClient();
            Console.WriteLine(client.GetAllTutorials());

            Console.ReadLine();
        }
    }
}
