using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfCalculatorClient.CalculatorService;

namespace WcfCalculatorClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorClient client = new CalculatorClient();
            Console.WriteLine(client.Add(5, 6));

            Console.ReadLine();
        }
    }
}
