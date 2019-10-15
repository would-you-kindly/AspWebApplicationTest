using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.ServiceModel.Description;
using WcfAsWindowsService;

namespace WcfAsWebService
{
    class Program
    {
        static void Main(string[] args)
        {
            WebServiceHost host = new WebServiceHost(typeof(Calculator), new Uri("http://localhost:8001/ServiceModelSamples/service"));
            try
            {
                ServiceEndpoint ep = host.AddServiceEndpoint(typeof(ICalculator), new WebHttpBinding(), "");
                host.Open();
                using (ChannelFactory<ICalculator> cf = new ChannelFactory<ICalculator>(new WebHttpBinding(), "http://localhost:8001/ServiceModelSamples/service"))
                {
                    cf.Endpoint.Behaviors.Add(new WebHttpBehavior());

                    ICalculator channel = cf.CreateChannel();

                    string s;

                    Console.WriteLine("Calling EchoWithGet via HTTP GET: ");
                    s = channel.Add("Hello, world", 123.ToString());
                    Console.WriteLine("   Output: {0}", s);

                    Console.WriteLine("");
                    Console.WriteLine("This can also be accomplished by navigating to");
                    Console.WriteLine("http://localhost:8000/EchoWithGet?s=Hello, world!");
                    Console.WriteLine("in a web browser while this sample is running.");

                    Console.WriteLine("");
                }

                Console.WriteLine("Press <ENTER> to terminate");
                Console.ReadLine();

                host.Close();
            }
            catch (CommunicationException cex)
            {
                Console.WriteLine("An exception occurred: {0}", cex.Message);
                Console.ReadLine();
                host.Abort();
            }
        }
    }
}
